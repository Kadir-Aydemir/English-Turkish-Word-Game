using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace İNGİLİZCE_KELİME_ÖĞREN
{
    public partial class FrmSonuclar : Form
    {
        public FrmSonuclar()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\msı\Desktop\dbSozluk.accdb");
       void doldur()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ADSOYAD,SKOR from oyuncular", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmSonuclar_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete ID,ADSOYAD,SKOR FROM oyuncular", baglanti);                       
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("TÜM KAYITLAR BAŞARIYLA SİLİNDİ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            doldur();
        }
    }
}
