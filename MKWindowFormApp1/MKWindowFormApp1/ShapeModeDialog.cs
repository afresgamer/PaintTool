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
    public partial class ShapeModeDialog : Form
    {
        #region "コンストラクタ"

        public ShapeModeDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region "クリックイベントハンドラ"

        private void BtnStraightLine_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = 2;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SHAPE_MODE_INDEX = 0;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
