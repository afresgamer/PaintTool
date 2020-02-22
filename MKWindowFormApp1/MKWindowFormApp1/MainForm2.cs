using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MKWindowFormApp1
{
    public partial class MainForm2 : Form,IShapeMode
    {
        #region コンストラクタ
        public MainForm2()
        {
            InitializeComponent();
        }
        #endregion

        #region "private メンバ変数"

        /// <summary>
        /// グラフィック変数
        /// </summary>
        private Graphics m_canvas;
        private Bitmap m_image;

        /// <summary>
        /// 描画モード
        /// </summary>
        private ShapeMode m_shapeMode;

        /// <summary>
        /// 図形モード変更フォームオブジェクト
        /// </summary>
        private ShapeModeDialog2 m_modeDialog;

        /// <summary>
        ///　線の太さ変更フォームオブジェクト
        /// </summary>
        private BoldForm2 m_boldForm;

        #endregion

        #region "イベントハンドラ"

        #region "クリックイベント"

        /// <summary>
        /// 絵の取り消し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearPic_Click(object sender, EventArgs e)
        {
            //画面クリア
            m_image = new Bitmap(PbCanvas.Width, PbCanvas.Height); ;
            m_canvas = null;
            PbCanvas.Image = m_image;
        }

        /// <summary>
        /// 色変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnColorChange_Click(object sender, EventArgs e)
        {
            if (CdCanvasColor.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PEN_COLOR = CdCanvasColor.Color;
            }
        }

        /// <summary>
        /// 図形モードをクリックしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShapeMode_Click(object sender, EventArgs e)
        {
            m_modeDialog = new ShapeModeDialog2();
            if (m_modeDialog.ShowDialog() == DialogResult.OK)
            {
                m_shapeMode = (ShapeMode)Properties.Settings.Default.SHAPE_MODE_INDEX;
            }

            for (int i = 0; i < TsmiShapeMode.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = TsmiShapeMode.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = false;
            }
            //チェックを付ける
            switch (m_shapeMode)
            {
                case ShapeMode.Circle:
                    TsmiCircle.Checked = true;
                    break;
                case ShapeMode.Square:
                    TsmiSquare.Checked = true;
                    break;
                case ShapeMode.StraightLine:
                    TsmiStraightLine.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// 太さ変更のとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnThickness_Click(object sender, EventArgs e)
        {
            m_boldForm = new BoldForm2();
            m_boldForm.ShowDialog();
        }

        /// <summary>
        /// 保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSavePic_Click(object sender, EventArgs e)
        {
            PbCanvas.Image = m_image;

            SfdCanvasSave = new SaveFileDialog
            {
                Filter = "pngファイル(*.png)|(*.png)|bmpファイル(*.bmp)|(*.bmp)|jpgファイル(*.jpg)|(*.jpg)",
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "保存先のファイルを選択してください",
                RestoreDirectory = true
            };

            if (SfdCanvasSave.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(SfdCanvasSave.FileName);
                switch (extension)
                {
                    case ".png":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Png);
                        break;
                    case ".bmp":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Jpeg);
                        break;
                    default:
                        break;
                }

                this.Text = Path.GetFileName(SfdCanvasSave.FileName) + " " + Properties.Settings.Default.APP_NAME;
                Properties.Settings.Default.FILE_PATH = SfdCanvasSave.FileName;
            }
        }

        /// <summary>
        /// ファイルを開くボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "pngファイル(*.png)|*.png|bmpファイル(*.bmp)|*.bmp|jpgファイル(*.jpg)|*.jpg",
                FilterIndex = 0,
                Title = "画像ファイルを選択してください",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                m_image = ImageFileOpen(ofd.FileName);
                PbCanvas.Image = m_image;
                this.ResetText();
                Text = Path.GetFileName(ofd.FileName) + " - " + Properties.Settings.Default.APP_NAME;
                Properties.Settings.Default.FILE_PATH = ofd.FileName;
            }
        }
        #endregion

        #region "メニューバーのメソッド"

        /// <summary>
        /// 終了(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiFinishApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 絵の取り消し(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiClearPic_Click(object sender, EventArgs e)
        {
            //画面クリア
            m_canvas = null;
            m_image = null;
            PbCanvas.Image = null;
        }

        /// <summary>
        /// 画像の新規作成(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiNewFile_Click(object sender, EventArgs e)
        {
            m_image = new Bitmap(PbCanvas.Width, PbCanvas.Height);
            PbCanvas.Image = m_image;
            this.Text = Properties.Settings.Default.FILE_PATH;
            Properties.Settings.Default.FILE_PATH = null;
        }

        /// <summary>
        /// ファイルを開く(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "pngファイル(*.png)|*.png|bmpファイル(*.bmp)|*.bmp|jpgファイル(*.jpg)|*.jpg",
                FilterIndex = 0,
                Title = "画像ファイルを選択してください",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                m_image = ImageFileOpen(ofd.FileName);
                PbCanvas.Image = m_image;
                this.ResetText();
                this.Text = Path.GetFileName(ofd.FileName) + " - " + Properties.Settings.Default.APP_NAME;
                Properties.Settings.Default.FILE_PATH = ofd.FileName;
            }
        }

        /// <summary>
        /// 印刷(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPrintPic_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintDialog dialog = new PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //PrintPageイベントハンドラ（印刷出力処理）
            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
            //デフォルト設定
            pd.DefaultPageSettings.Landscape = true; //横向き
            //PrintDocumentを指定
            dialog.Document = pd;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //OKがクリックされた時は印刷する
                ppd.Document = pd;
                if (ppd.ShowDialog() == DialogResult.OK)
                {
                    pd.Print(); //印刷
                }
            }
        }

        /// <summary>
        /// 名前を付けて保存(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiSaveAs_Click(object sender, EventArgs e)
        {
            PbCanvas.Image = m_image;

            SfdCanvasSave = new SaveFileDialog
            {
                Filter = "pngファイル(*.png)|(*.png)|bmpファイル(*.bmp)|(*.bmp)|jpgファイル(*.jpg)|(*.jpg)",
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "保存先のファイルを選択してください",
                RestoreDirectory = true
            };

            if (SfdCanvasSave.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(SfdCanvasSave.FileName);
                switch (extension)
                {
                    case ".png":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Png);
                        break;
                    case ".bmp":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        PbCanvas.Image.Save(SfdCanvasSave.FileName, ImageFormat.Jpeg);
                        break;
                    default:
                        break;
                }

                this.Text = Path.GetFileName(SfdCanvasSave.FileName) + " " + Properties.Settings.Default.APP_NAME;
                Properties.Settings.Default.FILE_PATH = SfdCanvasSave.FileName;
            }
        }

        /// <summary>
        /// 色の変更(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiChangeColor_Click(object sender, EventArgs e)
        {
            if (CdCanvasColor.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PEN_COLOR = CdCanvasColor.Color;
            }
        }

        /// <summary>
        /// 線の太さ(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiThickness_Click(object sender, EventArgs e)
        {
            m_boldForm = new BoldForm2();
            m_boldForm.ShowDialog();
        }

        /// <summary>
        /// 直線モード(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiStraightLine_Click(object sender, EventArgs e)
        {
            m_shapeMode = ShapeMode.StraightLine;
            for (int i = 0; i < TsmiShapeMode.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = TsmiShapeMode.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = false;
            }
            TsmiStraightLine.Checked = true;
        }

        /// <summary>
        /// 四角形モード(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiSquare_Click(object sender, EventArgs e)
        {
            m_shapeMode = ShapeMode.Square;
            for (int i = 0; i < TsmiShapeMode.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = TsmiShapeMode.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = false;
            }
            TsmiSquare.Checked = true;
        }

        /// <summary>
        /// 円モード(メニュー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiCircleMode_Click(object sender, EventArgs e)
        {
            m_shapeMode = ShapeMode.Circle;
            for (int i = 0; i < TsmiShapeMode.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = TsmiShapeMode.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = false;
            }
            TsmiCircle.Checked = true;
        }

        #endregion

        #region "クリック以外のイベント"

        /// <summary>
        /// 印刷時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = m_image;

            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            //次のページがないことを通知する
            e.HasMorePages = false;

            image.Dispose();
        }

        /// <summary>
        /// 図形モードの閉じるときのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShapeModeDialog2 modeDialog = (ShapeModeDialog2)sender;
            m_modeDialog = modeDialog;

            m_shapeMode = (ShapeMode)Properties.Settings.Default.SHAPE_MODE_INDEX;

            //初期化
            for (int i = 0; i < TsmiShapeMode.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = TsmiShapeMode.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = false;
            }
            //チェックを付ける
            switch (m_shapeMode)
            {
                case ShapeMode.Circle:
                    TsmiCircle.Checked = true;
                    break;
                case ShapeMode.Square:
                    TsmiSquare.Checked = true;
                    break;
                case ShapeMode.StraightLine:
                    TsmiStraightLine.Checked = true;
                    break;
            }

        }

        /// <summary>
        /// 最初にクリックダウンしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //お絵描き始め
            Properties.Settings.Default.MOUSE_FLAG = true;
            //最初の位置を取得
            Properties.Settings.Default.PREV_POINT = e.Location;
        }

        /// <summary>
        /// クリック終わったとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (m_shapeMode)
            {
                case ShapeMode.Square:
                    DrawSquare(Properties.Settings.Default.PREV_POINT, e.Location);
                    break;
                case ShapeMode.Circle:
                    DrawCircle(e);
                    break;
                default:
                    break;
            }

            //お絵描き終了
            Properties.Settings.Default.MOUSE_FLAG = false;
        }

        /// <summary>
        /// クリック中に動かしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.MOUSE_FLAG)
            {
                switch (m_shapeMode)
                {
                    case ShapeMode.StraightLine:
                        DrawStraightLine(e);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 画面がロードされたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //リサイズ出来ないようにする
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            //ペンの色の初期化
            Properties.Settings.Default.PEN_COLOR = Color.Black;
            m_shapeMode = ShapeMode.StraightLine;
            Properties.Settings.Default.PEN_BOLD = 2;
            m_image = new Bitmap(PbCanvas.Width, PbCanvas.Height);
            TsmiStraightLine.Checked = true;

            //イベントハンドラ登録
            PbCanvas.MouseDown += new MouseEventHandler(PbCanvas_MouseDown);
            PbCanvas.MouseUp += new MouseEventHandler(PbCanvas_MouseUp);
            PbCanvas.MouseMove += new MouseEventHandler(PbCanvas_MouseMove);

            //ショートカット設定
            TsmiNew.ShortcutKeys = Keys.Control | Keys.N;
            TsmiOpen.ShortcutKeys = Keys.Control | Keys.O;
            TsmiSave.ShortcutKeys = Keys.Control | Keys.S;
            TsmiSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            TsmiPrint.ShortcutKeys = Keys.Control | Keys.P;
            TsmiFinish.ShortcutKeys = Keys.Control | Keys.F;
        }

        /// <summary>
        /// 画面リサイズ時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm2_Resize(object sender, EventArgs e)
        {
            //描画サイズを再設定 
            m_image = new Bitmap(PbCanvas.Width, PbCanvas.Height);
        }

        #endregion

        #endregion

        #region "public メゾット"


        #endregion

        #region "private メゾット"

        /// <summary>
        /// セッター
        /// </summary>
        /// <param name="shapeMode"></param>
        void IShapeMode.SetShapeMode(ShapeMode shapeMode)
        {
            m_shapeMode = shapeMode;
        }

        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        ShapeMode IShapeMode.GetShapeMode()
        {
            return m_shapeMode;
        }

        /// <summary>
        /// ファイルパスを指定して画像ファイルを開く
        /// </summary>
        /// <param name="fileName">画像ファイルのファイルパスを指定します。</param>
        /// <returns>生成したBitmapクラスオブジェクト</returns>
        private Bitmap ImageFileOpen(string fileName)
        {
            try
            {
                // 指定したファイルが存在するか？確認
                if (File.Exists(fileName) == false) return null;
                // 拡張子の確認
                var ext = Path.GetExtension(fileName).ToLower();
                // ファイルの拡張子が対応しているファイルかどうか調べる
                if ((ext != ".bmp") && (ext != ".jpg") && (ext != ".png"))
                {
                    return null;
                }
                Bitmap bmp;
                // ファイルストリームでファイルを開く
                using (var fs = new System.IO.FileStream(
                    fileName,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.ReadWrite))
                {
                    bmp = new Bitmap(fs);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// ポイントの絶対値を取得
        /// </summary>
        /// <param name="start">始まりのポイント</param>
        /// <param name="end">終わりのポイント</param>
        /// <returns>ポイントの絶対値</returns>
        private int GetLength(int start, int end)
        {
            if (end == 0) return 0;
            return Math.Abs(end - start);
        }


        /// <summary>
        /// 四角形の描画
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void DrawSquare(Point start, Point end)
        {
            Pen pen = new Pen(Properties.Settings.Default.PEN_COLOR, Properties.Settings.Default.PEN_BOLD);
            m_canvas = Graphics.FromImage(m_image);

            // 開始位置と終了位置によって描画位置を修正
            // 領域を描画
            if(start.X < end.X && start.Y > end.Y)
            {
                m_canvas.DrawRectangle(pen, start.X, end.Y, GetLength(start.X, end.X), GetLength(start.Y, end.Y));
            }
            else if(start.X > end.X && start.Y > end.Y)
            {
                m_canvas.DrawRectangle(pen, end.X, end.Y, GetLength(start.X, end.X), GetLength(start.Y, end.Y));
            }
            else if(start.X > end.X && start.Y < end.Y)
            {
                m_canvas.DrawRectangle(pen, end.X, start.Y, GetLength(start.X, end.X), GetLength(start.Y, end.Y));
            }
            else
            {
                m_canvas.DrawRectangle(pen, start.X, start.Y, GetLength(start.X, end.X), GetLength(start.Y, end.Y));
            }

            pen.Dispose();
            PbCanvas.Image = m_image;
        }

        /// <summary>
        /// 直線の描画
        /// </summary>
        /// <param name="args">マウスイベントハンドラ</param>
        private void DrawStraightLine(MouseEventArgs args)
        {
            //書くための処理
            Pen pen = new Pen(Properties.Settings.Default.PEN_COLOR, Properties.Settings.Default.PEN_BOLD);
            m_canvas = Graphics.FromImage(m_image);
            m_canvas.DrawLine(pen, Properties.Settings.Default.PREV_POINT.X
                , Properties.Settings.Default.PREV_POINT.Y, args.X, args.Y);
            Properties.Settings.Default.PREV_POINT = args.Location;
            pen.Dispose();
            PbCanvas.Image = m_image;
        }

        /// <summary>
        /// 円の描画
        /// </summary>
        /// <param name="args">マウスのイベントハンドラ</param>
        private void DrawCircle(MouseEventArgs args)
        {
            Pen pen = new Pen(Properties.Settings.Default.PEN_COLOR, Properties.Settings.Default.PEN_BOLD);
            m_canvas = Graphics.FromImage(m_image);

            Point prevPoint = Properties.Settings.Default.PREV_POINT;

            // 開始位置と終了位置によって描画位置を修正
            // 領域を描画
            if (prevPoint.X < args.X && prevPoint.Y > args.Y)
            {
                m_canvas.DrawEllipse(pen, prevPoint.X, args.Y,
                    GetLength(prevPoint.X, args.X), GetLength(prevPoint.Y, args.Y));
            }
            else if (prevPoint.X > args.X && prevPoint.Y > args.Y)
            {
                m_canvas.DrawEllipse(pen, args.X, args.Y,
                    GetLength(prevPoint.X, args.X), GetLength(prevPoint.Y, args.Y));
            }
            else if (prevPoint.X > args.X && prevPoint.Y < args.Y)
            {
                m_canvas.DrawEllipse(pen, args.X, prevPoint.Y,
                    GetLength(prevPoint.X, args.X), GetLength(prevPoint.Y, args.Y));
            }
            else
            {
                m_canvas.DrawEllipse(pen, prevPoint.X, prevPoint.Y, 
                    GetLength(prevPoint.X, args.X), GetLength(prevPoint.Y, args.Y));
            }

            Properties.Settings.Default.PREV_POINT = args.Location;
            pen.Dispose();
            PbCanvas.Image = m_image;
        }
        #endregion
    }
}
