using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace TextEditor
{
    static class ClipboardClass
    {
        public static void Cut(RichTextBox txtMain)
        {
            if(txtMain.SelectionLength > 0)
            {
                txtMain.Cut();
            }
            txtMain.Focus();
        }

        public static void Copy(RichTextBox txtMain)
        {
            if (txtMain.SelectionLength > 0)
            {
                txtMain.Copy();
            }
            txtMain.Focus();
        }

        public static void Paste(RichTextBox txtMain)
        {
            txtMain.Paste();
            txtMain.Focus();
        }

        public static void SearchText(RichTextBox txtMain, string searchString)
        {
            if (searchString.Length > 0 && txtMain.Text.Length > 0)
            {
                txtMain.Select(txtMain.Find(searchString), searchString.Length);
                txtMain.Focus();
            }
        }

        public static void SelectAll(RichTextBox txtMain)
        {
            txtMain.SelectAll();
            txtMain.Focus();
        }
    }
}
