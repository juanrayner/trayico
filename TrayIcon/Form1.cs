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
        NotifyForm objNotifyForm;

        public Form1()
        {
            InitializeComponent();

            objNotifyForm = new NotifyForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                ShowInTaskbar = false;

                //notifyIcon1.BalloonTipTitle = notifyIcon1.BalloonTipTitle;
                //notifyIcon1.BalloonTipText = "Still running in try icon";
                //notifyIcon1.ShowBalloonTip(500);
            }

            else if (FormWindowState.Normal == WindowState)
            {
                notifyIcon1.Visible = false;
                ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks != 2)
            {
                if (objNotifyForm.Visible == false)
                {
                    objNotifyForm.Show();
                }
                else
                {
                    objNotifyForm.Hide();
                }
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BringToFront();
        }
    }
}
