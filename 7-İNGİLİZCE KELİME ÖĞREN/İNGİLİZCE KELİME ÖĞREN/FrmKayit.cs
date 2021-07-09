using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace İNGİLİZCE_KELİME_ÖĞREN
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
       
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnjoker_Click(object sender, EventArgs e)
        {
            FrmOyun fr = new FrmOyun();
            fr.oyuncu = txtadsoyad.Text;
            fr.Show();
            this.Hide();
        }
    }
}
