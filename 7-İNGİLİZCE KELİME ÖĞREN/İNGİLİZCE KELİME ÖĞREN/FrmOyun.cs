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
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;
        public string oyuncu;
        void getiring()
        {
            lblcevap.Visible = false;
            int sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtingilizce.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text = lblcevap.Text.ToLower();
            }
            baglanti.Close();
        }
        void getirturk()
        {
            lblcevap.Visible = false;
            int sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtturkce.Text = dr[2].ToString();
                lblcevap.Text = dr[1].ToString();
                lblcevap.Text = lblcevap.Text.ToLower();
            }
            baglanti.Close();
        }
        void kaydet()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into oyuncular (ADSOYAD,SKOR) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", lbloyuncu.Text);
            komut.Parameters.AddWithValue("@p2", lblkelime.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbloyuncu.Text = oyuncu.ToString();
        }
        private void txtturkce_TextChanged(object sender, EventArgs e)
        {
            if (txtturkce.Text == lblcevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                getiring();
                txtturkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                txtingilizce.Enabled = false;
                txtturkce.Enabled = false;
                btnjoker.Enabled = false;
                timer1.Stop();
                richTextBox1.Visible = true;
                richTextBox1.Text = "  BİLİNEN KELİME SAYISI " + lblkelime.Text + "\n  TEBRİKLER "+lbloyuncu.Text;
                btnkaydetvegec.Visible = true;
                btnkaydetvebitir.Visible = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            btnbaslaing.Visible = true;
            btnbaslaturk.Visible = false;
            cbxturk.Checked = false;
            label2.Location = new Point(314, 233); 
            label1.Location = new Point(281, 184);
            txtingilizce.Location = new Point(407, 183);
            txtturkce.Location = new Point(407, 231);
        }

        private void cbxturk_OnChange(object sender, EventArgs e)
        {
            btnbaslaing.Visible = false;
            btnbaslaturk.Visible = true;
            cbxing.Checked = false;
            label2.Location = new Point(314, 183);
            label1.Location = new Point(281, 233);
            txtingilizce.Location = new Point(407, 231);
            txtturkce.Location = new Point(407, 183);
        }

        private void btnbaslaing_Click(object sender, EventArgs e)
        {
            txtingilizce.Enabled = false;
            btnbaslaing.Visible = false;
            cbxturk.Enabled = false;
            cbxing.Enabled = false;
            btnjoker.Enabled = true;
            getiring();
            timer1.Start();
        }
        int sayac = 0;
        private void btnjoker_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                lblcevap.Visible = true;
                pictureBox3.Visible = false;
                pictureBox33.Visible = true;
                btnjoker.Text = "JOKER(2)";
            }
            if (sayac == 2)
            {
                lblcevap.Visible = true;
                pictureBox2.Visible = false;
                pictureBox22.Visible = true;
                btnjoker.Text = "JOKER(1)";
            }
            if (sayac == 3)
            {
                lblcevap.Visible = true;
                pictureBox1.Visible = false;
                pictureBox11.Visible = true;
                btnjoker.Enabled = false;
                btnjoker.Text = "JOKER(0)";
            }
        }

        private void btnbaslaturk_Click(object sender, EventArgs e)
        {
            txtturkce.Enabled = false;
            btnbaslaturk.Visible = false;
            cbxturk.Enabled = false;
            cbxing.Enabled = false;
            btnjoker.Enabled = true;
            getirturk();
            timer1.Start();
        }

        private void txtingilizce_TextChanged(object sender, EventArgs e)
        {
            if (txtingilizce.Text == lblcevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                getirturk();
                txtingilizce.Clear();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            FrmKayit fr = new FrmKayit();
            fr.Show();
            this.Close();            
        }

        private void btnkaydetvebitir_Click(object sender, EventArgs e)
        {
            kaydet();
            FrmSonuclar fr = new FrmSonuclar();
            fr.Show();
            btnkaydetvebitir.Visible = false;
            btnkaydetvegec.Visible = false;
            btnyenioyun.Visible = true;
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            FrmSonuclar fr = new FrmSonuclar();
            fr.Show();
        }

        private void btnyenioyun_Click(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete ID,ADSOYAD,SKOR FROM oyuncular", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            fr.Show();           
            this.Close();
        }
    }
}
