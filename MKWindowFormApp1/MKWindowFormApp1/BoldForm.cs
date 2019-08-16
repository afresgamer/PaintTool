using System;
using System.Windows.Forms;

namespace MKWindowFormApp1
{
    public partial class BoldForm : Form
    {
        #region "コンストラクタ"

        public BoldForm()
        {
            InitializeComponent();
        }

        #endregion

        #region "クリックイベントハンドラ"

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(TBBold.Text != null && int.Parse(TBBold.Text) > 0)
            {
                Properties.Settings.Default.PEN_BOLD = int.Parse(TBBold.Text);
            }

            this.Close();
        }

        #endregion
    }
}
