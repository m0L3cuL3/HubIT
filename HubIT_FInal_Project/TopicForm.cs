using HubIT_FInal_Project.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class is the add topic window.
    /// </summary>
    public partial class TopicForm : Form
    {
        TopicControl topic = new TopicControl();
        LinkedList<Control> tc = new LinkedList<Control>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public TopicForm()
        {
            InitializeComponent();
        }

        private void addTopic_form_Load(object sender, EventArgs e)
        {

        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// This method allows the user to add topic to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            if(verifyUpload())
            {
                if (title_txtBox.Text != "" && desc_txtBox.Text != "")
                {
                    addTopic();
                    MessageBox.Show("Topic Posted Successfully!", "Topic Post", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please enter details to continue.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Account not verified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// this method is called when the current user
        /// wants to add a topic.
        /// </summary>
        protected internal void addTopic()
        {
            

            DB db = new DB();
            Globals g = new Globals();
            MainForm mf = new MainForm();
            MySqlCommand command = new MySqlCommand("INSERT INTO `topic`(`topic_title`, `topic_desc`, `topic_type`, `topic_date`, `user_name`, `category_type`) VALUES (@title, @desc, @type, now(), @user, @category)", db.getConnection());
            // update topic set uid=(select uid from user where topic.uid = user.uid)
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title_txtBox.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc_txtBox.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = TopicTypeLabel.Text;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = LanguageTypeLabel.Text;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = userTxtBox.Text;

            db.openConnection();

            topic = new TopicControl();
            topic.Title = title_txtBox.Text;
            topic.Message = desc_txtBox.Text;
            topic.userLabel.Text = userTxtBox.Text;
            topic.Icon = Resources.user1;
            mf.tc.AddFirst(topic);
            mf.flowLayoutPanel1.Controls.Add(topic);

            command.ExecuteNonQuery();

            db.closeConnection();

        }

        /// <summary>
        /// This method is called when the current user
        /// is not verified.
        /// </summary>
        /// <returns></returns>
        public Boolean verifyUpload()
        {
            DB db = new DB();

            String username = userTxtBox.Text;
            String password = passTxtBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `user_name` = @user AND `user_password` = @pass", db.getConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
