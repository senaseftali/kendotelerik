namespace Ismatik
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgrwList = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rchbHepsiBurada = new Telerik.WinControls.UI.RadCheckBox();
            this.rchbN11 = new Telerik.WinControls.UI.RadCheckBox();
            this.rbtnUrunSorgula = new Telerik.WinControls.UI.RadButton();
            this.rtxtUrunAdi = new Telerik.WinControls.UI.RadTextBox();
            this.rgbUrunListesi = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtnUrunListele = new Telerik.WinControls.UI.RadButton();
            this.rtxtAnahtarKelime = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgrwList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrwList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rchbHepsiBurada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbN11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUrunSorgula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUrunAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbUrunListesi)).BeginInit();
            this.rgbUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUrunListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAnahtarKelime)).BeginInit();
            this.SuspendLayout();
            // 
            // rgrwList
            // 
            this.rgrwList.Location = new System.Drawing.Point(11, 9);
            // 
            // 
            // 
            this.rgrwList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgrwList.Name = "rgrwList";
            this.rgrwList.Size = new System.Drawing.Size(777, 324);
            this.rgrwList.TabIndex = 3;
            this.rgrwList.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rchbHepsiBurada);
            this.radGroupBox1.Controls.Add(this.rchbN11);
            this.radGroupBox1.Controls.Add(this.rbtnUrunSorgula);
            this.radGroupBox1.Controls.Add(this.rtxtUrunAdi);
            this.radGroupBox1.HeaderText = "Ürün Sorgulama";
            this.radGroupBox1.Location = new System.Drawing.Point(22, 340);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(225, 99);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Ürün Sorgulama";
            // 
            // rchbHepsiBurada
            // 
            this.rchbHepsiBurada.Location = new System.Drawing.Point(118, 59);
            this.rchbHepsiBurada.Name = "rchbHepsiBurada";
            this.rchbHepsiBurada.Size = new System.Drawing.Size(82, 18);
            this.rchbHepsiBurada.TabIndex = 7;
            this.rchbHepsiBurada.Text = "hepsiburada";
            // 
            // rchbN11
            // 
            this.rchbN11.Location = new System.Drawing.Point(14, 59);
            this.rchbN11.Name = "rchbN11";
            this.rchbN11.Size = new System.Drawing.Size(41, 18);
            this.rchbN11.TabIndex = 6;
            this.rchbN11.Text = "N11";
            // 
            // rbtnUrunSorgula
            // 
            this.rbtnUrunSorgula.Location = new System.Drawing.Point(118, 21);
            this.rbtnUrunSorgula.Name = "rbtnUrunSorgula";
            this.rbtnUrunSorgula.Size = new System.Drawing.Size(96, 22);
            this.rbtnUrunSorgula.TabIndex = 5;
            this.rbtnUrunSorgula.Text = "Ürün Sorgula";
            this.rbtnUrunSorgula.Click += new System.EventHandler(this.rbtnUrunSorgula_Click);
            // 
            // rtxtUrunAdi
            // 
            this.rtxtUrunAdi.Location = new System.Drawing.Point(5, 21);
            this.rtxtUrunAdi.Name = "rtxtUrunAdi";
            this.rtxtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.rtxtUrunAdi.TabIndex = 0;
            // 
            // rgbUrunListesi
            // 
            this.rgbUrunListesi.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbUrunListesi.Controls.Add(this.rtxtAnahtarKelime);
            this.rgbUrunListesi.Controls.Add(this.rbtnUrunListele);
            this.rgbUrunListesi.HeaderText = "Ürün Listesi";
            this.rgbUrunListesi.Location = new System.Drawing.Point(560, 339);
            this.rgbUrunListesi.Name = "rgbUrunListesi";
            this.rgbUrunListesi.Size = new System.Drawing.Size(200, 100);
            this.rgbUrunListesi.TabIndex = 5;
            this.rgbUrunListesi.Text = "Ürün Listesi";
            // 
            // rbtnUrunListele
            // 
            this.rbtnUrunListele.Location = new System.Drawing.Point(104, 32);
            this.rbtnUrunListele.Name = "rbtnUrunListele";
            this.rbtnUrunListele.Size = new System.Drawing.Size(91, 22);
            this.rbtnUrunListele.TabIndex = 7;
            this.rbtnUrunListele.Text = "Ürün Listele";
            this.rbtnUrunListele.Click += new System.EventHandler(this.rbtnUrunListele_Click);
            // 
            // rtxtAnahtarKelime
            // 
            this.rtxtAnahtarKelime.Location = new System.Drawing.Point(5, 33);
            this.rtxtAnahtarKelime.Name = "rtxtAnahtarKelime";
            this.rtxtAnahtarKelime.Size = new System.Drawing.Size(93, 20);
            this.rtxtAnahtarKelime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rgbUrunListesi);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgrwList);
            this.Name = "Form1";
            this.Text = "Ürün Bulma Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgrwList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgrwList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rchbHepsiBurada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rchbN11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUrunSorgula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUrunAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbUrunListesi)).EndInit();
            this.rgbUrunListesi.ResumeLayout(false);
            this.rgbUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUrunListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAnahtarKelime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView rgrwList;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox rchbHepsiBurada;
        private Telerik.WinControls.UI.RadCheckBox rchbN11;
        private Telerik.WinControls.UI.RadButton rbtnUrunSorgula;
        private Telerik.WinControls.UI.RadTextBox rtxtUrunAdi;
        private Telerik.WinControls.UI.RadGroupBox rgbUrunListesi;
        private Telerik.WinControls.UI.RadTextBox rtxtAnahtarKelime;
        private Telerik.WinControls.UI.RadButton rbtnUrunListele;
    }
}

