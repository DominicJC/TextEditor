using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        public static string fileName = "New";
        
        public MainForm()
        {
            InitializeComponent();
            InitialiseCombos();
        }

        private void InitialiseCombos()
        {  
            //Fonts            
            foreach (FontFamily fonts in FontFamily.Families)
            {
                cmbFont.Items.Add(fonts.Name.ToString());
            }
            cmbFont.Text = txtMain.Font.Name.ToString();

            cmbFontSize.Text = txtMain.Font.Size.ToString();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            IOUtility.NewSheet(txtMain);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            IOUtility.OpenFile(txtMain, out fileName);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if(fileName == "New")
            {
                IOUtility.SaveFile(txtMain);
            }
            else
            {
                IOUtility.SaveFile(txtMain, fileName);
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            IOUtility.SaveFile(txtMain);
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextDisplay.ChangeFont(txtMain, sender);
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextDisplay.ChangeFontSize(txtMain, sender);
        }

        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            TextDisplay.AlignLeft(txtMain);
        }

        private void btnAlignCentre_Click(object sender, EventArgs e)
        {
            TextDisplay.AlignCentre(txtMain);
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            TextDisplay.AlignRight(txtMain);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            ClipboardClass.Cut(txtMain);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            ClipboardClass.Copy(txtMain);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            ClipboardClass.Paste(txtMain);
        }

        private void chbBold_Click(object sender, EventArgs e)
        {
            TextDisplay.BoldText(txtMain, chbBold, chbItalic, chbUnderline);
        }

        private void chbItalic_Click(object sender, EventArgs e)
        {
            TextDisplay.ItalicText(txtMain, chbBold, chbItalic, chbUnderline);
        }

        private void chbUnderline_Click(object sender, EventArgs e)
        {
            TextDisplay.UnderlineText(txtMain, chbBold, chbItalic, chbUnderline);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ClipboardClass.SelectAll(txtMain);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            ClipboardClass.SearchText(txtMain, txtFind.Text);
        }

        private void btnManipulateText_Click(object sender, EventArgs e)
        {
            if (txtMain.SelectedText.Length > 0)
            {
                ManipulateTextForm TextOptions = new ManipulateTextForm(txtMain.SelectedText);
                TextOptions.Show();
            }
            else
            {
                MessageBox.Show("Please select some text.", "No Text Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Word Count: " + TextManipulation.CountWords(txtMain.Text), "Word Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostFrequent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Most Frequent Word: " + TextManipulation.GetMostFrequentWord(txtMain.Text), "Most Frequent Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLongestSentence_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Longest Sentence: " + TextManipulation.getLongestSentence(txtMain.Text), "Longest Sentence", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            TextDisplay.ChangeHighlightColour(txtMain);
        }

        private void btnFontColour_Click(object sender, EventArgs e)
        {
            TextDisplay.ChangeFontColour(txtMain);
        }

    }
}
