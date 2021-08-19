namespace Music_Player
{
    partial class Kullanici_hareketler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gridHareket = new System.Windows.Forms.DataGridView();
            this.hareket_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oynat = new System.Windows.Forms.DataGridViewImageColumn();
            this.kullanici_ismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gridHareket
            // 
            this.gridHareket.AllowUserToAddRows = false;
            this.gridHareket.AllowUserToDeleteRows = false;
            this.gridHareket.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.gridHareket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHareket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridHareket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridHareket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHareket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHareket.ColumnHeadersHeight = 30;
            this.gridHareket.ColumnHeadersVisible = false;
            this.gridHareket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareket_id,
            this.oynat,
            this.kullanici_ismi,
            this.mesaj,
            this.tarih});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHareket.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHareket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridHareket.Location = new System.Drawing.Point(0, 0);
            this.gridHareket.MultiSelect = false;
            this.gridHareket.Name = "gridHareket";
            this.gridHareket.ReadOnly = true;
            this.gridHareket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHareket.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridHareket.RowHeadersVisible = false;
            this.gridHareket.RowHeadersWidth = 62;
            this.gridHareket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridHareket.RowTemplate.Height = 30;
            this.gridHareket.Size = new System.Drawing.Size(1009, 444);
            this.gridHareket.TabIndex = 1;
            // 
            // hareket_id
            // 
            this.hareket_id.HeaderText = "hareket_id";
            this.hareket_id.MinimumWidth = 8;
            this.hareket_id.Name = "hareket_id";
            this.hareket_id.ReadOnly = true;
            this.hareket_id.Visible = false;
            this.hareket_id.Width = 150;
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
            // kullanici_ismi
            // 
            this.kullanici_ismi.HeaderText = "kullanici_ismi";
            this.kullanici_ismi.MinimumWidth = 70;
            this.kullanici_ismi.Name = "kullanici_ismi";
            this.kullanici_ismi.ReadOnly = true;
            this.kullanici_ismi.Width = 70;
            // 
            // mesaj
            // 
            this.mesaj.HeaderText = "mesaj";
            this.mesaj.MinimumWidth = 380;
            this.mesaj.Name = "mesaj";
            this.mesaj.ReadOnly = true;
            this.mesaj.Width = 380;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "tarih";
            this.tarih.MinimumWidth = 140;
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            this.tarih.Width = 140;
            // 
            // Kullanici_hareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridHareket);
            this.Name = "Kullanici_hareketler";
            this.Size = new System.Drawing.Size(1009, 444);
            this.Load += new System.EventHandler(this.Kullanici_hareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView gridHareket;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket_id;
        private System.Windows.Forms.DataGridViewImageColumn oynat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_ismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}
