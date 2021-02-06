﻿using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Remove_Copy
{
    public partial class form_tray : Form
    {

        private ClipBoardMonitor cbm = null;

        public form_tray()
        {
            InitializeComponent();
            cbm = new ClipBoardMonitor();
            cbm.newClip += cbm_newClip;
        }

        private void cbm_newClip(string txt)
        {
            Clipboard.SetText(txt);
            notifyIcon1.BalloonTipTitle = "Remove Copy";
            notifyIcon1.BalloonTipText = "출처 제거되었습니다";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;            
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon1.Visible = true;
            notifyIcon1.Icon = Properties.Resources.icon;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_settings fs = new form_settings();
            fs.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_settings fs = new form_settings();
            fs.ShowDialog();
        }
    }

    public class ClipBoardMonitor : NativeWindow
    {

        private const int WM_DESTROY = 0x2;
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30d;

        [DllImport("user32.dll")]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll")]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public event NewClipHandler newClip;
        public delegate void NewClipHandler(string txt);

        private IntPtr NextClipBoardViewerHandle;

        public ClipBoardMonitor()
        {
            this.CreateHandle(new CreateParams());
            this.NextClipBoardViewerHandle = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsText())
                    {
                        string txt = Clipboard.GetText();
                        if (this.newClip != null)
                        {
                            string result = removeCopyright(txt);
                            if(txt != result)
                                this.newClip(result);
                        }
                    }
                    SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);

                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam.Equals(this.NextClipBoardViewerHandle))
                    {
                        this.NextClipBoardViewerHandle = m.LParam;
                    }
                    else if (!this.NextClipBoardViewerHandle.Equals(IntPtr.Zero))
                    {
                        SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                case WM_DESTROY:
                    ChangeClipboardChain(this.Handle, this.NextClipBoardViewerHandle);
                    break;

            }

            base.WndProc(ref m);
        }
        private string removeCopyright(string txt)
        {            
            string pettern = Properties.Settings.Default.pettern;
            Regex r = new Regex(pettern, RegexOptions.RightToLeft);
            txt = r.Replace(txt, "", 1);
            return txt;
        }
    }
}
