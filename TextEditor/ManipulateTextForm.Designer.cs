namespace TextEditor
{
    partial class ManipulateTextForm
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
            this.grbText = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPallindrome = new System.Windows.Forms.Button();
            this.lblPalindrome = new System.Windows.Forms.Label();
            this.btnAnagram = new System.Windows.Forms.Button();
            this.lblAnagram = new System.Windows.Forms.Label();
            this.txtAnagram = new System.Windows.Forms.TextBox();
            this.btnAnagramResult = new System.Windows.Forms.Button();
            this.grbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.lblText);
            this.grbText.Location = new System.Drawing.Point(12, 12);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(195, 60);
            this.grbText.TabIndex = 0;
            this.grbText.TabStop = false;
            this.grbText.Text = "Text";
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblText.Location = new System.Drawing.Point(3, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(189, 41);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(347, 226);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(213, 19);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(209, 50);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPallindrome
            // 
            this.btnPallindrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPallindrome.Location = new System.Drawing.Point(12, 78);
            this.btnPallindrome.Name = "btnPallindrome";
            this.btnPallindrome.Size = new System.Drawing.Size(25, 25);
            this.btnPallindrome.TabIndex = 3;
            this.btnPallindrome.TabStop = false;
            this.btnPallindrome.Text = "P";
            this.btnPallindrome.UseVisualStyleBackColor = true;
            this.btnPallindrome.Click += new System.EventHandler(this.btnPallindrome_Click);
            // 
            // lblPalindrome
            // 
            this.lblPalindrome.Location = new System.Drawing.Point(43, 78);
            this.lblPalindrome.Name = "lblPalindrome";
            this.lblPalindrome.Size = new System.Drawing.Size(150, 25);
            this.lblPalindrome.TabIndex = 4;
            this.lblPalindrome.Text = "Is text a palindrome?";
            this.lblPalindrome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnagram
            // 
            this.btnAnagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnagram.Location = new System.Drawing.Point(12, 109);
            this.btnAnagram.Name = "btnAnagram";
            this.btnAnagram.Size = new System.Drawing.Size(25, 25);
            this.btnAnagram.TabIndex = 5;
            this.btnAnagram.TabStop = false;
            this.btnAnagram.Text = "A";
            this.btnAnagram.UseVisualStyleBackColor = true;
            this.btnAnagram.Click += new System.EventHandler(this.btnAnagram_Click);
            // 
            // lblAnagram
            // 
            this.lblAnagram.Location = new System.Drawing.Point(43, 109);
            this.lblAnagram.Name = "lblAnagram";
            this.lblAnagram.Size = new System.Drawing.Size(150, 25);
            this.lblAnagram.TabIndex = 6;
            this.lblAnagram.Text = "Check for anagram.";
            this.lblAnagram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnagram
            // 
            this.txtAnagram.Location = new System.Drawing.Point(199, 112);
            this.txtAnagram.Name = "txtAnagram";
            this.txtAnagram.Size = new System.Drawing.Size(100, 20);
            this.txtAnagram.TabIndex = 7;
            this.txtAnagram.TabStop = false;
            this.txtAnagram.Visible = false;
            // 
            // btnAnagramResult
            // 
            this.btnAnagramResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnagramResult.Location = new System.Drawing.Point(305, 109);
            this.btnAnagramResult.Name = "btnAnagramResult";
            this.btnAnagramResult.Size = new System.Drawing.Size(25, 25);
            this.btnAnagramResult.TabIndex = 8;
            this.btnAnagramResult.TabStop = false;
            this.btnAnagramResult.Text = "A";
            this.btnAnagramResult.UseVisualStyleBackColor = true;
            this.btnAnagramResult.Visible = false;
            this.btnAnagramResult.Click += new System.EventHandler(this.btnAnagramResult_Click);
            // 
            // ManipulateTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnAnagramResult);
            this.Controls.Add(this.txtAnagram);
            this.Controls.Add(this.lblAnagram);
            this.Controls.Add(this.btnAnagram);
            this.Controls.Add(this.lblPalindrome);
            this.Controls.Add(this.btnPallindrome);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "ManipulateTextForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Options";
            this.grbText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPallindrome;
        private System.Windows.Forms.Label lblPalindrome;
        private System.Windows.Forms.Button btnAnagram;
        private System.Windows.Forms.Label lblAnagram;
        private System.Windows.Forms.TextBox txtAnagram;
        private System.Windows.Forms.Button btnAnagramResult;
    }
}