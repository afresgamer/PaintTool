using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Properties.Settings.Default.SHAPE_MODE_INDEX = 1;
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
            Properties.Settings.Default.SHAPE_MODE_INDEX = 2;
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
            Properties.Settings.Default.SHAPE_MODE_INDEX = 0;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}
