namespace MKWindowFormApp1
{
    partial class ShapeModeDialog
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
            this.BtnStraightLine = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStraightLine
            // 
            this.BtnStraightLine.Location = new System.Drawing.Point(13, 31);
            this.BtnStraightLine.Name = "BtnStraightLine";
            this.BtnStraightLine.Size = new System.Drawing.Size(75, 23);
            this.BtnStraightLine.TabIndex = 0;
            this.BtnStraightLine.Text = "直線";
            this.BtnStraightLine.UseVisualStyleBackColor = true;
            this.BtnStraightLine.Click += new System.EventHandler(this.BtnStraightLine_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Location = new System.Drawing.Point(95, 30);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(75, 23);
            this.BtnSquare.TabIndex = 1;
            this.BtnSquare.Text = "四角形";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Location = new System.Drawing.Point(177, 29);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(75, 23);
            this.BtnCircle.TabIndex = 2;
            this.BtnCircle.Text = "円";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // ShapeModeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 82);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnStraightLine);
            this.MinimumSize = new System.Drawing.Size(289, 121);
            this.Name = "ShapeModeDialog";
            this.Text = "図形モード変更";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStraightLine;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnCircle;
    }
}