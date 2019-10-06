using HubIT_FInal_Project;
using HubIT_FInal_Project.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class is the Main window.
    /// </summary>
    public partial class MainForm : Form
    {
        // local variables
        int PW;
        bool isHide;
        Stack st = new Stack();
        protected internal LinkedList<Control> tc = new LinkedList<Control>();
        TopicControl topic = new TopicControl();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            PW = slidingPanel.Width;
            isHide = true;
            slidingPanel.Width = 0;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Globals g = new Globals();

            // this displays all available programming languages.
            for (int i = 0; i < g.programming_category.Length; i++)
            {
                language_cb.Items.Add(g.programming_category[i]);
            }

            // this displays all available file extensions.
            //for (int i = 0; i < g.extension_category.Length; i++)
            //{
            //    fileType_cb.Items.Add(g.extension_category[i]);
            //}

            // this displays all available topics.
            for (int i = 0; i < g.topic_category.Length; i++)
            {
                topic_cb.Items.Add(g.topic_category[i]);
            }

            // display all topic.
            displayTopic();
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (isHide)
            {
                slidingPanel.Width = slidingPanel.Width + 10;
                if (slidingPanel.Width >= 158)
                {
                    slideTimer.Stop();
                    isHide = false;
                    this.Refresh();
                }
            }
            else
            {
                slidingPanel.Width = slidingPanel.Width - 10;
                if (slidingPanel.Width <= 0)
                {
                    slideTimer.Stop();
                    isHide = true;
                    this.Refresh();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Visible = true;
        }

        private void TopicBtn_Click(object sender, EventArgs e)
        {
            showCurrentUserTopic();
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            mainMenuControl.Visible = false;
        }

        private void SlideBtn_Click(object sender, EventArgs e)
        {
            slideTimer.Start();
        }

        private void addTopicBtn_Click(object sender, EventArgs e)
        {
            // temporary (REPLACE WITH catefory_selection.cs)
            CategoryForm cs = new CategoryForm();
            cs.Show();
        }

        private void GlobalTopicBtn_Click(object sender, EventArgs e)
        {
            displayTopic();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            // filtering programming languages base on user choice.
            filterLanguage();
        }

        private void FilterTopicBtn_Click(object sender, EventArgs e)
        {
            filterTopic();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

        private void Closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileLibraryBtn_Click(object sender, EventArgs e)
        {
            FileForm ff = new FileForm();
            ff.Show();
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
        /// This method is called when the current user
        /// wants to see all topics created by other users.
        /// </summary>
        protected internal void displayTopic()
        {
            flowLayoutPanel1.Controls.Clear();

            int? count;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT topic_title, topic_desc, topic_type, topic_date, user_name, category_type FROM topic", db.getConnection());


            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                topic = new TopicControl();
                topic.label1.Text = reader.GetString("topic_title");
                topic.textBox1.Text = reader.GetString("topic_desc");
                topic.userLabel.Text = reader.GetString("user_name");
                tc.AddFirst(topic);
                flowLayoutPanel1.Controls.Add(topic);
            }

        }
            
        /// <summary>
        /// This method is called when the current user
        /// wants to filter everything by the category given.
        /// </summary>
        public void filterLanguage()
        {
            flowLayoutPanel1.Controls.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT topic_title, topic_desc, user_name FROM topic WHERE category_type = @type", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = language_cb.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            // programming language category
            if (language_cb.SelectedItem == "Java")
            {

                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (language_cb.SelectedItem == "Python")
            {

                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (language_cb.SelectedItem == "C++")
            {

                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (language_cb.SelectedItem == "C#")
            {

                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }

           

            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the current user
        /// wants to filter topics by topics.
        /// </summary>
        public void filterTopic()
        {
            flowLayoutPanel1.Controls.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT topic_title, topic_desc, user_name FROM topic WHERE topic_type = @topic", db.getConnection());
            command.Parameters.Add("@topic", MySqlDbType.VarChar).Value = topic_cb.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            // topic category
            if (topic_cb.SelectedItem == "Inheritance")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (topic_cb.SelectedItem == "Abstraction")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (topic_cb.SelectedItem == "If-Else statements")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (topic_cb.SelectedItem == "Loops")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (topic_cb.SelectedItem == "Arrays")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
            else if (topic_cb.SelectedItem == "Declaring variables")
            {
                while (reader.Read())
                {
                    topic = new TopicControl();
                    topic.label1.Text = reader.GetString("topic_title");
                    topic.textBox1.Text = reader.GetString("topic_desc");
                    topic.userLabel.Text = reader.GetString("user_name");
                    tc.AddFirst(topic);
                    flowLayoutPanel1.Controls.Add(topic);
                }
            }
        }

        /// <summary>
        /// This method is called when the current user
        /// wants to see his/her created topics.
        /// </summary>
        public void showCurrentUserTopic()
        {
            flowLayoutPanel1.Controls.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `topic_title`, `topic_desc`, `user_name` FROM `topic` WHERE `user_name` = @user", db.getConnection());
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = UserAccountLabel.Text;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                topic = new TopicControl();
                topic.label1.Text = reader.GetString("topic_title");
                topic.textBox1.Text = reader.GetString("topic_desc");
                topic.userLabel.Text = reader.GetString("user_name");
                tc.AddFirst(topic);
                flowLayoutPanel1.Controls.Add(topic);
            }
        }

        
    }
}
