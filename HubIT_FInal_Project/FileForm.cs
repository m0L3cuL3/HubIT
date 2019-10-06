using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This Class contains all methods related
    /// To File Handling. This is also the File Window.
    /// </summary>
    public partial class FileForm : Form
    {
        MySqlCommand command;
        MySqlDataReader reader;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FileForm()
        {
            InitializeComponent();
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            Globals g = new Globals();

            // this displays all available programming languages.
            for (int i = 0; i < g.programming_category.Length; i++)
            {
                LanguageFilterBox.Items.Add(g.programming_category[i]);
                LanguageFilterUploadBox.Items.Add(g.programming_category[i]);
            }

            // this displays all available file extensions.
            for (int i = 0; i < g.extension_category.Length; i++)
            {
                filetypeCombobox.Items.Add(g.extension_category[i]);
            }

            // this displays all available topics.
            for (int i = 0; i < g.topic_category.Length; i++)
            {
                TopicFilterBox.Items.Add(g.topic_category[i]);
                TopicFilterUploadBox.Items.Add(g.topic_category[i]);
            }

            // this displays all available file extensions.
            for (int i = 0; i < g.extension_category.Length; i++)
            {
                FilterFileTypeBox.Items.Add(g.extension_category[i]);
            }

            displayFiles();
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Files (*.txt; *.pdf; *.java; *.py; *.cpp; *.c)|*.txt; *.pdf; *.java; *.py; *.cpp; *.c|All files (*.*)|*.*", ValidateNames = true, RestoreDirectory = true, FilterIndex = 2 })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to upload this file?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string filename = dlg.FileName;
                        UploadFile(filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            if (verifyFileUpload())
            {
                UploadFileBtn.Enabled = true;
            }
            else
            {
                UploadFileBtn.Enabled = false;
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if(fileList.SelectedItem == null)
            {
                MessageBox.Show("Please select a file to download", "Select File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Files (*.txt; *.pdf; *.doc; *.docx; *.java; *.py; *.cpp; *.c)|*.txt; *.pdf; *.doc; *.docx; *.java; *.py; *.cpp; *.c|All files (*.*)|*.*", ValidateNames = true, RestoreDirectory = true, FilterIndex = 2 })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to download this file?", "Download File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            string filename = sfd.FileName;
                            DownloadFile(filename);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }          
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilterTopicBtn_Click(object sender, EventArgs e)
        {
            filterTopic();
        }

        private void FilterLanguageBtn_Click(object sender, EventArgs e)
        {
            filterLanguage();
        }

        private void CheckFileInfoBtn_Click(object sender, EventArgs e)
        {
            checkFileInfo();
        }

        private void FilterFileTypeBtn_Click(object sender, EventArgs e)
        {
            filterFileType();
        }

        /// <summary>
        /// This method is called when the current user
        /// wants to upload a file to the system.
        /// </summary>
        /// <param name="file">Parameter for file</param>
        public void UploadFile(string file)
        {
            DB db = new DB();
            
            FileStream fstream = File.OpenRead(file);
            byte[] contents = new byte[fstream.Length];
            fstream.Read(contents, 0, (int)fstream.Length);
            fstream.Close();

            using(command = new MySqlCommand("INSERT INTO file (file_name, file_type, file_data, file_date, user_name, topic_type, category_type) values (@filename, @filetype, @filedata, now(), @user, @topictype, @categorytype)", db.getConnection()))
            {
                command.Parameters.AddWithValue("@filename", filenameTxtBox.Text);
                command.Parameters.AddWithValue("@filetype", filetypeCombobox.SelectedItem);
                command.Parameters.AddWithValue("@filedata", contents);
                command.Parameters.AddWithValue("@user", FileUsertxtBox.Text);
                command.Parameters.AddWithValue("@topictype", TopicFilterUploadBox.SelectedItem);
                command.Parameters.AddWithValue("@categorytype", LanguageFilterUploadBox.SelectedItem);

                db.openConnection();

                command.ExecuteNonQuery();

                db.closeConnection();
            }
            MessageBox.Show("File Uploaded!", "File Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This method is called when verifying
        /// the credentials of the user when uploading a file.
        /// </summary>
        /// <returns>Returns true if account is verified</returns>
        public Boolean verifyFileUpload()
        {
            DB db = new DB();

            String username = FileUsertxtBox.Text;
            String password = FilePasstxtBox.Text;

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
                verifyLabel.ForeColor = Color.Lime;
                verifyLabel.Text = "Success!";
                return true;
            }
            else
            {
                verifyLabel.ForeColor = Color.Red;
                verifyLabel.Text = "Failed!";
                return false;
            }
        }

        /// <summary>
        /// This method is called when display all
        /// files uploaded by a registered user.
        /// </summary>
        public void displayFiles()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT file_name, file_date, file_type, user_name, topic_type, category_type FROM file", db.getConnection());
            

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                string filename = reader.GetString("file_name");
                string item = string.Format("{0}", filename);

                fileList.Items.Add(item);
            }
        }

        /// <summary>
        /// This method is called when the current user wants to
        /// check the selected file from the listbox for information.
        /// </summary>
        public void checkFileInfo()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT file_date, file_type, user_name, topic_type, category_type FROM file WHERE file_name = @filename", db.getConnection());
            command.Parameters.Add("@filename", MySqlDbType.VarChar).Value = fileList.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string fileUploader = reader.GetString("user_name");
                string dateUploaded = reader.GetString("file_date");
                string fileType = reader.GetString("file_type");
                string topicType = reader.GetString("topic_type");
                string categoryType = reader.GetString("category_type");

                DateInfo.Visible = true;
                FileUploadInfo.Visible = true;
                FileTypeInfo.Visible = true;
                TopicTypeInfo.Visible = true;
                LanguageTypeInfo.Visible = true;

                DateInfo.ForeColor = Color.Lime;
                FileUploadInfo.ForeColor = Color.Lime;
                FileTypeInfo.ForeColor = Color.Lime;
                TopicTypeInfo.ForeColor = Color.Lime;
                LanguageTypeInfo.ForeColor = Color.Lime;

                DateInfo.Text = dateUploaded;
                FileUploadInfo.Text = fileUploader;
                FileTypeInfo.Text = fileType;
                TopicTypeInfo.Text = topicType;
                LanguageTypeInfo.Text = categoryType;
            }
        }

        /// <summary>
        /// This method is called when the current user
        /// wants to download a file from the system.
        /// </summary>
        /// <param name="file">Parameter for filepath.</param>
        public void DownloadFile(string file)
        {
            DB db = new DB();
            bool em = false;
            using (command = new MySqlCommand("SELECT file_data FROM file WHERE file_name = @filename",db.getConnection()))
            {
                command.Parameters.AddWithValue("@filename", fileList.SelectedItem);

                db.openConnection();

                using (reader = command.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] fileData = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(fileData);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("File Downloaded", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (em == false)
                    {
                        MessageBox.Show("File does not exist!", "No File in Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
            }
        }
        
        /// <summary>
        /// This method is called when the current user
        /// wants to filter the files by programming languages.
        /// </summary>
        public void filterLanguage()
        {
            fileList.Items.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT file_name, file_date, file_type, user_name, topic_type, category_type FROM file WHERE category_type = @type", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = LanguageFilterBox.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            // programming language category
            if (LanguageFilterBox.SelectedItem == "Java")
            {

                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (LanguageFilterBox.SelectedItem == "Python")
            {

                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (LanguageFilterBox.SelectedItem == "C++")
            {

                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (LanguageFilterBox.SelectedItem == "C#")
            {

                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// This method is called when the current user wants
        /// to filter all topic by topic.
        /// </summary>
        public void filterTopic()
        {
            fileList.Items.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT file_name, file_date, file_type, user_name, topic_type, category_type FROM file WHERE topic_type = @type", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = TopicFilterBox.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            // topic category
            if (TopicFilterBox.SelectedItem == "Inheritance")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (TopicFilterBox.SelectedItem == "Abstraction")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (TopicFilterBox.SelectedItem == "If-Else statements")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (TopicFilterBox.SelectedItem == "Loops")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (TopicFilterBox.SelectedItem == "Arrays")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            else if (TopicFilterBox.SelectedItem == "Declaring variables")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// This method is called when the current user
        /// wants to filter files by file type/extension.
        /// </summary>
        public void filterFileType()
        {
            fileList.Items.Clear();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT file_name, file_date, file_type, user_name, topic_type, category_type FROM file WHERE file_type = @type", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = FilterFileTypeBox.SelectedItem;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            // topic category
            if (FilterFileTypeBox.SelectedItem == ".doc")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".docx")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".txt")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".pdf")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".java")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".py")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".cpp")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
            if (FilterFileTypeBox.SelectedItem == ".c")
            {
                while (reader.Read())
                {
                    string filename = reader.GetString("file_name");
                    string item = string.Format("{0}", filename);

                    fileList.Items.Add(item);
                }
            }
        }
    }
}
