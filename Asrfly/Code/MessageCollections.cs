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
        public static void ShowEmptyMessage()
        {
            MessageBox.Show(Resources.EmptyDataText, Resources.EmptyDataCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
    }
}
