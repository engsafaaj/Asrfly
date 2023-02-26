using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiNotificaiton
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
            timerNotification.Interval = Properties.Settings.Default.HideNotificaitonInterval;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
