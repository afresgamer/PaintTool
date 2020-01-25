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
    public partial class BoldForm2 : Form
    {
        public BoldForm2()
        {
            InitializeComponent();
        }

        #region "クリックイベントハンドラ"

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TBBold.Text != null && int.Parse(TBBold.Text) > 0)
            {
                Properties.Settings.Default.PEN_BOLD = int.Parse(TBBold.Text);
            }

            this.Close();
        }

        #endregion
    }
}
