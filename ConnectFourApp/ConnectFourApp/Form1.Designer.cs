namespace ConnectFourApp
{
    partial class frmConnectFourApp
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
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.txtWinnerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(62, 26);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(948, 530);
            this.pnlBoard.TabIndex = 0;
            // 
            // txtWinnerBox
            // 
            this.txtWinnerBox.Location = new System.Drawing.Point(1040, 26);
            this.txtWinnerBox.Name = "txtWinnerBox";
            this.txtWinnerBox.ReadOnly = true;
            this.txtWinnerBox.Size = new System.Drawing.Size(313, 22);
            this.txtWinnerBox.TabIndex = 1;
            // 
            // frmConnectFourApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 597);
            this.Controls.Add(this.txtWinnerBox);
            this.Controls.Add(this.pnlBoard);
            this.Name = "frmConnectFourApp";
            this.Text = "ConnectFourApp";
            this.Load += new System.EventHandler(this.frmConnectFourApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.TextBox txtWinnerBox;
    }
}

