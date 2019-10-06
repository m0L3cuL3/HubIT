using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

/// <summary>
/// This namespace is handling every class
/// in the system.
/// </summary>
namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class handles the user registeration.
    /// </summary>
    public partial class RegisterForm : Form
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
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When frame/window loads, it runs the statement inside.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = groupBox1;
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.InitialDelay = 50;
            tt.SetToolTip(textBoxBirthdate, "Format: YYYY-MM-DD");
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "first name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "confirm password";
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void textBoxBirthdate_Enter(object sender, EventArgs e)
        {
            String birthdate = textBoxBirthdate.Text;
            if (birthdate.ToLower().Trim().Equals("birthdate"))
            {
                textBoxBirthdate.Text = "";
                textBoxBirthdate.ForeColor = Color.Black;
            }
        }

        private void textBoxBirthdate_Leave(object sender, EventArgs e)
        {
            String birthdate = textBoxBirthdate.Text;
            if (birthdate.ToLower().Trim().Equals("birthdate") || birthdate.Trim().Equals(""))
            {
                textBoxBirthdate.Text = "birthdate";
                textBoxBirthdate.ForeColor = Color.Gray;
            }
        }

        private void textBoxGender_Enter(object sender, EventArgs e)
        {
            String gender = textBoxGender.Text;
            if (gender.ToLower().Trim().Equals("gender"))
            {
                textBoxGender.Text = "";
                textBoxGender.ForeColor = Color.Black;
            }
        }

        private void textBoxGender_Leave(object sender, EventArgs e)
        {
            String gender = textBoxGender.Text;
            if (gender.ToLower().Trim().Equals("gender") || gender.Trim().Equals(""))
            {
                textBoxGender.Text = "gender";
                textBoxGender.ForeColor = Color.Gray;
            }
        }

        private void textBoxOccupation_Enter(object sender, EventArgs e)
        {
            String occupation = textBoxOccupation.Text;
            if (occupation.ToLower().Trim().Equals("occupation"))
            {
                textBoxOccupation.Text = "";
                textBoxOccupation.ForeColor = Color.Black;
            }
        }

        private void textBoxOccupation_Leave(object sender, EventArgs e)
        {
            String occupation = textBoxOccupation.Text;
            if (occupation.ToLower().Trim().Equals("occupation") || occupation.Trim().Equals(""))
            {
                textBoxOccupation.Text = "occupation";
                textBoxOccupation.ForeColor = Color.Gray;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            String address = textBoxAddress.Text;
            if (address.ToLower().Trim().Equals("address"))
            {
                textBoxAddress.Text = "";
                textBoxAddress.ForeColor = Color.Black;
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            String address = textBoxAddress.Text;
            if (address.ToLower().Trim().Equals("address") || address.Trim().Equals(""))
            {
                textBoxAddress.Text = "address";
                textBoxAddress.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // add a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`user_name`, `user_lname`, `user_fname`, `user_email`, `user_occupation`, `user_gender`, `user_birthdate`, `user_password`, `user_address`) VALUES (@username, @lname, @fname, @email, @occupation, @gender, @birthdate, @password, @address)", db.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@birthdate", MySqlDbType.VarChar).Value = textBoxBirthdate.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = textBoxGender.Text;
            command.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = textBoxOccupation.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBoxAddress.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if(textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created","Account Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Enter Your Informations First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
            

            // close the connection
            db.closeConnection();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBoxUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `user_name` = @user", db.getConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;

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

        // check if the textboxes contains the default values
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if(fname.Equals("first name") || lname.Equals("last name") || 
                email.Equals("email address") || uname.Equals("username")
                || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Yellow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        
    }
}
