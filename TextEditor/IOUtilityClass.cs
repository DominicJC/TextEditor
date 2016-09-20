using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    static class IOUtility
    {
        public static void NewSheet(RichTextBox txtMain)
        {
            if (txtMain.Text != "")
            {
                DialogResult res = MessageBox.Show("Any unsaved data will be lost. Are you sure you want to proceed?", "New", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                    txtMain.Text = "";
            }
        }

        public static void OpenFile(RichTextBox txtMain, out string fileName)
        {
            Stream stream = null;
            fileName = "New";
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt";
            openFile.RestoreDirectory = true;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((stream = openFile.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            using (StreamReader read = new StreamReader(stream))
                            {
                                string text = read.ReadToEnd();
                                txtMain.Text = text;
                                fileName = openFile.FileName;
                            }
                        }
                    }

                }
                catch(Exception e)
                {
                    MessageBox.Show("Could not open file" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void SaveFile(RichTextBox txtMain, string fileName = "New")
        {
            Stream stream = null;
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.InitialDirectory = "c:\\";
            saveFile.Filter = "txt files (*.txt)|*.txt";

            if (fileName == "New")
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((stream = saveFile.OpenFile()) != null)
                        {
                            using (stream)
                            {
                                using (StreamWriter writer = new StreamWriter(stream))
                                {
                                    writer.WriteLine(txtMain.Text);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Could not save file" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    if (fileName != null)
                    {
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(txtMain.Text);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not save file" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
