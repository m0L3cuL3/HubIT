namespace HubIT_FInal_Project
{
    partial class ManagerForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.managerDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManagerCreateBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.managerUserTxtBox = new System.Windows.Forms.TextBox();
            this.managerPassTxtBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddresstxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.insertUserBtn = new System.Windows.Forms.Button();
            this.UsernametxtBox = new System.Windows.Forms.TextBox();
            this.PasswordtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthdatetxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GendertxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OccupationtxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LnametxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FnametxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.DeleteUidtxtBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.topicDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FileDataGrid = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ManagerDeleteBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.managerIDTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TopicIdTextBox = new System.Windows.Forms.TextBox();
            this.TopicDeleteBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteFileIdBtn = new System.Windows.Forms.Button();
            this.DeleteFileIdTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.titlePanel.Controls.Add(this.labelClose);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(948, 27);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(929, 5);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(16, 16);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // managerDataGrid
            // 
            this.managerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.managerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.managerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.managerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.managerDataGrid.Location = new System.Drawing.Point(3, 3);
            this.managerDataGrid.Name = "managerDataGrid";
            this.managerDataGrid.ReadOnly = true;
            this.managerDataGrid.Size = new System.Drawing.Size(738, 283);
            this.managerDataGrid.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(196, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.managerDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Managers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManagerCreateBtn);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.managerUserTxtBox);
            this.groupBox3.Controls.Add(this.managerPassTxtBox);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 186);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manager Creation:";
            // 
            // ManagerCreateBtn
            // 
            this.ManagerCreateBtn.ForeColor = System.Drawing.Color.Black;
            this.ManagerCreateBtn.Location = new System.Drawing.Point(29, 118);
            this.ManagerCreateBtn.Name = "ManagerCreateBtn";
            this.ManagerCreateBtn.Size = new System.Drawing.Size(293, 42);
            this.ManagerCreateBtn.TabIndex = 6;
            this.ManagerCreateBtn.Text = "CREATE";
            this.ManagerCreateBtn.UseVisualStyleBackColor = true;
            this.ManagerCreateBtn.Click += new System.EventHandler(this.ManagerCreateBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(24, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Manager Username:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(26, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Manager Password:";
            // 
            // managerUserTxtBox
            // 
            this.managerUserTxtBox.Location = new System.Drawing.Point(133, 42);
            this.managerUserTxtBox.Name = "managerUserTxtBox";
            this.managerUserTxtBox.Size = new System.Drawing.Size(189, 20);
            this.managerUserTxtBox.TabIndex = 2;
            // 
            // managerPassTxtBox
            // 
            this.managerPassTxtBox.Location = new System.Drawing.Point(133, 68);
            this.managerPassTxtBox.Name = "managerPassTxtBox";
            this.managerPassTxtBox.Size = new System.Drawing.Size(189, 20);
            this.managerPassTxtBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.userDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(3, 286);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(738, 192);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(730, 166);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "INSERT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddresstxtBox);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.insertUserBtn);
            this.groupBox1.Controls.Add(this.UsernametxtBox);
            this.groupBox1.Controls.Add(this.PasswordtxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BirthdatetxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GendertxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OccupationtxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmailtxtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LnametxtBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FnametxtBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 154);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert User Information:";
            // 
            // AddresstxtBox
            // 
            this.AddresstxtBox.Location = new System.Drawing.Point(548, 48);
            this.AddresstxtBox.Name = "AddresstxtBox";
            this.AddresstxtBox.Size = new System.Drawing.Size(149, 20);
            this.AddresstxtBox.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(493, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Address:";
            // 
            // insertUserBtn
            // 
            this.insertUserBtn.ForeColor = System.Drawing.Color.Black;
            this.insertUserBtn.Location = new System.Drawing.Point(12, 119);
            this.insertUserBtn.Name = "insertUserBtn";
            this.insertUserBtn.Size = new System.Drawing.Size(700, 25);
            this.insertUserBtn.TabIndex = 18;
            this.insertUserBtn.Text = "INSERT USER";
            this.insertUserBtn.UseVisualStyleBackColor = true;
            this.insertUserBtn.Click += new System.EventHandler(this.insertUserBtn_Click);
            // 
            // UsernametxtBox
            // 
            this.UsernametxtBox.Location = new System.Drawing.Point(73, 22);
            this.UsernametxtBox.Name = "UsernametxtBox";
            this.UsernametxtBox.Size = new System.Drawing.Size(149, 20);
            this.UsernametxtBox.TabIndex = 10;
            // 
            // PasswordtxtBox
            // 
            this.PasswordtxtBox.Location = new System.Drawing.Point(73, 48);
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.Size = new System.Drawing.Size(149, 20);
            this.PasswordtxtBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // BirthdatetxtBox
            // 
            this.BirthdatetxtBox.Location = new System.Drawing.Point(312, 74);
            this.BirthdatetxtBox.Name = "BirthdatetxtBox";
            this.BirthdatetxtBox.Size = new System.Drawing.Size(149, 20);
            this.BirthdatetxtBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // GendertxtBox
            // 
            this.GendertxtBox.Location = new System.Drawing.Point(548, 74);
            this.GendertxtBox.Name = "GendertxtBox";
            this.GendertxtBox.Size = new System.Drawing.Size(149, 20);
            this.GendertxtBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // OccupationtxtBox
            // 
            this.OccupationtxtBox.Location = new System.Drawing.Point(548, 22);
            this.OccupationtxtBox.Name = "OccupationtxtBox";
            this.OccupationtxtBox.Size = new System.Drawing.Size(149, 20);
            this.OccupationtxtBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // EmailtxtBox
            // 
            this.EmailtxtBox.Location = new System.Drawing.Point(73, 74);
            this.EmailtxtBox.Name = "EmailtxtBox";
            this.EmailtxtBox.Size = new System.Drawing.Size(149, 20);
            this.EmailtxtBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(477, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Occupation:";
            // 
            // LnametxtBox
            // 
            this.LnametxtBox.Location = new System.Drawing.Point(312, 48);
            this.LnametxtBox.Name = "LnametxtBox";
            this.LnametxtBox.Size = new System.Drawing.Size(149, 20);
            this.LnametxtBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(493, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender:";
            // 
            // FnametxtBox
            // 
            this.FnametxtBox.Location = new System.Drawing.Point(312, 22);
            this.FnametxtBox.Name = "FnametxtBox";
            this.FnametxtBox.Size = new System.Drawing.Size(149, 20);
            this.FnametxtBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Birthdate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password:";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabPage7.Controls.Add(this.deleteBtn);
            this.tabPage7.Controls.Add(this.DeleteUidtxtBox);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(730, 166);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "DELETE";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(302, 60);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(149, 27);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DeleteUidtxtBox
            // 
            this.DeleteUidtxtBox.Location = new System.Drawing.Point(302, 34);
            this.DeleteUidtxtBox.Name = "DeleteUidtxtBox";
            this.DeleteUidtxtBox.Size = new System.Drawing.Size(149, 20);
            this.DeleteUidtxtBox.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(251, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "User ID:";
            // 
            // userDataGrid
            // 
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.userDataGrid.Location = new System.Drawing.Point(3, 3);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.Size = new System.Drawing.Size(738, 283);
            this.userDataGrid.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Controls.Add(this.topicDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Topics";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 286);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(738, 197);
            this.tabControl3.TabIndex = 4;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage8.Controls.Add(this.TopicDeleteBtn);
            this.tabPage8.Controls.Add(this.TopicIdTextBox);
            this.tabPage8.Controls.Add(this.label9);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(730, 171);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "DELETE";
            // 
            // topicDataGrid
            // 
            this.topicDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topicDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.topicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topicDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.topicDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.topicDataGrid.Location = new System.Drawing.Point(3, 3);
            this.topicDataGrid.Name = "topicDataGrid";
            this.topicDataGrid.ReadOnly = true;
            this.topicDataGrid.Size = new System.Drawing.Size(738, 283);
            this.topicDataGrid.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.FileDataGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(744, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Files";
            // 
            // FileDataGrid
            // 
            this.FileDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.FileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.FileDataGrid.Location = new System.Drawing.Point(3, 3);
            this.FileDataGrid.Name = "FileDataGrid";
            this.FileDataGrid.ReadOnly = true;
            this.FileDataGrid.Size = new System.Drawing.Size(738, 283);
            this.FileDataGrid.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(34, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 23);
            this.label19.TabIndex = 3;
            this.label19.Text = "Dashboard";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ManagerDeleteBtn);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.managerIDTxtBox);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(383, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 186);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manager Deletion:";
            // 
            // ManagerDeleteBtn
            // 
            this.ManagerDeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.ManagerDeleteBtn.Location = new System.Drawing.Point(29, 118);
            this.ManagerDeleteBtn.Name = "ManagerDeleteBtn";
            this.ManagerDeleteBtn.Size = new System.Drawing.Size(293, 42);
            this.ManagerDeleteBtn.TabIndex = 6;
            this.ManagerDeleteBtn.Text = "DELETE";
            this.ManagerDeleteBtn.UseVisualStyleBackColor = true;
            this.ManagerDeleteBtn.Click += new System.EventHandler(this.ManagerDeleteBtn_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(61, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Manager ID:";
            // 
            // managerIDTxtBox
            // 
            this.managerIDTxtBox.Location = new System.Drawing.Point(133, 55);
            this.managerIDTxtBox.Name = "managerIDTxtBox";
            this.managerIDTxtBox.Size = new System.Drawing.Size(189, 20);
            this.managerIDTxtBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(239, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Topic ID:";
            // 
            // TopicIdTextBox
            // 
            this.TopicIdTextBox.Location = new System.Drawing.Point(296, 52);
            this.TopicIdTextBox.Name = "TopicIdTextBox";
            this.TopicIdTextBox.Size = new System.Drawing.Size(177, 20);
            this.TopicIdTextBox.TabIndex = 1;
            // 
            // TopicDeleteBtn
            // 
            this.TopicDeleteBtn.Location = new System.Drawing.Point(296, 78);
            this.TopicDeleteBtn.Name = "TopicDeleteBtn";
            this.TopicDeleteBtn.Size = new System.Drawing.Size(177, 23);
            this.TopicDeleteBtn.TabIndex = 2;
            this.TopicDeleteBtn.Text = "DELETE";
            this.TopicDeleteBtn.UseVisualStyleBackColor = true;
            this.TopicDeleteBtn.Click += new System.EventHandler(this.TopicDeleteBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.LogoutBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.Logout_Button;
            this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 513);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(196, 26);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteFileIdBtn);
            this.groupBox2.Controls.Add(this.DeleteFileIdTxtBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Deletion:";
            // 
            // DeleteFileIdBtn
            // 
            this.DeleteFileIdBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteFileIdBtn.Location = new System.Drawing.Point(98, 92);
            this.DeleteFileIdBtn.Name = "DeleteFileIdBtn";
            this.DeleteFileIdBtn.Size = new System.Drawing.Size(177, 23);
            this.DeleteFileIdBtn.TabIndex = 5;
            this.DeleteFileIdBtn.Text = "DELETE";
            this.DeleteFileIdBtn.UseVisualStyleBackColor = true;
            this.DeleteFileIdBtn.Click += new System.EventHandler(this.DeleteFileIdBtn_Click);
            // 
            // DeleteFileIdTxtBox
            // 
            this.DeleteFileIdTxtBox.Location = new System.Drawing.Point(98, 66);
            this.DeleteFileIdTxtBox.Name = "DeleteFileIdTxtBox";
            this.DeleteFileIdTxtBox.Size = new System.Drawing.Size(177, 20);
            this.DeleteFileIdTxtBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "File ID:";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(948, 539);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicDataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.DataGridView managerDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView topicDataGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView FileDataGrid;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UsernametxtBox;
        private System.Windows.Forms.TextBox PasswordtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BirthdatetxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GendertxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OccupationtxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailtxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LnametxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FnametxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox DeleteUidtxtBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button insertUserBtn;
        private System.Windows.Forms.TextBox AddresstxtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ManagerCreateBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox managerUserTxtBox;
        private System.Windows.Forms.TextBox managerPassTxtBox;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ManagerDeleteBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox managerIDTxtBox;
        private System.Windows.Forms.Button TopicDeleteBtn;
        private System.Windows.Forms.TextBox TopicIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteFileIdBtn;
        private System.Windows.Forms.TextBox DeleteFileIdTxtBox;
        private System.Windows.Forms.Label label10;
    }
}