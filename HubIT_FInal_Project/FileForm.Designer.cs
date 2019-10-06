namespace HubIT_FInal_Project
{
    partial class FileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBar = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterLanguageBtn = new System.Windows.Forms.Button();
            this.LanguageFilterBox = new System.Windows.Forms.ComboBox();
            this.FilterTopicBtn = new System.Windows.Forms.Button();
            this.TopicFilterBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckFileInfoBtn = new System.Windows.Forms.Button();
            this.LanguageTypeInfo = new System.Windows.Forms.Label();
            this.TopicTypeInfo = new System.Windows.Forms.Label();
            this.FileTypeInfo = new System.Windows.Forms.Label();
            this.FileUploadInfo = new System.Windows.Forms.Label();
            this.DateInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.FilePasstxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FileUsertxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TopicFilterUploadBox = new System.Windows.Forms.ComboBox();
            this.LanguageFilterUploadBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.filenameTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UploadFileBtn = new System.Windows.Forms.Button();
            this.filetypeCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FilterFileTypeBtn = new System.Windows.Forms.Button();
            this.FilterFileTypeBox = new System.Windows.Forms.ComboBox();
            this.titleBar.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.titleBar.Controls.Add(this.closeLabel);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(814, 22);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(796, 4);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(14, 13);
            this.closeLabel.TabIndex = 13;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(17, 33);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(273, 303);
            this.fileList.TabIndex = 1;
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.label15);
            this.filterGroup.Controls.Add(this.FilterFileTypeBtn);
            this.filterGroup.Controls.Add(this.FilterFileTypeBox);
            this.filterGroup.Controls.Add(this.label2);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Controls.Add(this.FilterLanguageBtn);
            this.filterGroup.Controls.Add(this.LanguageFilterBox);
            this.filterGroup.Controls.Add(this.FilterTopicBtn);
            this.filterGroup.Controls.Add(this.TopicFilterBox);
            this.filterGroup.ForeColor = System.Drawing.Color.White;
            this.filterGroup.Location = new System.Drawing.Point(15, 32);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(233, 267);
            this.filterGroup.TabIndex = 3;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filter System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programming Languages:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Topics:";
            // 
            // FilterLanguageBtn
            // 
            this.FilterLanguageBtn.ForeColor = System.Drawing.Color.Black;
            this.FilterLanguageBtn.Location = new System.Drawing.Point(6, 144);
            this.FilterLanguageBtn.Name = "FilterLanguageBtn";
            this.FilterLanguageBtn.Size = new System.Drawing.Size(221, 23);
            this.FilterLanguageBtn.TabIndex = 3;
            this.FilterLanguageBtn.Text = "Filter Language";
            this.FilterLanguageBtn.UseVisualStyleBackColor = true;
            this.FilterLanguageBtn.Click += new System.EventHandler(this.FilterLanguageBtn_Click);
            // 
            // LanguageFilterBox
            // 
            this.LanguageFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageFilterBox.FormattingEnabled = true;
            this.LanguageFilterBox.Location = new System.Drawing.Point(6, 117);
            this.LanguageFilterBox.Name = "LanguageFilterBox";
            this.LanguageFilterBox.Size = new System.Drawing.Size(221, 21);
            this.LanguageFilterBox.TabIndex = 2;
            // 
            // FilterTopicBtn
            // 
            this.FilterTopicBtn.ForeColor = System.Drawing.Color.Black;
            this.FilterTopicBtn.Location = new System.Drawing.Point(6, 63);
            this.FilterTopicBtn.Name = "FilterTopicBtn";
            this.FilterTopicBtn.Size = new System.Drawing.Size(221, 23);
            this.FilterTopicBtn.TabIndex = 1;
            this.FilterTopicBtn.Text = "Filter Topic";
            this.FilterTopicBtn.UseVisualStyleBackColor = true;
            this.FilterTopicBtn.Click += new System.EventHandler(this.FilterTopicBtn_Click);
            // 
            // TopicFilterBox
            // 
            this.TopicFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterBox.FormattingEnabled = true;
            this.TopicFilterBox.Location = new System.Drawing.Point(6, 36);
            this.TopicFilterBox.Name = "TopicFilterBox";
            this.TopicFilterBox.Size = new System.Drawing.Size(221, 21);
            this.TopicFilterBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(261, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 418);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DownloadBtn);
            this.tabPage1.Controls.Add(this.fileList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckFileInfoBtn);
            this.groupBox3.Controls.Add(this.LanguageTypeInfo);
            this.groupBox3.Controls.Add(this.TopicTypeInfo);
            this.groupBox3.Controls.Add(this.FileTypeInfo);
            this.groupBox3.Controls.Add(this.FileUploadInfo);
            this.groupBox3.Controls.Add(this.DateInfo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(296, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 190);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Information:";
            // 
            // CheckFileInfoBtn
            // 
            this.CheckFileInfoBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckFileInfoBtn.Location = new System.Drawing.Point(12, 159);
            this.CheckFileInfoBtn.Name = "CheckFileInfoBtn";
            this.CheckFileInfoBtn.Size = new System.Drawing.Size(219, 23);
            this.CheckFileInfoBtn.TabIndex = 13;
            this.CheckFileInfoBtn.Text = "CHECK FILE INFO";
            this.CheckFileInfoBtn.UseVisualStyleBackColor = true;
            this.CheckFileInfoBtn.Click += new System.EventHandler(this.CheckFileInfoBtn_Click);
            // 
            // LanguageTypeInfo
            // 
            this.LanguageTypeInfo.AutoSize = true;
            this.LanguageTypeInfo.ForeColor = System.Drawing.Color.White;
            this.LanguageTypeInfo.Location = new System.Drawing.Point(106, 129);
            this.LanguageTypeInfo.Name = "LanguageTypeInfo";
            this.LanguageTypeInfo.Size = new System.Drawing.Size(73, 13);
            this.LanguageTypeInfo.TabIndex = 16;
            this.LanguageTypeInfo.Text = "LanguageInfo";
            this.LanguageTypeInfo.Visible = false;
            // 
            // TopicTypeInfo
            // 
            this.TopicTypeInfo.AutoSize = true;
            this.TopicTypeInfo.ForeColor = System.Drawing.Color.White;
            this.TopicTypeInfo.Location = new System.Drawing.Point(106, 103);
            this.TopicTypeInfo.Name = "TopicTypeInfo";
            this.TopicTypeInfo.Size = new System.Drawing.Size(76, 13);
            this.TopicTypeInfo.TabIndex = 15;
            this.TopicTypeInfo.Text = "TopicTypeInfo";
            this.TopicTypeInfo.Visible = false;
            // 
            // FileTypeInfo
            // 
            this.FileTypeInfo.AutoSize = true;
            this.FileTypeInfo.ForeColor = System.Drawing.Color.White;
            this.FileTypeInfo.Location = new System.Drawing.Point(106, 77);
            this.FileTypeInfo.Name = "FileTypeInfo";
            this.FileTypeInfo.Size = new System.Drawing.Size(65, 13);
            this.FileTypeInfo.TabIndex = 14;
            this.FileTypeInfo.Text = "FileTypeInfo";
            this.FileTypeInfo.Visible = false;
            // 
            // FileUploadInfo
            // 
            this.FileUploadInfo.AutoSize = true;
            this.FileUploadInfo.ForeColor = System.Drawing.Color.White;
            this.FileUploadInfo.Location = new System.Drawing.Point(106, 50);
            this.FileUploadInfo.Name = "FileUploadInfo";
            this.FileUploadInfo.Size = new System.Drawing.Size(75, 13);
            this.FileUploadInfo.TabIndex = 13;
            this.FileUploadInfo.Text = "FileUploadInfo";
            this.FileUploadInfo.Visible = false;
            // 
            // DateInfo
            // 
            this.DateInfo.AutoSize = true;
            this.DateInfo.ForeColor = System.Drawing.Color.White;
            this.DateInfo.Location = new System.Drawing.Point(106, 25);
            this.DateInfo.Name = "DateInfo";
            this.DateInfo.Size = new System.Drawing.Size(48, 13);
            this.DateInfo.TabIndex = 12;
            this.DateInfo.Text = "DateInfo";
            this.DateInfo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Uploader:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Uploaded:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Topic Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(9, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Language Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "File Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filename:";
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.ForeColor = System.Drawing.Color.Black;
            this.DownloadBtn.Location = new System.Drawing.Point(17, 350);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(510, 23);
            this.DownloadBtn.TabIndex = 6;
            this.DownloadBtn.Text = "DOWNLOAD FILE";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VerifyBtn);
            this.groupBox2.Controls.Add(this.verifyLabel);
            this.groupBox2.Controls.Add(this.FilePasstxtBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.FileUsertxtBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(265, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 165);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Verification: ";
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.ForeColor = System.Drawing.Color.Black;
            this.VerifyBtn.Location = new System.Drawing.Point(37, 89);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(205, 23);
            this.VerifyBtn.TabIndex = 13;
            this.VerifyBtn.Text = "Verify Account";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.ForeColor = System.Drawing.Color.White;
            this.verifyLabel.Location = new System.Drawing.Point(81, 142);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(118, 13);
            this.verifyLabel.TabIndex = 17;
            this.verifyLabel.Text = "waiting for verification...";
            // 
            // FilePasstxtBox
            // 
            this.FilePasstxtBox.Location = new System.Drawing.Point(98, 56);
            this.FilePasstxtBox.Name = "FilePasstxtBox";
            this.FilePasstxtBox.Size = new System.Drawing.Size(144, 20);
            this.FilePasstxtBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password:";
            // 
            // FileUsertxtBox
            // 
            this.FileUsertxtBox.Location = new System.Drawing.Point(98, 30);
            this.FileUsertxtBox.Name = "FileUsertxtBox";
            this.FileUsertxtBox.Size = new System.Drawing.Size(144, 20);
            this.FileUsertxtBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TopicFilterUploadBox);
            this.groupBox1.Controls.Add(this.LanguageFilterUploadBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.filenameTxtBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UploadFileBtn);
            this.groupBox1.Controls.Add(this.filetypeCombobox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 297);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Upload Settings:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Programming Languages:";
            // 
            // TopicFilterUploadBox
            // 
            this.TopicFilterUploadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterUploadBox.FormattingEnabled = true;
            this.TopicFilterUploadBox.Location = new System.Drawing.Point(16, 139);
            this.TopicFilterUploadBox.Name = "TopicFilterUploadBox";
            this.TopicFilterUploadBox.Size = new System.Drawing.Size(218, 21);
            this.TopicFilterUploadBox.TabIndex = 13;
            // 
            // LanguageFilterUploadBox
            // 
            this.LanguageFilterUploadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageFilterUploadBox.FormattingEnabled = true;
            this.LanguageFilterUploadBox.Location = new System.Drawing.Point(16, 195);
            this.LanguageFilterUploadBox.Name = "LanguageFilterUploadBox";
            this.LanguageFilterUploadBox.Size = new System.Drawing.Size(218, 21);
            this.LanguageFilterUploadBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Topic Type:";
            // 
            // filenameTxtBox
            // 
            this.filenameTxtBox.Location = new System.Drawing.Point(16, 34);
            this.filenameTxtBox.Name = "filenameTxtBox";
            this.filenameTxtBox.Size = new System.Drawing.Size(218, 20);
            this.filenameTxtBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Filename:";
            // 
            // UploadFileBtn
            // 
            this.UploadFileBtn.Enabled = false;
            this.UploadFileBtn.ForeColor = System.Drawing.Color.Black;
            this.UploadFileBtn.Location = new System.Drawing.Point(16, 244);
            this.UploadFileBtn.Name = "UploadFileBtn";
            this.UploadFileBtn.Size = new System.Drawing.Size(218, 31);
            this.UploadFileBtn.TabIndex = 11;
            this.UploadFileBtn.Text = "UPLOAD FILE";
            this.UploadFileBtn.UseVisualStyleBackColor = true;
            this.UploadFileBtn.Click += new System.EventHandler(this.UploadFileBtn_Click);
            // 
            // filetypeCombobox
            // 
            this.filetypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filetypeCombobox.FormattingEnabled = true;
            this.filetypeCombobox.Location = new System.Drawing.Point(16, 85);
            this.filetypeCombobox.Name = "filetypeCombobox";
            this.filetypeCombobox.Size = new System.Drawing.Size(218, 21);
            this.filetypeCombobox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "File Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "File Type:";
            // 
            // FilterFileTypeBtn
            // 
            this.FilterFileTypeBtn.ForeColor = System.Drawing.Color.Black;
            this.FilterFileTypeBtn.Location = new System.Drawing.Point(6, 223);
            this.FilterFileTypeBtn.Name = "FilterFileTypeBtn";
            this.FilterFileTypeBtn.Size = new System.Drawing.Size(221, 23);
            this.FilterFileTypeBtn.TabIndex = 7;
            this.FilterFileTypeBtn.Text = "Filter File type";
            this.FilterFileTypeBtn.UseVisualStyleBackColor = true;
            this.FilterFileTypeBtn.Click += new System.EventHandler(this.FilterFileTypeBtn_Click);
            // 
            // FilterFileTypeBox
            // 
            this.FilterFileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterFileTypeBox.FormattingEnabled = true;
            this.FilterFileTypeBox.Location = new System.Drawing.Point(6, 196);
            this.FilterFileTypeBox.Name = "FilterFileTypeBox";
            this.FilterFileTypeBox.Size = new System.Drawing.Size(221, 21);
            this.FilterFileTypeBox.TabIndex = 6;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(814, 440);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.Load += new System.EventHandler(this.FileForm_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Button FilterTopicBtn;
        private System.Windows.Forms.ComboBox TopicFilterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterLanguageBtn;
        private System.Windows.Forms.ComboBox LanguageFilterBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button UploadFileBtn;
        private System.Windows.Forms.TextBox filenameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filetypeCombobox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FilePasstxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FileUsertxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.Button VerifyBtn;
        private System.Windows.Forms.ComboBox TopicFilterUploadBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox LanguageFilterUploadBox;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LanguageTypeInfo;
        private System.Windows.Forms.Label TopicTypeInfo;
        private System.Windows.Forms.Label FileTypeInfo;
        private System.Windows.Forms.Label FileUploadInfo;
        private System.Windows.Forms.Label DateInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CheckFileInfoBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button FilterFileTypeBtn;
        private System.Windows.Forms.ComboBox FilterFileTypeBox;
    }
}