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

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class handles category selection
    /// when the current user is uploading a file.
    /// </summary>
    public partial class CategoryForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void category_selection_Load(object sender, EventArgs e)
        {
            Globals g = new Globals();

            // programming language selection category.
            for(int i = 0; i < g.programming_category.Length; i++)
            {
                language_listbox.Items.Add(g.programming_category[i]);
            }

            // topic selection category.
            for (int i = 0; i < g.topic_category.Length; i++)
            {
                topic_listbox.Items.Add(g.topic_category[i]);
            }
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            TopicForm atf = new TopicForm();
            atf.LanguageTypeLabel.Text = language_listbox.SelectedItem.ToString();
            atf.LanguageTypeLabel.ForeColor = Color.Lime;
            atf.TopicTypeLabel.Text =  topic_listbox.SelectedItem.ToString();
            atf.TopicTypeLabel.ForeColor = Color.Lime;
            atf.Show();

            Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
