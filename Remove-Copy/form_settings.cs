using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Linq;

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

        private void form_settings_Load(object sender, EventArgs e)
        {
            var list = Properties.Settings.Default.pettern.Split('\n');
            listBox1.Items.AddRange(list);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var petterns = String.Join("\n",listBox1.Items.Cast<string>().ToList());
            Properties.Settings.Default.pettern = petterns;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void form_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var text = textBox_regex.Text;
            var list = listBox1.Items.Cast<String>().ToList();
            if(list.Contains(text))
                MessageBox.Show("이미 추가되어 있습니다.");
            else if(text == "" || text == " ")
                MessageBox.Show("값이 없습니다.");
            else
            {
                listBox1.Items.Add(text);
                textBox_regex.Text = "";
            }
        }

        private void button_removeItems_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button_getFromWeb_Click(object sender, EventArgs e)
        {
            form_get_from_url geturl = new form_get_from_url();
            form_tray main = new form_tray();
            if (main.isOpen(geturl.Name))
            {
                if (geturl.ShowDialog() == DialogResult.OK)
                {
                    var petterns = Properties.Settings.Default.pettern.Split('\n');
                    foreach(var p in petterns)
                    {
                        if (!(listBox1.Items.Cast<string>().ToList().Contains(p)))
                        {
                            listBox1.Items.Add(p);
                        }
                    }                    
                }
            }
        }

        private void button_initList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
