using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Asrfly.Properties;
namespace Asrfly.Code
{
    public static class MessageCollections
    {
        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowErrorServer()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFiledsRequired()
        {
            MessageBox.Show(Resources.FiledsReqText, Resources.FiledReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRequiredDeleteRow()
        {
            MessageBox.Show(Resources.ShowReDeleteFiledText, Resources.ShowReDeleteFiledCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
        public static bool ShowDeleteDialog()
        {
          var result=  MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Notificaitons
        public static void ShowAddNotificaiton()
        {
            Gui.GuiNotificaiton.NotificationForm notificationForm = new Gui.GuiNotificaiton.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الاضافة بنجاح";
            notificationForm.Show();
        }
        public static void ShowUpdateNotificaiton()
        {
            Gui.GuiNotificaiton.NotificationForm notificationForm = new Gui.GuiNotificaiton.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية التعديل بنجاح";
            notificationForm.Show();
        }
        public static void ShowDeleteNotificaiton()
        {
            Gui.GuiNotificaiton.NotificationForm notificationForm = new Gui.GuiNotificaiton.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الحذف بنجاح";
            notificationForm.Show();
        }
    }
}
