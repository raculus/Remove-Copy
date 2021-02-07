using System;
using System.Net;
using System.Windows.Forms;

namespace Remove_Copy
{
    public partial class form_get_from_url : Form
    {
        public form_get_from_url()
        {
            InitializeComponent();
        }

        private void form_get_from_url_Load(object sender, EventArgs e)
        {
            string setting_url = Properties.Settings.Default.backup_url;
            textBox1.Text = setting_url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string pettern = wc.DownloadString(url);
            Properties.Settings.Default.backup_url = url;
            Properties.Settings.Default.pettern = pettern;
            this.Close();
        }

        private void form_get_from_url_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
