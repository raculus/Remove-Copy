using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Remove_Copy
{
    public partial class form_settings : Form
    {
        public form_settings()
        {
            InitializeComponent();
        }

        private void form_settings_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_get_from_url geturl = new form_get_from_url();
            form_tray main = new form_tray();
            if (main.isOpen(geturl.Name))
            {
                if(geturl.ShowDialog() == DialogResult.OK)
                {
                    string pettern = Properties.Settings.Default.pettern;
                    textBox1.Text = pettern;
                }
            }
        }

        private void form_settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.pettern;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void form_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
