using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string pettern = textBox1.Text;
            if (pettern == "")
                pettern = Properties.Settings.Default.default_pettern;
            else
                Properties.Settings.Default.pettern = pettern;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.default_pettern;
        }

        private void form_settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.pettern;
        }
    }
}
