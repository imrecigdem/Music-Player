namespace Music_Player
{
    partial class OynatmaListesi_user_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridOynatmaListesi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.sarki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oynat = new System.Windows.Forms.DataGridViewImageColumn();
            this.begen = new System.Windows.Forms.DataGridViewImageColumn();
            this.sarki_ismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarki_dakikasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarki_dosya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridOynatmaListesi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOynatmaListesi
            // 
            this.gridOynatmaListesi.AllowUserToAddRows = false;
            this.gridOynatmaListesi.AllowUserToDeleteRows = false;
            this.gridOynatmaListesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.gridOynatmaListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOynatmaListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridOynatmaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOynatmaListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOynatmaListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOynatmaListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOynatmaListesi.ColumnHeadersHeight = 30;
            this.gridOynatmaListesi.ColumnHeadersVisible = false;
            this.gridOynatmaListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sarki_id,
            this.oynat,
            this.begen,
            this.sarki_ismi,
            this.sanatci,
            this.sarki_dakikasi,
            this.ekleyen,
            this.sarki_dosya});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOynatmaListesi.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridOynatmaListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridOynatmaListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridOynatmaListesi.Location = new System.Drawing.Point(0, 99);
            this.gridOynatmaListesi.MultiSelect = false;
            this.gridOynatmaListesi.Name = "gridOynatmaListesi";
            this.gridOynatmaListesi.ReadOnly = true;
            this.gridOynatmaListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOynatmaListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridOynatmaListesi.RowHeadersVisible = false;
            this.gridOynatmaListesi.RowHeadersWidth = 62;
            this.gridOynatmaListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOynatmaListesi.RowTemplate.Height = 30;
            this.gridOynatmaListesi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridOynatmaListesi.Size = new System.Drawing.Size(1011, 262);
            this.gridOynatmaListesi.TabIndex = 1;
            this.gridOynatmaListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOynatmaListesi_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnBaslat);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Enabled = false;
            this.btnBaslat.Location = new System.Drawing.Point(26, 28);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(201, 44);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Çalma Listesini Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(275, 28);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(201, 44);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Çalma Listesini Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // sarki_id
            // 
            this.sarki_id.HeaderText = "sarki_id";
            this.sarki_id.MinimumWidth = 8;
            this.sarki_id.Name = "sarki_id";
            this.sarki_id.ReadOnly = true;
            this.sarki_id.Visible = false;
            this.sarki_id.Width = 150;
            // 
            // oynat
            // 
            this.oynat.HeaderText = "oynat";
            this.oynat.Image = global::Music_Player.Properties.Resources.oynat;
            this.oynat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.oynat.MinimumWidth = 40;
            this.oynat.Name = "oynat";
            this.oynat.ReadOnly = true;
            this.oynat.Width = 40;
            // 
            // begen
            // 
            this.begen.HeaderText = "begen";
            this.begen.Image = global::Music_Player.Properties.Resources.begen;
            this.begen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.begen.MinimumWidth = 40;
            this.begen.Name = "begen";
            this.begen.ReadOnly = true;
            this.begen.Width = 40;
            // 
            // sarki_ismi
            // 
            this.sarki_ismi.HeaderText = "sarki_ismi";
            this.sarki_ismi.MinimumWidth = 250;
            this.sarki_ismi.Name = "sarki_ismi";
            this.sarki_ismi.ReadOnly = true;
            this.sarki_ismi.Width = 250;
            // 
            // sanatci
            // 
            this.sanatci.HeaderText = "sanatci";
            this.sanatci.MinimumWidth = 8;
            this.sanatci.Name = "sanatci";
            this.sanatci.ReadOnly = true;
            this.sanatci.Width = 150;
            // 
            // sarki_dakikasi
            // 
            this.sarki_dakikasi.HeaderText = "sarki_dakikasi";
            this.sarki_dakikasi.MinimumWidth = 30;
            this.sarki_dakikasi.Name = "sarki_dakikasi";
            this.sarki_dakikasi.ReadOnly = true;
            this.sarki_dakikasi.Width = 30;
            // 
            // ekleyen
            // 
            this.ekleyen.HeaderText = "ekleyen";
            this.ekleyen.MinimumWidth = 8;
            this.ekleyen.Name = "ekleyen";
            this.ekleyen.ReadOnly = true;
            this.ekleyen.Width = 150;
            // 
            // sarki_dosya
            // 
            this.sarki_dosya.HeaderText = "sarki_dosya";
            this.sarki_dosya.MinimumWidth = 8;
            this.sarki_dosya.Name = "sarki_dosya";
            this.sarki_dosya.ReadOnly = true;
            this.sarki_dosya.Width = 150;
            // 
            // OynatmaListesi_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridOynatmaListesi);
            this.Name = "OynatmaListesi_user_control";
            this.Size = new System.Drawing.Size(1011, 361);
            this.Load += new System.EventHandler(this.Oynatma_listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOynatmaListesi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOynatmaListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarki_id;
        private System.Windows.Forms.DataGridViewImageColumn oynat;
        private System.Windows.Forms.DataGridViewImageColumn begen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarki_ismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatci;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarki_dakikasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekleyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarki_dosya;
    }
}
