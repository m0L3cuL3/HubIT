using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HubIT_FInal_Project
{

    /// <summary>
    /// This class is the Login window.
    /// </summary>
    public partial class LoginForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Initializes the objects inside the constructor.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
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
        /// This closes the application.
        /// </summary>
        /// <param name="sender">Contains a reference to the control/object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        /// <summary>
        /// When clicked and the data entered are correct then it shows another frame/window.
        /// </summary>
        /// <param name="sender">Contains a reference to the control/object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (userRadioBtn.Checked)
            {
                DB db = new DB();

                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
               
                MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `user_name` = @user and `user_password` = @pass", db.getConnection());

                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                db.openConnection();

                adapter.SelectCommand = command;

                adapter.Fill(table);

                // check if the user exists or not
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainform = new MainForm();   
                    mainform.UserAccountLabel.ForeColor = Color.Lime;
                    mainform.UserAccountLabel.Text = username;
                    mainform.Show();
                }
                else
                {
                    if (username.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (adminRadioBtn.Checked)
            {
                DB db = new DB();

                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `manager` WHERE `manager_username` = @user and `manager_password` = @pass", db.getConnection());

                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                // check if the user exists or not
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    ManagerForm mf = new ManagerForm();
                    mf.Show();
                }
                else
                {
                    if (username.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (!userRadioBtn.Checked || !adminRadioBtn.Checked)
            {
                MessageBox.Show("Please select the user type.", "User Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// When clicked it redirects the user to a another frame/window.
        /// Which is the RegisterForm.
        /// </summary>
        /// <param name="sender">Contains a reference to the control/object that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

    }
}
