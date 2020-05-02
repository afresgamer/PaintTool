namespace MKWindowFormApp1
{
    partial class MainForm2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnColorChange = new System.Windows.Forms.Button();
            this.BtnThickness = new System.Windows.Forms.Button();
            this.BtnShapeMode = new System.Windows.Forms.Button();
            this.BtnClearPic = new System.Windows.Forms.Button();
            this.BtnSavePic = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.PbCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFinish = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiShapeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiStraightLine = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClearPic = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiThickness = new System.Windows.Forms.ToolStripMenuItem();
            this.CdCanvasColor = new System.Windows.Forms.ColorDialog();
            this.SfdCanvasSave = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnColorChange);
            this.flowLayoutPanel1.Controls.Add(this.BtnThickness);
            this.flowLayoutPanel1.Controls.Add(this.BtnShapeMode);
            this.flowLayoutPanel1.Controls.Add(this.BtnClearPic);
            this.flowLayoutPanel1.Controls.Add(this.BtnSavePic);
            this.flowLayoutPanel1.Controls.Add(this.BtnOpenFile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 882);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1562, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnColorChange
            // 
            this.BtnColorChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnColorChange.Location = new System.Drawing.Point(3, 3);
            this.BtnColorChange.Name = "BtnColorChange";
            this.BtnColorChange.Size = new System.Drawing.Size(245, 90);
            this.BtnColorChange.TabIndex = 0;
            this.BtnColorChange.Text = "色変更";
            this.BtnColorChange.UseVisualStyleBackColor = true;
            this.BtnColorChange.Click += new System.EventHandler(this.BtnColorChange_Click);
            // 
            // BtnThickness
            // 
            this.BtnThickness.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnThickness.Location = new System.Drawing.Point(254, 3);
            this.BtnThickness.Name = "BtnThickness";
            this.BtnThickness.Size = new System.Drawing.Size(245, 90);
            this.BtnThickness.TabIndex = 1;
            this.BtnThickness.Text = "太さ変更";
            this.BtnThickness.UseVisualStyleBackColor = true;
            this.BtnThickness.Click += new System.EventHandler(this.BtnThickness_Click);
            // 
            // BtnShapeMode
            // 
            this.BtnShapeMode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnShapeMode.Location = new System.Drawing.Point(505, 3);
            this.BtnShapeMode.Name = "BtnShapeMode";
            this.BtnShapeMode.Size = new System.Drawing.Size(245, 90);
            this.BtnShapeMode.TabIndex = 2;
            this.BtnShapeMode.Text = "描画モード";
            this.BtnShapeMode.UseVisualStyleBackColor = true;
            this.BtnShapeMode.Click += new System.EventHandler(this.BtnShapeMode_Click);
            // 
            // BtnClearPic
            // 
            this.BtnClearPic.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClearPic.Location = new System.Drawing.Point(756, 3);
            this.BtnClearPic.Name = "BtnClearPic";
            this.BtnClearPic.Size = new System.Drawing.Size(245, 90);
            this.BtnClearPic.TabIndex = 3;
            this.BtnClearPic.Text = "取り消し";
            this.BtnClearPic.UseVisualStyleBackColor = true;
            this.BtnClearPic.Click += new System.EventHandler(this.BtnClearPic_Click);
            // 
            // BtnSavePic
            // 
            this.BtnSavePic.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSavePic.Location = new System.Drawing.Point(1007, 3);
            this.BtnSavePic.Name = "BtnSavePic";
            this.BtnSavePic.Size = new System.Drawing.Size(245, 90);
            this.BtnSavePic.TabIndex = 4;
            this.BtnSavePic.Text = "保存する";
            this.BtnSavePic.UseVisualStyleBackColor = true;
            this.BtnSavePic.Click += new System.EventHandler(this.BtnSavePic_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOpenFile.Location = new System.Drawing.Point(1258, 3);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(245, 90);
            this.BtnOpenFile.TabIndex = 5;
            this.BtnOpenFile.Text = "ファイルを開く";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // PbCanvas
            // 
            this.PbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbCanvas.Location = new System.Drawing.Point(0, 0);
            this.PbCanvas.Name = "PbCanvas";
            this.PbCanvas.Size = new System.Drawing.Size(1562, 981);
            this.PbCanvas.TabIndex = 2;
            this.PbCanvas.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TsmiEdit,
            this.TsmiDisplay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1562, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmiFile
            // 
            this.TsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNew,
            this.TsmiOpen,
            this.TsmiSave,
            this.TsmiSaveAs,
            this.toolStripSeparator1,
            this.TsmiPrint,
            this.TsmiFinish});
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(82, 24);
            this.TsmiFile.Text = "ファイル(&F)";
            // 
            // TsmiNew
            // 
            this.TsmiNew.Name = "TsmiNew";
            this.TsmiNew.Size = new System.Drawing.Size(221, 26);
            this.TsmiNew.Text = "新規(&N)";
            this.TsmiNew.Click += new System.EventHandler(this.TsmiNewFile_Click);
            // 
            // TsmiOpen
            // 
            this.TsmiOpen.Name = "TsmiOpen";
            this.TsmiOpen.Size = new System.Drawing.Size(221, 26);
            this.TsmiOpen.Text = "開く(&O)";
            this.TsmiOpen.Click += new System.EventHandler(this.TsmiOpenFile_Click);
            // 
            // TsmiSave
            // 
            this.TsmiSave.Name = "TsmiSave";
            this.TsmiSave.Size = new System.Drawing.Size(221, 26);
            this.TsmiSave.Text = "上書き保存(&S)";
            this.TsmiSave.Click += new System.EventHandler(this.BtnSavePic_Click);
            // 
            // TsmiSaveAs
            // 
            this.TsmiSaveAs.Name = "TsmiSaveAs";
            this.TsmiSaveAs.Size = new System.Drawing.Size(221, 26);
            this.TsmiSaveAs.Text = "名前を付けて保存(&A)";
            this.TsmiSaveAs.Click += new System.EventHandler(this.TsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // TsmiPrint
            // 
            this.TsmiPrint.Name = "TsmiPrint";
            this.TsmiPrint.Size = new System.Drawing.Size(221, 26);
            this.TsmiPrint.Text = "印刷(&P)";
            this.TsmiPrint.Click += new System.EventHandler(this.TsmiPrintPic_Click);
            // 
            // TsmiFinish
            // 
            this.TsmiFinish.Name = "TsmiFinish";
            this.TsmiFinish.Size = new System.Drawing.Size(221, 26);
            this.TsmiFinish.Text = "終了(&X)";
            this.TsmiFinish.Click += new System.EventHandler(this.TsmiFinishApp_Click);
            // 
            // TsmiEdit
            // 
            this.TsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.やり直しZToolStripMenuItem,
            this.toolStripSeparator2,
            this.切り取りToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.TsmiEdit.Name = "TsmiEdit";
            this.TsmiEdit.Size = new System.Drawing.Size(71, 24);
            this.TsmiEdit.Text = "編集(&E)";
            // 
            // やり直しZToolStripMenuItem
            // 
            this.やり直しZToolStripMenuItem.Name = "やり直しZToolStripMenuItem";
            this.やり直しZToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.やり直しZToolStripMenuItem.Text = "やり直し(&U)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // 切り取りToolStripMenuItem
            // 
            this.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            this.切り取りToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.切り取りToolStripMenuItem.Text = "切り取り(&T)";
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            // 
            // 貼り付けToolStripMenuItem
            // 
            this.貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem";
            this.貼り付けToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.貼り付けToolStripMenuItem.Text = "貼り付け(&P)";
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.削除DToolStripMenuItem.Text = "削除(&L)";
            // 
            // TsmiDisplay
            // 
            this.TsmiDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiShapeMode,
            this.TsmiChangeColor,
            this.TsmiClearPic,
            this.TsmiThickness});
            this.TsmiDisplay.Name = "TsmiDisplay";
            this.TsmiDisplay.Size = new System.Drawing.Size(72, 24);
            this.TsmiDisplay.Text = "表示(&V)";
            // 
            // TsmiShapeMode
            // 
            this.TsmiShapeMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiStraightLine,
            this.TsmiCircle,
            this.TsmiSquare});
            this.TsmiShapeMode.Name = "TsmiShapeMode";
            this.TsmiShapeMode.Size = new System.Drawing.Size(177, 26);
            this.TsmiShapeMode.Text = "描画モード(&M)";
            // 
            // TsmiStraightLine
            // 
            this.TsmiStraightLine.Checked = true;
            this.TsmiStraightLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TsmiStraightLine.Name = "TsmiStraightLine";
            this.TsmiStraightLine.Size = new System.Drawing.Size(155, 26);
            this.TsmiStraightLine.Text = "直線(&L)";
            this.TsmiStraightLine.Click += new System.EventHandler(this.TsmiStraightLine_Click);
            // 
            // TsmiCircle
            // 
            this.TsmiCircle.Name = "TsmiCircle";
            this.TsmiCircle.Size = new System.Drawing.Size(155, 26);
            this.TsmiCircle.Text = "円(&C)";
            this.TsmiCircle.Click += new System.EventHandler(this.TsmiCircleMode_Click);
            // 
            // TsmiSquare
            // 
            this.TsmiSquare.Name = "TsmiSquare";
            this.TsmiSquare.Size = new System.Drawing.Size(155, 26);
            this.TsmiSquare.Text = "四角形(&S)";
            this.TsmiSquare.Click += new System.EventHandler(this.TsmiSquare_Click);
            // 
            // TsmiChangeColor
            // 
            this.TsmiChangeColor.Name = "TsmiChangeColor";
            this.TsmiChangeColor.Size = new System.Drawing.Size(177, 26);
            this.TsmiChangeColor.Text = "色変更(&C)";
            this.TsmiChangeColor.Click += new System.EventHandler(this.BtnColorChange_Click);
            // 
            // TsmiClearPic
            // 
            this.TsmiClearPic.Name = "TsmiClearPic";
            this.TsmiClearPic.Size = new System.Drawing.Size(177, 26);
            this.TsmiClearPic.Text = "取り消し(&D)";
            this.TsmiClearPic.Click += new System.EventHandler(this.BtnClearPic_Click);
            // 
            // TsmiThickness
            // 
            this.TsmiThickness.Name = "TsmiThickness";
            this.TsmiThickness.Size = new System.Drawing.Size(177, 26);
            this.TsmiThickness.Text = "太さ変更(&B)";
            this.TsmiThickness.Click += new System.EventHandler(this.TsmiThickness_Click);
            // 
            // CdCanvasColor
            // 
            this.CdCanvasColor.AllowFullOpen = false;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 981);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PbCanvas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm2";
            this.Text = "お絵かきツール";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm2_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnColorChange;
        private System.Windows.Forms.Button BtnThickness;
        private System.Windows.Forms.Button BtnShapeMode;
        private System.Windows.Forms.Button BtnClearPic;
        private System.Windows.Forms.Button BtnSavePic;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.PictureBox PbCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiNew;
        private System.Windows.Forms.ToolStripMenuItem TsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem TsmiSave;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem TsmiFinish;
        private System.Windows.Forms.ToolStripMenuItem TsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem やり直しZToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiDisplay;
        private System.Windows.Forms.ToolStripMenuItem TsmiShapeMode;
        private System.Windows.Forms.ToolStripMenuItem TsmiStraightLine;
        private System.Windows.Forms.ToolStripMenuItem TsmiCircle;
        private System.Windows.Forms.ToolStripMenuItem TsmiSquare;
        private System.Windows.Forms.ToolStripMenuItem TsmiChangeColor;
        private System.Windows.Forms.ToolStripMenuItem TsmiClearPic;
        private System.Windows.Forms.ToolStripMenuItem TsmiThickness;
        private System.Windows.Forms.ColorDialog CdCanvasColor;
        private System.Windows.Forms.SaveFileDialog SfdCanvasSave;
    }
}