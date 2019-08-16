namespace MKWindowFormApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiPrintPic = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFinishApp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClearPic = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiThickness = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiShapeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiStraightLine = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCircleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiVerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnColorChange = new System.Windows.Forms.Button();
            this.BtnThickness = new System.Windows.Forms.Button();
            this.BtnShapeMode = new System.Windows.Forms.Button();
            this.BtnClearPic = new System.Windows.Forms.Button();
            this.BtnSavePic = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.CdCanvasColor = new System.Windows.Forms.ColorDialog();
            this.FlpToolBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.GbCanvas = new System.Windows.Forms.GroupBox();
            this.PbCanvas = new System.Windows.Forms.PictureBox();
            this.SfdCanvasSave = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip1.SuspendLayout();
            this.FlpToolBtns.SuspendLayout();
            this.GbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiMenuTool,
            this.TsmiEdit,
            this.TsmiHelp});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(719, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // TsmiMenuTool
            // 
            this.TsmiMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNewFile,
            this.TsmiOpenFile,
            this.TsmiSaveAs,
            this.toolStripSeparator1,
            this.TsmiPrintPic,
            this.TsmiFinishApp});
            this.TsmiMenuTool.Name = "TsmiMenuTool";
            this.TsmiMenuTool.Size = new System.Drawing.Size(67, 20);
            this.TsmiMenuTool.Text = "ファイル(&F)";
            // 
            // TsmiNewFile
            // 
            this.TsmiNewFile.Name = "TsmiNewFile";
            this.TsmiNewFile.Size = new System.Drawing.Size(180, 22);
            this.TsmiNewFile.Text = "新規(&N)";
            this.TsmiNewFile.Click += new System.EventHandler(this.TsmiNewFile_Click);
            // 
            // TsmiOpenFile
            // 
            this.TsmiOpenFile.Name = "TsmiOpenFile";
            this.TsmiOpenFile.Size = new System.Drawing.Size(180, 22);
            this.TsmiOpenFile.Text = "開く(&O)";
            this.TsmiOpenFile.Click += new System.EventHandler(this.TsmiOpenFile_Click);
            // 
            // TsmiSaveAs
            // 
            this.TsmiSaveAs.Name = "TsmiSaveAs";
            this.TsmiSaveAs.Size = new System.Drawing.Size(180, 22);
            this.TsmiSaveAs.Text = "名前を付けて保存(&A)";
            this.TsmiSaveAs.Click += new System.EventHandler(this.TsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TsmiPrintPic
            // 
            this.TsmiPrintPic.Name = "TsmiPrintPic";
            this.TsmiPrintPic.Size = new System.Drawing.Size(180, 22);
            this.TsmiPrintPic.Text = "印刷(&P)";
            this.TsmiPrintPic.Click += new System.EventHandler(this.TsmiPrintPic_Click);
            // 
            // TsmiFinishApp
            // 
            this.TsmiFinishApp.Name = "TsmiFinishApp";
            this.TsmiFinishApp.Size = new System.Drawing.Size(180, 22);
            this.TsmiFinishApp.Text = "終了(&X)";
            this.TsmiFinishApp.Click += new System.EventHandler(this.TsmiFinishApp_Click);
            // 
            // TsmiEdit
            // 
            this.TsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiClearPic,
            this.TsmiChangeColor,
            this.TsmiThickness,
            this.TsmiShapeMode});
            this.TsmiEdit.Name = "TsmiEdit";
            this.TsmiEdit.Size = new System.Drawing.Size(57, 20);
            this.TsmiEdit.Text = "編集(&E)";
            // 
            // TsmiClearPic
            // 
            this.TsmiClearPic.Name = "TsmiClearPic";
            this.TsmiClearPic.Size = new System.Drawing.Size(137, 22);
            this.TsmiClearPic.Text = "取り消し(&D)";
            this.TsmiClearPic.Click += new System.EventHandler(this.TsmiClearPic_Click);
            // 
            // TsmiChangeColor
            // 
            this.TsmiChangeColor.Name = "TsmiChangeColor";
            this.TsmiChangeColor.Size = new System.Drawing.Size(137, 22);
            this.TsmiChangeColor.Text = "色変更(&C)";
            this.TsmiChangeColor.Click += new System.EventHandler(this.TsmiChangeColor_Click);
            // 
            // TsmiThickness
            // 
            this.TsmiThickness.Name = "TsmiThickness";
            this.TsmiThickness.Size = new System.Drawing.Size(137, 22);
            this.TsmiThickness.Text = "太さ変更(&T)";
            this.TsmiThickness.Click += new System.EventHandler(this.TsmiThickness_Click);
            // 
            // TsmiShapeMode
            // 
            this.TsmiShapeMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiStraightLine,
            this.TsmiSquare,
            this.TsmiCircleMode});
            this.TsmiShapeMode.Name = "TsmiShapeMode";
            this.TsmiShapeMode.Size = new System.Drawing.Size(137, 22);
            this.TsmiShapeMode.Text = "図形モード(&S)";
            // 
            // TsmiStraightLine
            // 
            this.TsmiStraightLine.Name = "TsmiStraightLine";
            this.TsmiStraightLine.Size = new System.Drawing.Size(110, 22);
            this.TsmiStraightLine.Text = "直線";
            this.TsmiStraightLine.Click += new System.EventHandler(this.TsmiStraightLine_Click);
            // 
            // TsmiSquare
            // 
            this.TsmiSquare.Name = "TsmiSquare";
            this.TsmiSquare.Size = new System.Drawing.Size(110, 22);
            this.TsmiSquare.Text = "四角形";
            this.TsmiSquare.Click += new System.EventHandler(this.TsmiSquare_Click);
            // 
            // TsmiCircleMode
            // 
            this.TsmiCircleMode.Name = "TsmiCircleMode";
            this.TsmiCircleMode.Size = new System.Drawing.Size(110, 22);
            this.TsmiCircleMode.Text = "円";
            this.TsmiCircleMode.Click += new System.EventHandler(this.TsmiCircleMode_Click);
            // 
            // TsmiHelp
            // 
            this.TsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiVerInfo});
            this.TsmiHelp.Name = "TsmiHelp";
            this.TsmiHelp.Size = new System.Drawing.Size(65, 20);
            this.TsmiHelp.Text = "ヘルプ(&H)";
            // 
            // TsmiVerInfo
            // 
            this.TsmiVerInfo.Name = "TsmiVerInfo";
            this.TsmiVerInfo.Size = new System.Drawing.Size(158, 22);
            this.TsmiVerInfo.Text = "バージョン情報(&A)";
            // 
            // BtnColorChange
            // 
            this.BtnColorChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnColorChange.Location = new System.Drawing.Point(89, 3);
            this.BtnColorChange.Name = "BtnColorChange";
            this.BtnColorChange.Size = new System.Drawing.Size(80, 32);
            this.BtnColorChange.TabIndex = 3;
            this.BtnColorChange.Text = "色変更";
            this.BtnColorChange.UseVisualStyleBackColor = true;
            this.BtnColorChange.Click += new System.EventHandler(this.BtnColorChange_Click);
            // 
            // BtnThickness
            // 
            this.BtnThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnThickness.Location = new System.Drawing.Point(175, 3);
            this.BtnThickness.Name = "BtnThickness";
            this.BtnThickness.Size = new System.Drawing.Size(80, 32);
            this.BtnThickness.TabIndex = 4;
            this.BtnThickness.Text = "太さ変更";
            this.BtnThickness.UseVisualStyleBackColor = true;
            this.BtnThickness.Click += new System.EventHandler(this.BtnThickness_Click);
            // 
            // BtnShapeMode
            // 
            this.BtnShapeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShapeMode.Location = new System.Drawing.Point(3, 3);
            this.BtnShapeMode.Name = "BtnShapeMode";
            this.BtnShapeMode.Size = new System.Drawing.Size(80, 32);
            this.BtnShapeMode.TabIndex = 5;
            this.BtnShapeMode.Text = "図形モード";
            this.BtnShapeMode.UseVisualStyleBackColor = true;
            this.BtnShapeMode.Click += new System.EventHandler(this.BtnShapeMode_Click);
            // 
            // BtnClearPic
            // 
            this.BtnClearPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearPic.Location = new System.Drawing.Point(261, 3);
            this.BtnClearPic.Name = "BtnClearPic";
            this.BtnClearPic.Size = new System.Drawing.Size(80, 32);
            this.BtnClearPic.TabIndex = 6;
            this.BtnClearPic.Text = "取り消し";
            this.BtnClearPic.UseVisualStyleBackColor = true;
            this.BtnClearPic.Click += new System.EventHandler(this.BtnClearPic_Click);
            // 
            // BtnSavePic
            // 
            this.BtnSavePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSavePic.Location = new System.Drawing.Point(347, 3);
            this.BtnSavePic.Name = "BtnSavePic";
            this.BtnSavePic.Size = new System.Drawing.Size(80, 32);
            this.BtnSavePic.TabIndex = 7;
            this.BtnSavePic.Text = "保存する";
            this.BtnSavePic.UseVisualStyleBackColor = true;
            this.BtnSavePic.Click += new System.EventHandler(this.BtnSavePic_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOpenFile.Location = new System.Drawing.Point(433, 3);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(80, 32);
            this.BtnOpenFile.TabIndex = 8;
            this.BtnOpenFile.Text = "ファイルを開く";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // CdCanvasColor
            // 
            this.CdCanvasColor.AllowFullOpen = false;
            // 
            // FlpToolBtns
            // 
            this.FlpToolBtns.Controls.Add(this.BtnShapeMode);
            this.FlpToolBtns.Controls.Add(this.BtnColorChange);
            this.FlpToolBtns.Controls.Add(this.BtnThickness);
            this.FlpToolBtns.Controls.Add(this.BtnClearPic);
            this.FlpToolBtns.Controls.Add(this.BtnSavePic);
            this.FlpToolBtns.Controls.Add(this.BtnOpenFile);
            this.FlpToolBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlpToolBtns.Location = new System.Drawing.Point(0, 358);
            this.FlpToolBtns.Name = "FlpToolBtns";
            this.FlpToolBtns.Size = new System.Drawing.Size(719, 46);
            this.FlpToolBtns.TabIndex = 9;
            // 
            // GbCanvas
            // 
            this.GbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCanvas.Controls.Add(this.PbCanvas);
            this.GbCanvas.Location = new System.Drawing.Point(0, 24);
            this.GbCanvas.Name = "GbCanvas";
            this.GbCanvas.Size = new System.Drawing.Size(719, 333);
            this.GbCanvas.TabIndex = 10;
            this.GbCanvas.TabStop = false;
            this.GbCanvas.Text = "キャンパス";
            // 
            // PbCanvas
            // 
            this.PbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbCanvas.BackColor = System.Drawing.Color.White;
            this.PbCanvas.Location = new System.Drawing.Point(3, 15);
            this.PbCanvas.Name = "PbCanvas";
            this.PbCanvas.Size = new System.Drawing.Size(716, 312);
            this.PbCanvas.TabIndex = 0;
            this.PbCanvas.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 404);
            this.Controls.Add(this.GbCanvas);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.FlpToolBtns);
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(688, 312);
            this.Name = "MainForm";
            this.Text = "お絵描きツール";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.FlpToolBtns.ResumeLayout(false);
            this.GbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiMenuTool;
        private System.Windows.Forms.ToolStripMenuItem TsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem TsmiVerInfo;
        private System.Windows.Forms.Button BtnColorChange;
        private System.Windows.Forms.Button BtnThickness;
        private System.Windows.Forms.Button BtnShapeMode;
        private System.Windows.Forms.Button BtnClearPic;
        private System.Windows.Forms.Button BtnSavePic;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.ColorDialog CdCanvasColor;
        private System.Windows.Forms.ToolStripMenuItem TsmiNewFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiOpenFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsmiFinishApp;
        private System.Windows.Forms.ToolStripMenuItem TsmiPrintPic;
        private System.Windows.Forms.ToolStripMenuItem TsmiChangeColor;
        private System.Windows.Forms.ToolStripMenuItem TsmiThickness;
        private System.Windows.Forms.ToolStripMenuItem TsmiShapeMode;
        private System.Windows.Forms.ToolStripMenuItem TsmiClearPic;
        private System.Windows.Forms.FlowLayoutPanel FlpToolBtns;
        private System.Windows.Forms.GroupBox GbCanvas;
        private System.Windows.Forms.PictureBox PbCanvas;
        private System.Windows.Forms.ToolStripMenuItem TsmiCircleMode;
        private System.Windows.Forms.ToolStripMenuItem TsmiSquare;
        private System.Windows.Forms.ToolStripMenuItem TsmiStraightLine;
        private System.Windows.Forms.SaveFileDialog SfdCanvasSave;
    }
}

