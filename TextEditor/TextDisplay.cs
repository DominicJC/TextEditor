using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace TextEditor
{
    static class TextDisplay
    {
        public static void AlignLeft(RichTextBox txtMain)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Left;
            txtMain.Focus();
        }

        public static void AlignRight(RichTextBox txtMain)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Right;
            txtMain.Focus();
        }

        public static void AlignCentre(RichTextBox txtMain)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
            txtMain.Focus();
        }

        public static void BoldText(RichTextBox txtMain, CheckBox chbBold, CheckBox chbItalic, CheckBox chbUnderline)
        {
            if (txtMain.SelectionLength > 0)
            {
                if (!chbBold.Checked)
                {
                    if(chbItalic.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Bold | FontStyle.Italic);
                    }
                    else if(!chbItalic.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                    }
                    else if(chbItalic.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                    else if (!chbItalic.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Bold);
                    }

                    chbBold.CheckState = CheckState.Checked;
                }
                else if(chbBold.Checked)
                {
                    if (chbItalic.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Italic);
                    }
                    else if (!chbItalic.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Underline);
                    }
                    else if (chbItalic.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Italic | FontStyle.Underline);
                    }
                    else if (!chbItalic.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular);
                    }

                    chbBold.CheckState = CheckState.Unchecked;
                }

                
            }
            txtMain.Focus();

        }

        public static void ItalicText(RichTextBox txtMain, CheckBox chbBold, CheckBox chbItalic, CheckBox chbUnderline)
        {
            if (txtMain.SelectionLength > 0)
            {
                if (!chbItalic.Checked)
                {
                    if (chbBold.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Italic | FontStyle.Bold);
                    }
                    else if (!chbBold.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Italic | FontStyle.Underline);
                    }
                    else if (chbBold.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                    }
                    else if (!chbBold.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Italic);
                    }

                    chbItalic.CheckState = CheckState.Checked;
                }
                else if (chbItalic.Checked)
                {
                    if (chbBold.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Bold);
                    }
                    else if (!chbBold.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Underline);
                    }
                    else if (chbBold.Checked && chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Bold | FontStyle.Underline);
                    }
                    else if (!chbBold.Checked && !chbUnderline.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular);
                    }

                    chbItalic.CheckState = CheckState.Unchecked;
                }
            }
            txtMain.Focus();
        }

        public static void UnderlineText(RichTextBox txtMain, CheckBox chbBold, CheckBox chbItalic, CheckBox chbUnderline)
        {
            if (txtMain.SelectionLength > 0)
            {
                if (!chbUnderline.Checked)
                {
                    if (chbBold.Checked && !chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Underline | FontStyle.Bold);
                    }
                    else if (!chbBold.Checked && chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Underline | FontStyle.Italic);
                    }
                    else if (chbBold.Checked && chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                    }
                    else if (!chbBold.Checked && !chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Underline);
                    }

                    chbUnderline.CheckState = CheckState.Checked;
                }
                else if (chbUnderline.Checked)
                {
                    if (chbBold.Checked && !chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Bold);
                    }
                    else if (!chbBold.Checked && chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Italic);
                    }
                    else if (chbBold.Checked && chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);
                    }
                    else if (!chbBold.Checked && !chbItalic.Checked)
                    {
                        txtMain.SelectionFont = new Font(txtMain.SelectionFont, FontStyle.Regular);
                    }

                    chbUnderline.CheckState = CheckState.Unchecked;
                }
            }
            txtMain.Focus();
        }

        public static void ChangeFont(RichTextBox txtMain, object sender)
        {
            FontFamily font = new FontFamily(((ComboBox)sender).SelectedItem.ToString());
            if (txtMain.SelectionLength > 0)
            {
                txtMain.SelectionFont = new Font(font, txtMain.Font.Size);
            }
            else
            {
                txtMain.Font = new Font(font, txtMain.Font.Size);
            }
            txtMain.Focus();
        }

        public static void ChangeFontSize(RichTextBox txtMain, object sender)
        {
            float size = Convert.ToSingle(((ComboBox)sender).Text);
            if (txtMain.SelectionLength > 0)
            {
                txtMain.SelectionFont = new Font(txtMain.Font.FontFamily, size);
            }
            else
            {
                txtMain.Font = new Font(txtMain.Font.FontFamily, size);
            }
            txtMain.Focus();
        }

        public static void ChangeHighlightColour(RichTextBox txtMain)
        {
            ColorDialog colours = new ColorDialog();
            DialogResult result = colours.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(txtMain.SelectionLength > 0)
                {
                    txtMain.SelectionBackColor = colours.Color;
                }
            }
            txtMain.Focus();
        }

        public static void ChangeFontColour(RichTextBox txtMain)
        {
            ColorDialog colours = new ColorDialog();
            DialogResult result = colours.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (txtMain.SelectionLength > 0)
                {
                    txtMain.SelectionColor = colours.Color;
                }
            }
            txtMain.Focus();
        }
    }
}
