using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class handles the topic display of the application
    /// </summary>
    public partial class TopicControl : UserControl
    {

        /// <summary>
        /// Initializes the objects inside the constructor.
        /// </summary>
        public TopicControl()
        {
            InitializeComponent();
        }

        private void MainMenuControl_Load(object sender, EventArgs e)
        {
            
        }

        #region Properties

        private string _title;
        private string _message;
        private Image _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; textBox1.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion
    }
}
