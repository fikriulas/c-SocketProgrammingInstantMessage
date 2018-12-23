namespace SocketProgrammingClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listGelenMesaj = new System.Windows.Forms.ListBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnBaglan = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnMesaj = new DevExpress.XtraEditors.SimpleButton();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.btnResim = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagli = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagliDegil = new DevExpress.XtraEditors.SimpleButton();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblBagliDegil = new System.Windows.Forms.Label();
            this.lblBagli = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // listGelenMesaj
            // 
            this.listGelenMesaj.FormattingEnabled = true;
            this.listGelenMesaj.Location = new System.Drawing.Point(12, 43);
            this.listGelenMesaj.Name = "listGelenMesaj";
            this.listGelenMesaj.Size = new System.Drawing.Size(272, 173);
            this.listGelenMesaj.TabIndex = 0;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(12, 222);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(271, 61);
            this.txtMesaj.TabIndex = 1;
            // 
            // btnBaglan
            // 
            this.btnBaglan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.ImageOptions.Image")));
            this.btnBaglan.Location = new System.Drawing.Point(573, 120);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(98, 36);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(458, 94);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(212, 20);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.Validating += new System.ComponentModel.CancelEventHandler(this.txtKullaniciAdi_Validating);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(339, 97);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(113, 13);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adınızı Giriniz:";
            // 
            // btnMesaj
            // 
            this.btnMesaj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMesaj.ImageOptions.Image")));
            this.btnMesaj.Location = new System.Drawing.Point(177, 292);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(106, 35);
            this.btnMesaj.TabIndex = 5;
            this.btnMesaj.Text = "Gönder";
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // picResim
            // 
            this.picResim.Location = new System.Drawing.Point(344, 164);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(328, 168);
            this.picResim.TabIndex = 6;
            this.picResim.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResim.ImageOptions.Image")));
            this.btnResim.Location = new System.Drawing.Point(445, 120);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(122, 38);
            this.btnResim.TabIndex = 7;
            this.btnResim.Text = "Resim Gönder";
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnBagli
            // 
            this.btnBagli.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagli.Appearance.Options.UseFont = true;
            this.btnBagli.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBagli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBagli.ImageOptions.Image")));
            this.btnBagli.Location = new System.Drawing.Point(12, 5);
            this.btnBagli.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnBagli.Name = "btnBagli";
            this.btnBagli.Size = new System.Drawing.Size(38, 32);
            this.btnBagli.TabIndex = 8;
            this.btnBagli.Click += new System.EventHandler(this.btnBagli_Click);
            // 
            // btnBagliDegil
            // 
            this.btnBagliDegil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBagliDegil.ImageOptions.Image")));
            this.btnBagliDegil.Location = new System.Drawing.Point(12, 3);
            this.btnBagliDegil.Name = "btnBagliDegil";
            this.btnBagliDegil.Size = new System.Drawing.Size(41, 34);
            this.btnBagliDegil.TabIndex = 9;
            this.btnBagliDegil.Click += new System.EventHandler(this.btnBagliDegil_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(459, 68);
            this.txtPort.Name = "txtPort";
            this.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPort.Size = new System.Drawing.Size(212, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtPort_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port Girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IP Girin:";
            // 
            // txtip
            // 
            this.txtip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtip.Cursor = System.Windows.Forms.Cursors.No;
            this.txtip.Location = new System.Drawing.Point(459, 42);
            this.txtip.Name = "txtip";
            this.txtip.ReadOnly = true;
            this.txtip.Size = new System.Drawing.Size(212, 13);
            this.txtip.TabIndex = 12;
            this.txtip.Text = "127.0.0.1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblBagliDegil
            // 
            this.lblBagliDegil.AutoSize = true;
            this.lblBagliDegil.Location = new System.Drawing.Point(59, 13);
            this.lblBagliDegil.Name = "lblBagliDegil";
            this.lblBagliDegil.Size = new System.Drawing.Size(80, 13);
            this.lblBagliDegil.TabIndex = 14;
            this.lblBagliDegil.Text = "Bağlı Değilsiniz!";
            // 
            // lblBagli
            // 
            this.lblBagli.AutoSize = true;
            this.lblBagli.Location = new System.Drawing.Point(59, 13);
            this.lblBagli.Name = "lblBagli";
            this.lblBagli.Size = new System.Drawing.Size(87, 13);
            this.lblBagli.TabIndex = 15;
            this.lblBagli.Text = "Bağlantı Kuruldu!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 352);
            this.Controls.Add(this.lblBagli);
            this.Controls.Add(this.lblBagliDegil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnBagliDegil);
            this.Controls.Add(this.btnBagli);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.picResim);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.listGelenMesaj);
            this.Name = "Form1";
            this.Text = "Anlık Mesajlaş";
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGelenMesaj;
        private System.Windows.Forms.TextBox txtMesaj;
        private DevExpress.XtraEditors.SimpleButton btnBaglan;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnMesaj;
        private System.Windows.Forms.PictureBox picResim;
        private DevExpress.XtraEditors.SimpleButton btnResim;
        private DevExpress.XtraEditors.SimpleButton btnBagli;
        private DevExpress.XtraEditors.SimpleButton btnBagliDegil;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblBagliDegil;
        private System.Windows.Forms.Label lblBagli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

