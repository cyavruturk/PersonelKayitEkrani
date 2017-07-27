namespace OOP_odev2
{
    partial class PersonelForm2
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbdepartman = new System.Windows.Forms.ComboBox();
            this.dtpisegiris = new System.Windows.Forms.DateTimePicker();
            this.dtpdogumtarih = new System.Windows.Forms.DateTimePicker();
            this.btnkaldir = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.pcresim = new System.Windows.Forms.PictureBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtunvan = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.lbldepartman = new System.Windows.Forms.Label();
            this.lblunvan = new System.Windows.Forms.Label();
            this.lblisegiristarihi = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbldogumtarihi = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lstlistele = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcresim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(1016, 361);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(88, 41);
            this.btnkaydet.TabIndex = 58;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(215, 228);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(129, 20);
            this.msktelefon.TabIndex = 57;
            // 
            // cmbdepartman
            // 
            this.cmbdepartman.FormattingEnabled = true;
            this.cmbdepartman.Items.AddRange(new object[] {
            "Pazarlama",
            "Muhasebe",
            "İnternet Arıza",
            "Operatör",
            "Müşteri Hizmetleri",
            "Satış",
            "Planlama",
            "CRM"});
            this.cmbdepartman.Location = new System.Drawing.Point(688, 135);
            this.cmbdepartman.Name = "cmbdepartman";
            this.cmbdepartman.Size = new System.Drawing.Size(121, 21);
            this.cmbdepartman.TabIndex = 56;
            // 
            // dtpisegiris
            // 
            this.dtpisegiris.Location = new System.Drawing.Point(688, 40);
            this.dtpisegiris.Name = "dtpisegiris";
            this.dtpisegiris.Size = new System.Drawing.Size(200, 20);
            this.dtpisegiris.TabIndex = 55;
            // 
            // dtpdogumtarih
            // 
            this.dtpdogumtarih.Location = new System.Drawing.Point(215, 180);
            this.dtpdogumtarih.Name = "dtpdogumtarih";
            this.dtpdogumtarih.Size = new System.Drawing.Size(200, 20);
            this.dtpdogumtarih.TabIndex = 54;
            // 
            // btnkaldir
            // 
            this.btnkaldir.Location = new System.Drawing.Point(837, 237);
            this.btnkaldir.Name = "btnkaldir";
            this.btnkaldir.Size = new System.Drawing.Size(88, 42);
            this.btnkaldir.TabIndex = 52;
            this.btnkaldir.Text = "Resmi Kaldır";
            this.btnkaldir.UseVisualStyleBackColor = true;
            this.btnkaldir.Click += new System.EventHandler(this.btnkaldir_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(837, 192);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(88, 39);
            this.btnekle.TabIndex = 51;
            this.btnekle.Text = "Resim Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // pcresim
            // 
            this.pcresim.Location = new System.Drawing.Point(688, 192);
            this.pcresim.Name = "pcresim";
            this.pcresim.Size = new System.Drawing.Size(100, 126);
            this.pcresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcresim.TabIndex = 50;
            this.pcresim.TabStop = false;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(215, 328);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(129, 64);
            this.txtadres.TabIndex = 48;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(215, 274);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(129, 29);
            this.txtemail.TabIndex = 47;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(215, 128);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(129, 29);
            this.txtsoyad.TabIndex = 49;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(215, 82);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(129, 29);
            this.txtad.TabIndex = 46;
            // 
            // txtunvan
            // 
            this.txtunvan.Location = new System.Drawing.Point(688, 82);
            this.txtunvan.Multiline = true;
            this.txtunvan.Name = "txtunvan";
            this.txtunvan.Size = new System.Drawing.Size(129, 29);
            this.txtunvan.TabIndex = 45;
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(215, 38);
            this.txttcno.MaxLength = 11;
            this.txttcno.Multiline = true;
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(129, 29);
            this.txttcno.TabIndex = 44;
            // 
            // lbldepartman
            // 
            this.lbldepartman.AutoSize = true;
            this.lbldepartman.Location = new System.Drawing.Point(610, 134);
            this.lbldepartman.Name = "lbldepartman";
            this.lbldepartman.Size = new System.Drawing.Size(59, 13);
            this.lbldepartman.TabIndex = 42;
            this.lbldepartman.Text = "Departman";
            // 
            // lblunvan
            // 
            this.lblunvan.AutoSize = true;
            this.lblunvan.Location = new System.Drawing.Point(610, 85);
            this.lblunvan.Name = "lblunvan";
            this.lblunvan.Size = new System.Drawing.Size(39, 13);
            this.lblunvan.TabIndex = 41;
            this.lblunvan.Text = "Unvan";
            // 
            // lblisegiristarihi
            // 
            this.lblisegiristarihi.AutoSize = true;
            this.lblisegiristarihi.Location = new System.Drawing.Point(610, 46);
            this.lblisegiristarihi.Name = "lblisegiristarihi";
            this.lblisegiristarihi.Size = new System.Drawing.Size(73, 13);
            this.lblisegiristarihi.TabIndex = 40;
            this.lblisegiristarihi.Text = "İşe Giriş Tarihi";
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Location = new System.Drawing.Point(136, 344);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(34, 13);
            this.lbladres.TabIndex = 39;
            this.lbladres.Text = "Adres";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(135, 290);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 38;
            this.lblemail.Text = "Email";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(135, 231);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(43, 13);
            this.lbltelefon.TabIndex = 37;
            this.lbltelefon.Text = "Telefon";
            // 
            // lbldogumtarihi
            // 
            this.lbldogumtarihi.AutoSize = true;
            this.lbldogumtarihi.Location = new System.Drawing.Point(133, 180);
            this.lbldogumtarihi.Name = "lbldogumtarihi";
            this.lbldogumtarihi.Size = new System.Drawing.Size(70, 13);
            this.lbldogumtarihi.TabIndex = 36;
            this.lbldogumtarihi.Text = "Doğum Tarihi";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(133, 131);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad.TabIndex = 35;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(133, 85);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(20, 13);
            this.lblad.TabIndex = 43;
            this.lblad.Text = "Ad";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(133, 46);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(67, 13);
            this.lbltc.TabIndex = 34;
            this.lbltc.Text = "Tc Kimlik No";
            // 
            // lstlistele
            // 
            this.lstlistele.FormattingEnabled = true;
            this.lstlistele.Location = new System.Drawing.Point(136, 437);
            this.lstlistele.Name = "lstlistele";
            this.lstlistele.Size = new System.Drawing.Size(968, 277);
            this.lstlistele.TabIndex = 59;
            this.lstlistele.SelectedIndexChanged += new System.EventHandler(this.lstlistele_SelectedIndexChanged);
            this.lstlistele.DoubleClick += new System.EventHandler(this.lstlistele_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PersonelForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 781);
            this.Controls.Add(this.lstlistele);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.cmbdepartman);
            this.Controls.Add(this.dtpisegiris);
            this.Controls.Add(this.dtpdogumtarih);
            this.Controls.Add(this.btnkaldir);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.pcresim);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtunvan);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.lbldepartman);
            this.Controls.Add(this.lblunvan);
            this.Controls.Add(this.lblisegiristarihi);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lbldogumtarihi);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lbltc);
            this.Name = "PersonelForm2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        internal System.Windows.Forms.ComboBox cmbdepartman;
        internal System.Windows.Forms.DateTimePicker dtpisegiris;
        internal System.Windows.Forms.DateTimePicker dtpdogumtarih;
        internal System.Windows.Forms.Button btnkaldir;
        internal System.Windows.Forms.Button btnekle;
        internal System.Windows.Forms.PictureBox pcresim;
        internal System.Windows.Forms.TextBox txtadres;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.TextBox txtsoyad;
        internal System.Windows.Forms.TextBox txtad;
        internal System.Windows.Forms.TextBox txtunvan;
        internal System.Windows.Forms.TextBox txttcno;
        internal System.Windows.Forms.Label lbldepartman;
        internal System.Windows.Forms.Label lblunvan;
        internal System.Windows.Forms.Label lblisegiristarihi;
        internal System.Windows.Forms.Label lbladres;
        internal System.Windows.Forms.Label lblemail;
        internal System.Windows.Forms.Label lbltelefon;
        internal System.Windows.Forms.Label lbldogumtarihi;
        internal System.Windows.Forms.Label lblsoyad;
        internal System.Windows.Forms.Label lblad;
        internal System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.ListBox lstlistele;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

