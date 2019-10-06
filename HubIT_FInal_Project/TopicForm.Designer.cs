namespace HubIT_FInal_Project
{
    partial class TopicForm
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
            this.desc_txtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LanguageTypeLabel = new System.Windows.Forms.Label();
            this.TopicTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.verifyAccTopic = new System.Windows.Forms.GroupBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.verifyAccTopic.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.titlePanel.Controls.Add(this.labelClose);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(795, 27);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(770, 2);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // desc_txtBox
            // 
            this.desc_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.desc_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desc_txtBox.ForeColor = System.Drawing.Color.White;
            this.desc_txtBox.Location = new System.Drawing.Point(12, 139);
            this.desc_txtBox.Multiline = true;
            this.desc_txtBox.Name = "desc_txtBox";
            this.desc_txtBox.Size = new System.Drawing.Size(504, 209);
            this.desc_txtBox.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.addBtn.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.button2;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(17, 101);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(223, 37);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add Topic";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alien League Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            // 
            // title_txtBox
            // 
            this.title_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.title_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txtBox.ForeColor = System.Drawing.Color.White;
            this.title_txtBox.Location = new System.Drawing.Point(12, 88);
            this.title_txtBox.Multiline = true;
            this.title_txtBox.Name = "title_txtBox";
            this.title_txtBox.Size = new System.Drawing.Size(247, 20);
            this.title_txtBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alien League Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title";
            // 
            // LanguageTypeLabel
            // 
            this.LanguageTypeLabel.AutoSize = true;
            this.LanguageTypeLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageTypeLabel.ForeColor = System.Drawing.Color.White;
            this.LanguageTypeLabel.Location = new System.Drawing.Point(142, 153);
            this.LanguageTypeLabel.Name = "LanguageTypeLabel";
            this.LanguageTypeLabel.Size = new System.Drawing.Size(81, 16);
            this.LanguageTypeLabel.TabIndex = 16;
            this.LanguageTypeLabel.Text = "LanguageType";
            // 
            // TopicTypeLabel
            // 
            this.TopicTypeLabel.AutoSize = true;
            this.TopicTypeLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicTypeLabel.ForeColor = System.Drawing.Color.White;
            this.TopicTypeLabel.Location = new System.Drawing.Point(142, 174);
            this.TopicTypeLabel.Name = "TopicTypeLabel";
            this.TopicTypeLabel.Size = new System.Drawing.Size(59, 16);
            this.TopicTypeLabel.TabIndex = 17;
            this.TopicTypeLabel.Text = "TopicType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Topic:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Language:";
            // 
            // userTxtBox
            // 
            this.userTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.userTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTxtBox.ForeColor = System.Drawing.Color.White;
            this.userTxtBox.Location = new System.Drawing.Point(93, 30);
            this.userTxtBox.Multiline = true;
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(147, 20);
            this.userTxtBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Username:";
            // 
            // verifyAccTopic
            // 
            this.verifyAccTopic.Controls.Add(this.passTxtBox);
            this.verifyAccTopic.Controls.Add(this.label2);
            this.verifyAccTopic.Controls.Add(this.label5);
            this.verifyAccTopic.Controls.Add(this.label4);
            this.verifyAccTopic.Controls.Add(this.userTxtBox);
            this.verifyAccTopic.Controls.Add(this.TopicTypeLabel);
            this.verifyAccTopic.Controls.Add(this.label6);
            this.verifyAccTopic.Controls.Add(this.LanguageTypeLabel);
            this.verifyAccTopic.Controls.Add(this.addBtn);
            this.verifyAccTopic.ForeColor = System.Drawing.Color.White;
            this.verifyAccTopic.Location = new System.Drawing.Point(522, 139);
            this.verifyAccTopic.Name = "verifyAccTopic";
            this.verifyAccTopic.Size = new System.Drawing.Size(261, 209);
            this.verifyAccTopic.TabIndex = 23;
            this.verifyAccTopic.TabStop = false;
            this.verifyAccTopic.Text = "Verification";
            // 
            // passTxtBox
            // 
            this.passTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.passTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTxtBox.ForeColor = System.Drawing.Color.White;
            this.passTxtBox.Location = new System.Drawing.Point(93, 56);
            this.passTxtBox.Multiline = true;
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(147, 20);
            this.passTxtBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password:";
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BackgroundImage = global::HubIT_FInal_Project.Properties.Resources.addTopic_Frame2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(795, 404);
            this.Controls.Add(this.verifyAccTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc_txtBox);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopicForm";
            this.Text = "addTopic_form";
            this.Load += new System.EventHandler(this.addTopic_form_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.verifyAccTopic.ResumeLayout(false);
            this.verifyAccTopic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.TextBox desc_txtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label LanguageTypeLabel;
        protected internal System.Windows.Forms.Label TopicTypeLabel;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox verifyAccTopic;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label label5;
    }
}