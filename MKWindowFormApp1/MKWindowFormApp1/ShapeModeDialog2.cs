using System;
using System.Windows.Forms;

namespace MKWindowFormApp1
{
    public partial class ShapeModeDialog2 : Form
    {
        public ShapeModeDialog2()
        {
            InitializeComponent();
        }

        #region "クリックイベントハンドラ"
        
        /// <summary>
        /// 描画モード変更フォームロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShapeModeDialog2_Load(object sender, EventArgs e)
        {
            //リサイズ出来ないようにする
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// 直線モード変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStraightLine_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = (int)ShapeMode.StraightLine;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 四角形描画モード変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = (int)ShapeMode.Square;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 円描画モード変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCircle_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = (int)ShapeMode.Circle;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 消しゴムモード変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = (int)ShapeMode.Erase;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
