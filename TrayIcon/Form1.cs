using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                TrayIconSetMessage(notifyIcon1.BalloonTipTitle, "Still running in try icon");
                notifyIcon1.ShowBalloonTip(500);

                this.ShowInTaskbar = false;
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;

                this.ShowInTaskbar = true;
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;            
            this.BringToFront();
        }

        private void toolStripMenuItemGo_Click(object sender, EventArgs e)
        {
            TrayIconSetMessage(notifyIcon1.BalloonTipTitle, "Loading");
            System.Threading.Thread.Sleep(5000);

            TrayIconSetMessage(notifyIcon1.BalloonTipTitle, "Compiling");
            System.Threading.Thread.Sleep(5000);

            TrayIconSetMessage(notifyIcon1.BalloonTipTitle, "Ready");
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                toolStripMenuItemOpen_Click(null, null);
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            toolStripMenuItemGo_Click(null, null);
        }

        private void TrayIconSetMessage(string title, string body)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = body;
            notifyIcon1.ShowBalloonTip(500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {

        }
    }
}
