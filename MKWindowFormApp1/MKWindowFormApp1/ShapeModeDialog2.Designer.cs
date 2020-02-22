namespace MKWindowFormApp1
{
    partial class ShapeModeDialog2
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStraightLine = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(170, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "描画モード";
            // 
            // BtnStraightLine
            // 
            this.BtnStraightLine.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnStraightLine.Location = new System.Drawing.Point(68, 109);
            this.BtnStraightLine.Name = "BtnStraightLine";
            this.BtnStraightLine.Size = new System.Drawing.Size(100, 50);
            this.BtnStraightLine.TabIndex = 1;
            this.BtnStraightLine.Text = "直線";
            this.BtnStraightLine.UseVisualStyleBackColor = true;
            this.BtnStraightLine.Click += new System.EventHandler(this.BtnStraightLine_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSquare.Location = new System.Drawing.Point(189, 109);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(100, 50);
            this.BtnSquare.TabIndex = 2;
            this.BtnSquare.Text = "四角形";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCircle.Location = new System.Drawing.Point(314, 109);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(100, 50);
            this.BtnCircle.TabIndex = 3;
            this.BtnCircle.Text = "円";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // ShapeModeDialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 197);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnStraightLine);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeModeDialog2";
            this.Text = "ShapeModeDialog2";
            this.Load += new System.EventHandler(this.ShapeModeDialog2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStraightLine;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnCircle;
    }
}