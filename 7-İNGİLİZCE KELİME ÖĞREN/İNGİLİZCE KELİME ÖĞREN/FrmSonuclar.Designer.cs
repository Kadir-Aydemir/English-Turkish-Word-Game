
namespace İNGİLİZCE_KELİME_ÖĞREN
{
    partial class FrmSonuclar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSonuclar));
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Location = new System.Drawing.Point(411, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 32);
            this.btnclose.TabIndex = 11;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(440, 447);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnsifirla
            // 
            this.btnsifirla.BackColor = System.Drawing.Color.Transparent;
            this.btnsifirla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifirla.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifirla.ForeColor = System.Drawing.Color.Red;
            this.btnsifirla.Image = ((System.Drawing.Image)(resources.GetObject("btnsifirla.Image")));
            this.btnsifirla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsifirla.Location = new System.Drawing.Point(118, 496);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(203, 29);
            this.btnsifirla.TabIndex = 44;
            this.btnsifirla.Text = "VERİLERİ SIFIRLA";
            this.btnsifirla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsifirla.UseVisualStyleBackColor = false;
            this.btnsifirla.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // FrmSonuclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 537);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmSonuclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSonuclar";
            this.Load += new System.EventHandler(this.FrmSonuclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsifirla;
    }
}