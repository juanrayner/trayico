using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayIcon
{
    public partial class NotifyForm : Form
    {
        private Form1 mainForm;

        private int wait = 0;
        private int totalSec = 3;

        private bool executingCommand = false;

        public NotifyForm(Form1 mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            SetAllRowsTransitionEvents(panelCenterContainer.Controls);
        }

        private void SetAllRowsTransitionEvents(Control.ControlCollection controls)
        {
            foreach (Control itemControl in controls)
            {                
                itemControl.MouseEnter += Item_PanelCenterContainer_MouseEnter;
                itemControl.Controls[0].MouseEnter += Item_PanelCenterContainer_MouseEnter;
            }
        }

        private void NotifyForm_Shown(object sender, EventArgs e)
        {
            this.Opacity = 1;

            Taskbar taskbar = new Taskbar();
            int taskbarWidth = taskbar.Size.Width;
            int taskbarHeight = taskbar.Size.Height;

            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;

            int margin = 10;

            switch (taskbar.Position)
            {  
                case TaskbarPosition.Left:                    
                    this.Location = new Point(deskWidth - taskbarWidth + margin, deskHeight - this.Height - margin);
                    break;                
                case TaskbarPosition.Right:
                    this.Location = new Point(deskWidth - this.Width - taskbarWidth - margin, deskHeight - this.Height - margin);
                    break;
                case TaskbarPosition.Top:
                    this.Location = new Point(deskWidth - this.Width - margin, deskHeight - taskbarHeight + margin);
                    break;
                case TaskbarPosition.Bottom:
                    this.Location = new Point(deskWidth - this.Width - margin, deskHeight - this.Height - taskbarHeight - margin);
                    break;
                case TaskbarPosition.Unknown:
                default:
                    this.Location = new Point(deskWidth - this.Width - margin, deskHeight - this.Height - margin);
                    break;
            }
        }        

        private void NotifyForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            wait = 0;
            timerClose.Stop();
        }

        private void NotifyForm_Deactivate(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            if (((NotifyForm)sender).Disposing || ((NotifyForm)sender).IsDisposed)
            {
                return;
            }

            this.Opacity -= 0.50;
            wait = 0;
            RowTransition("0");
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (wait == totalSec)
            {
                timerClose.Stop();
                Hide();
            }
            else
            {
                wait++;                
            }
        }

        private void Item_PanelCenterContainer_MouseEnter(object sender, EventArgs e)
        {
            string row = (sender as Control).Tag.ToString();

            RowTransition(row);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!executingCommand)
            {
                executingCommand = true;
                (sender as Control).Text = "Stop";
                RowAction((sender as Control).Tag.ToString());

                TrayIconSetMessage(mainForm.notifyIcon1.BalloonTipTitle, "Loading");
                System.Threading.Thread.Sleep(5000);

                TrayIconSetMessage(mainForm.notifyIcon1.BalloonTipTitle, "Compiling");
                System.Threading.Thread.Sleep(5000);

                TrayIconSetMessage(mainForm.notifyIcon1.BalloonTipTitle, "Ready");

                (sender as Control).Text = "Go";
                RowAction("0");
                executingCommand = false;
            }
            else
            {
                (sender as Control).Text = "Go";
                RowAction("0");
                executingCommand = false;
            }
        }

        private void RowTransition(string row)
        {
            if (!executingCommand)
            {
                foreach (Control item in panelCenterContainer.Controls)
                {
                    if (item.Tag.ToString() == row)
                    {
                        item.BackColor = SystemColors.GradientActiveCaption;
                        if (item.Tag.ToString() != "11")
                        {
                            item.Controls[1].Visible = true;
                            item.Controls[2].Visible = true;
                        }
                    }
                    else
                    {
                        item.BackColor = SystemColors.ControlLightLight;
                        if (item.Tag.ToString() != "11")
                        {
                            item.Controls[1].Visible = false;
                            item.Controls[2].Visible = false;
                        }
                    }
                }
            }
        }

        private void RowAction(string row)
        {
            foreach (Control item in panelCenterContainer.Controls)
            {
                if (item.Tag.ToString() != row)
                {
                    item.Enabled = false;
                }

                if (row == "0")
                {
                    item.Enabled = true;
                }
            }

            if (row == "0")
            {
                btnRepository.Enabled = true;
                btnHome.Enabled = true;
            }
            else
            {
                btnRepository.Enabled = false;
                btnHome.Enabled = false;
            }
        }

        private void TrayIconSetMessage(string title, string body)
        {
            mainForm.notifyIcon1.BalloonTipTitle = title;
            mainForm.notifyIcon1.BalloonTipText = body;
            mainForm.notifyIcon1.ShowBalloonTip(500);
        }

        private void btnRepository_Click(object sender, EventArgs e)
        {
            //openFileDialog1.OpenFile();
            folderBrowserDialog1.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.querytalk.com/");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
