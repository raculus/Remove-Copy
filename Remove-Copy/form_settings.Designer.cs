
namespace Remove_Copy
{
    partial class form_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_settings));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_regex = new System.Windows.Forms.TextBox();
            this.button_removeItems = new System.Windows.Forms.Button();
            this.button_getFromWeb = new System.Windows.Forms.Button();
            this.button_initList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "정규식 패턴";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(232, 218);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 30);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "저장";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(293, 144);
            this.listBox1.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(151, 182);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 30);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_regex
            // 
            this.textBox_regex.Location = new System.Drawing.Point(14, 184);
            this.textBox_regex.Name = "textBox_regex";
            this.textBox_regex.Size = new System.Drawing.Size(131, 27);
            this.textBox_regex.TabIndex = 7;
            // 
            // button_removeItems
            // 
            this.button_removeItems.Location = new System.Drawing.Point(232, 182);
            this.button_removeItems.Name = "button_removeItems";
            this.button_removeItems.Size = new System.Drawing.Size(75, 30);
            this.button_removeItems.TabIndex = 6;
            this.button_removeItems.Text = "제거";
            this.button_removeItems.UseVisualStyleBackColor = true;
            this.button_removeItems.Click += new System.EventHandler(this.button_removeItems_Click);
            // 
            // button_getFromWeb
            // 
            this.button_getFromWeb.Location = new System.Drawing.Point(90, 218);
            this.button_getFromWeb.Name = "button_getFromWeb";
            this.button_getFromWeb.Size = new System.Drawing.Size(136, 30);
            this.button_getFromWeb.TabIndex = 8;
            this.button_getFromWeb.Text = "웹에서 가져오기";
            this.button_getFromWeb.UseVisualStyleBackColor = true;
            this.button_getFromWeb.Click += new System.EventHandler(this.button_getFromWeb_Click);
            // 
            // button_initList
            // 
            this.button_initList.Location = new System.Drawing.Point(14, 218);
            this.button_initList.Name = "button_initList";
            this.button_initList.Size = new System.Drawing.Size(70, 30);
            this.button_initList.TabIndex = 6;
            this.button_initList.Text = "초기화";
            this.button_initList.UseVisualStyleBackColor = true;
            this.button_initList.Click += new System.EventHandler(this.button_initList_Click);
            // 
            // form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 256);
            this.Controls.Add(this.button_getFromWeb);
            this.Controls.Add(this.textBox_regex);
            this.Controls.Add(this.button_removeItems);
            this.Controls.Add(this.button_initList);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_settings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_settings_FormClosed);
            this.Load += new System.EventHandler(this.form_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_regex;
        private System.Windows.Forms.Button button_removeItems;
        private System.Windows.Forms.Button button_getFromWeb;
        private System.Windows.Forms.Button button_initList;
    }
}