using System;
using System.Windows.Forms;

namespace MKWindowFormApp1
{
    public partial class BoldForm2 : Form
    {
        public BoldForm2()
        {
            InitializeComponent();
        }

        #region "クリックイベントハンドラ"

        /// <summary>
        /// フォント太さ変更フォームロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldForm2_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        /// <summary>
        /// キャンセルボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// OKボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TBBold.Text != null && int.Parse(TBBold.Text) > 0)
            {
                Properties.Settings.Default.PEN_BOLD = int.Parse(TBBold.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Settings.Default.ERR_INPUT,
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// テキストボックスでエンターキー押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBBold_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (TBBold.Text != "" && int.TryParse(TBBold.Text, out int inputResult))
                {
                    Properties.Settings.Default.PEN_BOLD = inputResult;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ERR_INPUT,
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}
