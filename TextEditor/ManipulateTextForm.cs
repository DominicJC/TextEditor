using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class ManipulateTextForm : Form
    {
        public string textSelection;

        public ManipulateTextForm()
        {
            InitializeComponent();
        }

        public ManipulateTextForm(string text)
        {
            InitializeComponent();
            textSelection = text;
            lblText.Text = textSelection;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPallindrome_Click(object sender, EventArgs e)
        {
            if(TextManipulation.IsItAPalindrome(textSelection))
            {
                lblResult.Text = "Yes!";
            }
            else if(!TextManipulation.IsItAPalindrome(textSelection))
            {
                lblResult.Text = "No!";
            }
        }

        private void btnAnagram_Click(object sender, EventArgs e)
        {
            txtAnagram.Visible = true;
            btnAnagramResult.Visible = true;
            txtAnagram.Focus();
        }

        private void btnAnagramResult_Click(object sender, EventArgs e)
        {
            if(TextManipulation.AreStringsAnagrams(textSelection, txtAnagram.Text))
            {
                lblResult.Text = "Yes!";
            }
            else if(!TextManipulation.AreStringsAnagrams(textSelection, txtAnagram.Text))
            {
                lblResult.Text = "No!";
            }
        }
    }
}
