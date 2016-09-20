namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.baseLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpToolStrip = new System.Windows.Forms.TableLayoutPanel();
            this.grbClipBoard = new System.Windows.Forms.GroupBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.chbUnderline = new System.Windows.Forms.CheckBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.btnFontColour = new System.Windows.Forms.Button();
            this.btnHighlight = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnAlignCentre = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grbText = new System.Windows.Forms.GroupBox();
            this.btnLongestSentence = new System.Windows.Forms.Button();
            this.btnMostFrequent = new System.Windows.Forms.Button();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.btnManipulateText = new System.Windows.Forms.Button();
            this.mnuStrip.SuspendLayout();
            this.baseLayoutPanel.SuspendLayout();
            this.tlpToolStrip.SuspendLayout();
            this.grbClipBoard.SuspendLayout();
            this.grbFont.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.grbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(984, 25);
            this.mnuStrip.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 21);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(114, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(114, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(114, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(114, 22);
            this.mnuSaveAs.Text = "Save As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(114, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(3, 103);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(978, 470);
            this.txtMain.TabIndex = 1;
            this.txtMain.TabStop = false;
            this.txtMain.Text = "";
            // 
            // baseLayoutPanel
            // 
            this.baseLayoutPanel.ColumnCount = 1;
            this.baseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.baseLayoutPanel.Controls.Add(this.mnuStrip, 0, 0);
            this.baseLayoutPanel.Controls.Add(this.txtMain, 0, 2);
            this.baseLayoutPanel.Controls.Add(this.tlpToolStrip, 0, 1);
            this.baseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.baseLayoutPanel.Name = "baseLayoutPanel";
            this.baseLayoutPanel.RowCount = 3;
            this.baseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.baseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.baseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.baseLayoutPanel.Size = new System.Drawing.Size(984, 561);
            this.baseLayoutPanel.TabIndex = 3;
            // 
            // tlpToolStrip
            // 
            this.tlpToolStrip.ColumnCount = 4;
            this.tlpToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpToolStrip.Controls.Add(this.grbClipBoard, 0, 0);
            this.tlpToolStrip.Controls.Add(this.grbFont, 1, 0);
            this.tlpToolStrip.Controls.Add(this.grbSearch, 3, 0);
            this.tlpToolStrip.Controls.Add(this.grbText, 2, 0);
            this.tlpToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToolStrip.Location = new System.Drawing.Point(3, 28);
            this.tlpToolStrip.Name = "tlpToolStrip";
            this.tlpToolStrip.RowCount = 1;
            this.tlpToolStrip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpToolStrip.Size = new System.Drawing.Size(978, 69);
            this.tlpToolStrip.TabIndex = 2;
            // 
            // grbClipBoard
            // 
            this.grbClipBoard.Controls.Add(this.btnCut);
            this.grbClipBoard.Controls.Add(this.btnPaste);
            this.grbClipBoard.Controls.Add(this.btnCopy);
            this.grbClipBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbClipBoard.Location = new System.Drawing.Point(0, 0);
            this.grbClipBoard.Margin = new System.Windows.Forms.Padding(0);
            this.grbClipBoard.Name = "grbClipBoard";
            this.grbClipBoard.Padding = new System.Windows.Forms.Padding(1);
            this.grbClipBoard.Size = new System.Drawing.Size(150, 69);
            this.grbClipBoard.TabIndex = 0;
            this.grbClipBoard.TabStop = false;
            this.grbClipBoard.Text = "Clipboard";
            // 
            // btnCut
            // 
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.Location = new System.Drawing.Point(9, 17);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(70, 23);
            this.btnCut.TabIndex = 3;
            this.btnCut.TabStop = false;
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.Location = new System.Drawing.Point(85, 17);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(59, 48);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.TabStop = false;
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(9, 42);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.TabStop = false;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // grbFont
            // 
            this.grbFont.Controls.Add(this.chbUnderline);
            this.grbFont.Controls.Add(this.chbItalic);
            this.grbFont.Controls.Add(this.chbBold);
            this.grbFont.Controls.Add(this.btnFontColour);
            this.grbFont.Controls.Add(this.btnHighlight);
            this.grbFont.Controls.Add(this.btnAlignRight);
            this.grbFont.Controls.Add(this.btnAlignCentre);
            this.grbFont.Controls.Add(this.btnAlignLeft);
            this.grbFont.Controls.Add(this.cmbFontSize);
            this.grbFont.Controls.Add(this.cmbFont);
            this.grbFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFont.Location = new System.Drawing.Point(150, 0);
            this.grbFont.Margin = new System.Windows.Forms.Padding(0);
            this.grbFont.Name = "grbFont";
            this.grbFont.Padding = new System.Windows.Forms.Padding(1);
            this.grbFont.Size = new System.Drawing.Size(372, 69);
            this.grbFont.TabIndex = 1;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // chbUnderline
            // 
            this.chbUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbUnderline.AutoCheck = false;
            this.chbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("chbUnderline.Image")));
            this.chbUnderline.Location = new System.Drawing.Point(61, 42);
            this.chbUnderline.Name = "chbUnderline";
            this.chbUnderline.Size = new System.Drawing.Size(23, 23);
            this.chbUnderline.TabIndex = 14;
            this.chbUnderline.TabStop = false;
            this.chbUnderline.UseVisualStyleBackColor = true;
            this.chbUnderline.Click += new System.EventHandler(this.chbUnderline_Click);
            // 
            // chbItalic
            // 
            this.chbItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbItalic.AutoCheck = false;
            this.chbItalic.Image = ((System.Drawing.Image)(resources.GetObject("chbItalic.Image")));
            this.chbItalic.Location = new System.Drawing.Point(32, 42);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(23, 23);
            this.chbItalic.TabIndex = 13;
            this.chbItalic.TabStop = false;
            this.chbItalic.UseVisualStyleBackColor = true;
            this.chbItalic.Click += new System.EventHandler(this.chbItalic_Click);
            // 
            // chbBold
            // 
            this.chbBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbBold.AutoCheck = false;
            this.chbBold.Image = ((System.Drawing.Image)(resources.GetObject("chbBold.Image")));
            this.chbBold.Location = new System.Drawing.Point(3, 42);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(23, 23);
            this.chbBold.TabIndex = 12;
            this.chbBold.TabStop = false;
            this.chbBold.UseVisualStyleBackColor = true;
            this.chbBold.Click += new System.EventHandler(this.chbBold_Click);
            // 
            // btnFontColour
            // 
            this.btnFontColour.Image = ((System.Drawing.Image)(resources.GetObject("btnFontColour.Image")));
            this.btnFontColour.Location = new System.Drawing.Point(119, 42);
            this.btnFontColour.Name = "btnFontColour";
            this.btnFontColour.Size = new System.Drawing.Size(23, 23);
            this.btnFontColour.TabIndex = 11;
            this.btnFontColour.TabStop = false;
            this.btnFontColour.UseVisualStyleBackColor = true;
            this.btnFontColour.Click += new System.EventHandler(this.btnFontColour_Click);
            // 
            // btnHighlight
            // 
            this.btnHighlight.Image = ((System.Drawing.Image)(resources.GetObject("btnHighlight.Image")));
            this.btnHighlight.Location = new System.Drawing.Point(90, 42);
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(23, 23);
            this.btnHighlight.TabIndex = 10;
            this.btnHighlight.TabStop = false;
            this.btnHighlight.UseVisualStyleBackColor = true;
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignRight.Image")));
            this.btnAlignRight.Location = new System.Drawing.Point(231, 15);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(23, 23);
            this.btnAlignRight.TabIndex = 7;
            this.btnAlignRight.TabStop = false;
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnAlignCentre
            // 
            this.btnAlignCentre.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignCentre.Image")));
            this.btnAlignCentre.Location = new System.Drawing.Point(202, 15);
            this.btnAlignCentre.Name = "btnAlignCentre";
            this.btnAlignCentre.Size = new System.Drawing.Size(23, 23);
            this.btnAlignCentre.TabIndex = 6;
            this.btnAlignCentre.TabStop = false;
            this.btnAlignCentre.UseVisualStyleBackColor = true;
            this.btnAlignCentre.Click += new System.EventHandler(this.btnAlignCentre_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignLeft.Image")));
            this.btnAlignLeft.Location = new System.Drawing.Point(173, 15);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(23, 23);
            this.btnAlignLeft.TabIndex = 5;
            this.btnAlignLeft.TabStop = false;
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
            this.cmbFontSize.Location = new System.Drawing.Point(121, 17);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(46, 21);
            this.cmbFontSize.TabIndex = 1;
            this.cmbFontSize.TabStop = false;
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(3, 17);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 21);
            this.cmbFont.TabIndex = 0;
            this.cmbFont.TabStop = false;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSelectAll);
            this.grbSearch.Controls.Add(this.txtFind);
            this.grbSearch.Controls.Add(this.btnFind);
            this.grbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSearch.Location = new System.Drawing.Point(827, 0);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(1);
            this.grbSearch.Size = new System.Drawing.Size(151, 69);
            this.grbSearch.TabIndex = 2;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(4, 42);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.TabStop = false;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(4, 17);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(110, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.TabStop = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.btnLongestSentence);
            this.grbText.Controls.Add(this.btnMostFrequent);
            this.grbText.Controls.Add(this.btnWordCount);
            this.grbText.Controls.Add(this.btnManipulateText);
            this.grbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbText.Location = new System.Drawing.Point(522, 0);
            this.grbText.Margin = new System.Windows.Forms.Padding(0);
            this.grbText.Name = "grbText";
            this.grbText.Padding = new System.Windows.Forms.Padding(1);
            this.grbText.Size = new System.Drawing.Size(305, 69);
            this.grbText.TabIndex = 3;
            this.grbText.TabStop = false;
            this.grbText.Text = "Text";
            // 
            // btnLongestSentence
            // 
            this.btnLongestSentence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLongestSentence.Location = new System.Drawing.Point(176, 15);
            this.btnLongestSentence.Name = "btnLongestSentence";
            this.btnLongestSentence.Size = new System.Drawing.Size(125, 23);
            this.btnLongestSentence.TabIndex = 3;
            this.btnLongestSentence.TabStop = false;
            this.btnLongestSentence.Text = "Longest Sentence";
            this.btnLongestSentence.UseVisualStyleBackColor = true;
            this.btnLongestSentence.Click += new System.EventHandler(this.btnLongestSentence_Click);
            // 
            // btnMostFrequent
            // 
            this.btnMostFrequent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMostFrequent.Location = new System.Drawing.Point(176, 42);
            this.btnMostFrequent.Name = "btnMostFrequent";
            this.btnMostFrequent.Size = new System.Drawing.Size(125, 23);
            this.btnMostFrequent.TabIndex = 2;
            this.btnMostFrequent.TabStop = false;
            this.btnMostFrequent.Text = "Most Frequent Word";
            this.btnMostFrequent.UseVisualStyleBackColor = true;
            this.btnMostFrequent.Click += new System.EventHandler(this.btnMostFrequent_Click);
            // 
            // btnWordCount
            // 
            this.btnWordCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWordCount.Location = new System.Drawing.Point(95, 15);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(75, 23);
            this.btnWordCount.TabIndex = 1;
            this.btnWordCount.TabStop = false;
            this.btnWordCount.Text = "Word Count";
            this.btnWordCount.UseVisualStyleBackColor = true;
            this.btnWordCount.Click += new System.EventHandler(this.btnWordCount_Click);
            // 
            // btnManipulateText
            // 
            this.btnManipulateText.Location = new System.Drawing.Point(4, 15);
            this.btnManipulateText.Name = "btnManipulateText";
            this.btnManipulateText.Size = new System.Drawing.Size(59, 48);
            this.btnManipulateText.TabIndex = 0;
            this.btnManipulateText.TabStop = false;
            this.btnManipulateText.Text = "Text Options";
            this.btnManipulateText.UseVisualStyleBackColor = true;
            this.btnManipulateText.Click += new System.EventHandler(this.btnManipulateText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.baseLayoutPanel);
            this.MainMenuStrip = this.mnuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.baseLayoutPanel.ResumeLayout(false);
            this.baseLayoutPanel.PerformLayout();
            this.tlpToolStrip.ResumeLayout(false);
            this.grbClipBoard.ResumeLayout(false);
            this.grbFont.ResumeLayout(false);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.TableLayoutPanel baseLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tlpToolStrip;
        private System.Windows.Forms.GroupBox grbClipBoard;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.Button btnAlignCentre;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Button btnManipulateText;
        private System.Windows.Forms.Button btnWordCount;
        private System.Windows.Forms.Button btnMostFrequent;
        private System.Windows.Forms.Button btnLongestSentence;
        private System.Windows.Forms.Button btnHighlight;
        private System.Windows.Forms.Button btnFontColour;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.CheckBox chbUnderline;
        private System.Windows.Forms.CheckBox chbItalic;
    }
}

