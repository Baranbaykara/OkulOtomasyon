using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        FrmOgretmenler frm1;
        private void BtnOgretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm1= new FrmOgretmenler();
            frm1.MdiParent = this;
            frm1.Show();


        }   
    }
}
