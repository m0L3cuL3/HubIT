namespace HubIT_FInal_Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterTopicBtn = new System.Windows.Forms.Button();
            this.FilterPLBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SlideBtn = new System.Windows.Forms.Button();
            this.language_cb = new System.Windows.Forms.ComboBox();
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.FileLibraryBtn = new System.Windows.Forms.Button();
            this.GlobalTopicBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopicBtn = new System.Windows.Forms.Button();
            this.UserAccountLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.topic_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTopicBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.Closelabel = new System.Windows.Forms.Label();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuControl = new HubIT_FInal_Project.TopicControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.slidingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.FilterTopicBtn);
            this.panel1.Controls.Add(this.FilterPLBtn);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.language_cb);
            this.panel1.Controls.Add(this.slidingPanel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.topic_cb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addTopicBtn);
            this.panel1.Controls.Add(this.titlePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 454);
            this.panel1.TabIndex = 2;
            // 
            // FilterTopicBtn
            // 
            this.FilterTopicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FilterTopicBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.FilterTopicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FilterTopicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterTopicBtn.FlatAppearance.BorderSize = 0;
            this.FilterTopicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTopicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterTopicBtn.ForeColor = System.Drawing.Color.White;
            this.FilterTopicBtn.Location = new System.Drawing.Point(911, 152);
            this.FilterTopicBtn.Name = "FilterTopicBtn";
            this.FilterTopicBtn.Size = new System.Drawing.Size(152, 21);
            this.FilterTopicBtn.TabIndex = 19;
            this.FilterTopicBtn.Text = "Filter Topics";
            this.FilterTopicBtn.UseVisualStyleBackColor = false;
            this.FilterTopicBtn.Click += new System.EventHandler(this.FilterTopicBtn_Click);
            // 
            // FilterPLBtn
            // 
            this.FilterPLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FilterPLBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.FilterPLBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FilterPLBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterPLBtn.FlatAppearance.BorderSize = 0;
            this.FilterPLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterPLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterPLBtn.ForeColor = System.Drawing.Color.White;
            this.FilterPLBtn.Location = new System.Drawing.Point(911, 71);
            this.FilterPLBtn.Name = "FilterPLBtn";
            this.FilterPLBtn.Size = new System.Drawing.Size(152, 21);
            this.FilterPLBtn.TabIndex = 18;
            this.FilterPLBtn.Text = "Filter Languages";
            this.FilterPLBtn.UseVisualStyleBackColor = false;
            this.FilterPLBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(174, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 435);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SlideBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(158, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 435);
            this.panel2.TabIndex = 4;
            // 
            // SlideBtn
            // 
            this.SlideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SlideBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.Slide_button;
            this.SlideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlideBtn.FlatAppearance.BorderSize = 0;
            this.SlideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideBtn.ForeColor = System.Drawing.Color.White;
            this.SlideBtn.Location = new System.Drawing.Point(0, 0);
            this.SlideBtn.Name = "SlideBtn";
            this.SlideBtn.Size = new System.Drawing.Size(16, 435);
            this.SlideBtn.TabIndex = 3;
            this.SlideBtn.Text = ".\r\n.\r\n.";
            this.SlideBtn.UseVisualStyleBackColor = false;
            this.SlideBtn.Click += new System.EventHandler(this.SlideBtn_Click);
            // 
            // language_cb
            // 
            this.language_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language_cb.FormattingEnabled = true;
            this.language_cb.Location = new System.Drawing.Point(911, 44);
            this.language_cb.Name = "language_cb";
            this.language_cb.Size = new System.Drawing.Size(152, 21);
            this.language_cb.TabIndex = 10;
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.slidingPanel.Controls.Add(this.FileLibraryBtn);
            this.slidingPanel.Controls.Add(this.GlobalTopicBtn);
            this.slidingPanel.Controls.Add(this.pictureBox1);
            this.slidingPanel.Controls.Add(this.TopicBtn);
            this.slidingPanel.Controls.Add(this.UserAccountLabel);
            this.slidingPanel.Controls.Add(this.button5);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.Location = new System.Drawing.Point(0, 19);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(158, 435);
            this.slidingPanel.TabIndex = 0;
            // 
            // FileLibraryBtn
            // 
            this.FileLibraryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileLibraryBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.FileLibraryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileLibraryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileLibraryBtn.FlatAppearance.BorderSize = 0;
            this.FileLibraryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileLibraryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLibraryBtn.ForeColor = System.Drawing.Color.White;
            this.FileLibraryBtn.Location = new System.Drawing.Point(19, 240);
            this.FileLibraryBtn.Name = "FileLibraryBtn";
            this.FileLibraryBtn.Size = new System.Drawing.Size(124, 32);
            this.FileLibraryBtn.TabIndex = 12;
            this.FileLibraryBtn.Text = "File Library";
            this.FileLibraryBtn.UseVisualStyleBackColor = false;
            this.FileLibraryBtn.Click += new System.EventHandler(this.FileLibraryBtn_Click);
            // 
            // GlobalTopicBtn
            // 
            this.GlobalTopicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GlobalTopicBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.GlobalTopicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GlobalTopicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GlobalTopicBtn.FlatAppearance.BorderSize = 0;
            this.GlobalTopicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GlobalTopicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalTopicBtn.ForeColor = System.Drawing.Color.White;
            this.GlobalTopicBtn.Location = new System.Drawing.Point(19, 202);
            this.GlobalTopicBtn.Name = "GlobalTopicBtn";
            this.GlobalTopicBtn.Size = new System.Drawing.Size(124, 32);
            this.GlobalTopicBtn.TabIndex = 11;
            this.GlobalTopicBtn.Text = "Global Topics";
            this.GlobalTopicBtn.UseVisualStyleBackColor = false;
            this.GlobalTopicBtn.Click += new System.EventHandler(this.GlobalTopicBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HubIT_FInal_Project.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TopicBtn
            // 
            this.TopicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopicBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.TopicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopicBtn.FlatAppearance.BorderSize = 0;
            this.TopicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicBtn.ForeColor = System.Drawing.Color.White;
            this.TopicBtn.Location = new System.Drawing.Point(19, 278);
            this.TopicBtn.Name = "TopicBtn";
            this.TopicBtn.Size = new System.Drawing.Size(124, 32);
            this.TopicBtn.TabIndex = 8;
            this.TopicBtn.Text = "Own Topics";
            this.TopicBtn.UseVisualStyleBackColor = false;
            this.TopicBtn.Click += new System.EventHandler(this.TopicBtn_Click);
            // 
            // UserAccountLabel
            // 
            this.UserAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserAccountLabel.AutoSize = true;
            this.UserAccountLabel.Font = new System.Drawing.Font("Alien League Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccountLabel.ForeColor = System.Drawing.Color.White;
            this.UserAccountLabel.Location = new System.Drawing.Point(14, 150);
            this.UserAccountLabel.Name = "UserAccountLabel";
            this.UserAccountLabel.Size = new System.Drawing.Size(137, 28);
            this.UserAccountLabel.TabIndex = 5;
            this.UserAccountLabel.Text = "UserAccount";
            this.UserAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button5.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.Logout_Button;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(19, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(908, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Topic";
            // 
            // topic_cb
            // 
            this.topic_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topic_cb.FormattingEnabled = true;
            this.topic_cb.Location = new System.Drawing.Point(911, 125);
            this.topic_cb.Name = "topic_cb";
            this.topic_cb.Size = new System.Drawing.Size(152, 21);
            this.topic_cb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(908, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Programming Language";
            // 
            // addTopicBtn
            // 
            this.addTopicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.addTopicBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.addTopicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTopicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTopicBtn.FlatAppearance.BorderSize = 0;
            this.addTopicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTopicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTopicBtn.ForeColor = System.Drawing.Color.White;
            this.addTopicBtn.Location = new System.Drawing.Point(925, 405);
            this.addTopicBtn.Name = "addTopicBtn";
            this.addTopicBtn.Size = new System.Drawing.Size(124, 35);
            this.addTopicBtn.TabIndex = 9;
            this.addTopicBtn.Text = "Add Topic";
            this.addTopicBtn.UseVisualStyleBackColor = false;
            this.addTopicBtn.Click += new System.EventHandler(this.addTopicBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.titlePanel.Controls.Add(this.Closelabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1075, 19);
            this.titlePanel.TabIndex = 20;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closelabel.ForeColor = System.Drawing.Color.White;
            this.Closelabel.Location = new System.Drawing.Point(1057, 3);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(14, 13);
            this.Closelabel.TabIndex = 22;
            this.Closelabel.Text = "X";
            this.Closelabel.Click += new System.EventHandler(this.Closelabel_Click);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 5;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // mainMenuControl
            // 
            this.mainMenuControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mainMenuControl.Icon = global::HubIT_FInal_Project.Properties.Resources.user1;
            this.mainMenuControl.Location = new System.Drawing.Point(256, 8);
            this.mainMenuControl.Message = "I go to NBI, not NBI catch me to go there.";
            this.mainMenuControl.Name = "mainMenuControl";
            this.mainMenuControl.Size = new System.Drawing.Size(672, 473);
            this.mainMenuControl.TabIndex = 5;
            this.mainMenuControl.Title = "Java Programming";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 454);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.slidingPanel.ResumeLayout(false);
            this.slidingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slidingPanel;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SlideBtn;
        private System.Windows.Forms.Button button5;
        protected internal System.Windows.Forms.Label UserAccountLabel;
        private System.Windows.Forms.Button TopicBtn;
        private HubIT_FInal_Project.TopicControl mainMenuControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addTopicBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox topic_cb;
        private System.Windows.Forms.ComboBox language_cb;
        protected internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GlobalTopicBtn;
        private System.Windows.Forms.Button FilterPLBtn;
        private System.Windows.Forms.Button FilterTopicBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button FileLibraryBtn;
        private System.Windows.Forms.Label Closelabel;
    }
}