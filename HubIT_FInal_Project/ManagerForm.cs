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
using MySql.Data.MySqlClient;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class is the manager window.
    /// </summary>
    public partial class ManagerForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // display registered users on form load.
            displayUsers();

            // display all managers on form load.
            displayManagers();

            // display all topics created by users on form load.
            displayTopics();

            // display all files upload by users on form load.
            displayFiles();
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertUserBtn_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void ManagerCreateBtn_Click(object sender, EventArgs e)
        {
            createManagers();
        }

        private void ManagerDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this account?", "Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                deleteManager();
                MessageBox.Show("Account Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Account Deletion Cancelled!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TopicDeleteBtn_Click(object sender, EventArgs e)
        {
            deleteTopic();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Visible = true;
        }

        private void DeleteFileIdBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `file` WHERE file_id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = DeleteFileIdTxtBox.Text;

            db.openConnection();

            if (DeleteFileIdTxtBox.Text == "")
            {
                MessageBox.Show("Please Enter File ID.", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {           
                command.ExecuteNonQuery();
                displayFiles();
            }
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to delete a user in the database.
        /// </summary>
        public void deleteUser()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE uid = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = DeleteUidtxtBox.Text;

            db.openConnection();

            if (DeleteUidtxtBox.Text == "")
            {
                MessageBox.Show("Please Enter User ID.", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                command.ExecuteNonQuery();
                displayUsers();
            }
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to insert a new user manually.
        /// </summary>
        public void addUser()
        {
            // add a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`user_name`, `user_lname`, `user_fname`, `user_email`, `user_occupation`, `user_gender`, `user_birthdate`, `user_password`, `user_address`) VALUES (@username, @lname, @fname, @email, @occupation, @gender, @birthdate, @password, @address)", db.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailtxtBox.Text;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = FnametxtBox.Text;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = LnametxtBox.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernametxtBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordtxtBox.Text;
            command.Parameters.Add("@birthdate", MySqlDbType.VarChar).Value = BirthdatetxtBox.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = GendertxtBox.Text;
            command.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = OccupationtxtBox.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = AddresstxtBox.Text;

            // open the connection
            db.openConnection();

            if (!checkTextBoxesValues())
            {
                // check if this username already exists
                if (checkUsername())
                {
                    MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Has Been Added", "Account Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayUsers();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Your Information First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // close the connection
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to display all users. Can be called during
        /// Form load.
        /// </summary>
        public void displayManagers()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT manager_id, manager_username FROM `manager`", db.getConnection());
            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "manager");
            managerDataGrid.DataSource = ds.Tables["manager"].DefaultView;
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to add a new manager to the system.
        /// </summary>
        public void createManagers()
        {
            // add a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `manager`(`manager_username`, `manager_password`) VALUES (@username, @password)", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = managerUserTxtBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = managerPassTxtBox.Text;


            // open the connection
            db.openConnection();

            if (!checkManagerTextBoxesValues())
            {
                // check if this username already exists
                if (checkManager())
                {
                    MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        displayManagers();
                        MessageBox.Show("Account Has Been Added", "Account Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Your Information First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // close the connection
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to remove a registered manager to the system.
        /// </summary>
        public void deleteManager()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `manager` WHERE manager_id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = managerIDTxtBox.Text;

            db.openConnection();

            if (managerIDTxtBox.Text == "")
            {
                MessageBox.Show("Please Enter Manager ID.", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                command.ExecuteNonQuery();
                displayManagers();
            }
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the cuurent manager wants to
        /// delete a topic created by a registered user.
        /// </summary>
        public void deleteTopic()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `topic` WHERE topic_id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = TopicIdTextBox.Text;

            db.openConnection();

            if (TopicIdTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Topic ID.", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                displayTopics();
                command.ExecuteNonQuery(); 
            }
            db.closeConnection();
        }

        /// <summary>
        /// This method is called when the values
        /// inside the textboxes are default which
        /// return to either TRUE or FALSE.
        /// </summary>
        /// <returns></returns>
        public Boolean checkTextBoxesValues()
        {
            String fname = FnametxtBox.Text;
            String lname = LnametxtBox.Text;
            String email = EmailtxtBox.Text;
            String uname = UsernametxtBox.Text;
            String pass = PasswordtxtBox.Text;

            if (fname.Equals("") || lname.Equals("") ||
                email.Equals("") || uname.Equals("")
                || pass.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// This method is called when checking
        /// if the user values contains duplicates of the 
        /// inputted value in the database.
        /// </summary>
        /// <returns></returns>
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = UsernametxtBox.Text;

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

        /// <summary>
        /// This method is called when the current manager
        /// wants to check if the manager added already exists.
        /// </summary>
        /// <returns></returns>
        public Boolean checkManager()
        {
            DB db = new DB();

            String username = managerUserTxtBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `manager` WHERE `manager_username` = @user", db.getConnection());

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

        /// <summary>
        /// This method checks the values of the checkboxes.
        /// </summary>
        /// <returns></returns>
        public Boolean checkManagerTextBoxesValues()
        {
            String username = managerUserTxtBox.Text;
            String password = managerPassTxtBox.Text;

            if (username.Equals("") || password.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to display all current users registered
        /// to the database.
        /// </summary>
        public void displayUsers()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // IMPORTANT! -> Add user_address in MySQL Database and here...
            MySqlCommand command = new MySqlCommand("SELECT uid, user_name, user_fname, user_lname, user_email, user_occupation, user_gender, user_birthdate, user_address FROM `user`", db.getConnection());

            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "user");
            userDataGrid.DataSource = ds.Tables["user"].DefaultView;
        }

        /// <summary>
        /// This method is called when the current manager
        /// wants to display all topics.
        /// </summary>
        public void displayTopics()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT topic_id, topic_title, topic_desc, topic_type, topic_date, user_name, category_type FROM `topic`", db.getConnection());
            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "topic");
            topicDataGrid.DataSource = ds.Tables["topic"].DefaultView;
        }

        /// <summary>
        /// This method is called when the current manager wants to display all
        /// files uploaded by registered users.
        /// </summary>
        public void displayFiles()
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT file_id, file_name, file_type, file_date, user_name, topic_type, category_type FROM `file`", db.getConnection());
            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "file");
            FileDataGrid.DataSource = ds.Tables["file"].DefaultView;
        }

        
    }
}
