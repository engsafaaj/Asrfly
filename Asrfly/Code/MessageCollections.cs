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
        // Dialog
    }
}
