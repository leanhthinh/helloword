namespace Hello_Word
{
    partial class frmHelloWord
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
            this.lblHelloWord = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWord
            // 
            this.lblHelloWord.AutoSize = true;
            this.lblHelloWord.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWord.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWord.Location = new System.Drawing.Point(207, 83);
            this.lblHelloWord.Name = "lblHelloWord";
            this.lblHelloWord.Size = new System.Drawing.Size(0, 80);
            this.lblHelloWord.TabIndex = 0;
            this.lblHelloWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelloWord.Click += new System.EventHandler(this.lblHelloWord_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(141, 254);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Hello Word";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmHelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHelloWord);
            this.Name = "frmHelloWord";
            this.Text = "Hello Word";
            this.Load += new System.EventHandler(this.frmHelloWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWord;
        private System.Windows.Forms.Button btnShow;
    }
}

