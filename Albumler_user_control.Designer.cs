namespace Music_Player
{
    partial class Albumler_user_control
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
            this.gridAlbumler = new System.Windows.Forms.DataGridView();
            this.album_resim = new System.Windows.Forms.DataGridViewImageColumn();
            this.album_ismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekle = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlbumler)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gridAlbumler
            // 
            this.gridAlbumler.AllowUserToAddRows = false;
            this.gridAlbumler.AllowUserToDeleteRows = false;
            this.gridAlbumler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.gridAlbumler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlbumler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridAlbumler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAlbumler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAlbumler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlbumler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlbumler.ColumnHeadersHeight = 30;
            this.gridAlbumler.ColumnHeadersVisible = false;
            this.gridAlbumler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.album_resim,
            this.album_ismi,
            this.sanatci,
            this.ekleyen,
            this.ekle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlbumler.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAlbumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAlbumler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridAlbumler.Location = new System.Drawing.Point(0, 0);
            this.gridAlbumler.MultiSelect = false;
            this.gridAlbumler.Name = "gridAlbumler";
            this.gridAlbumler.ReadOnly = true;
            this.gridAlbumler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlbumler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAlbumler.RowHeadersVisible = false;
            this.gridAlbumler.RowHeadersWidth = 62;
            this.gridAlbumler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAlbumler.RowTemplate.Height = 30;
            this.gridAlbumler.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridAlbumler.Size = new System.Drawing.Size(997, 396);
            this.gridAlbumler.TabIndex = 1;
            this.gridAlbumler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlbumler_CellContentClick);
            this.gridAlbumler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlbumler_CellContentDoubleClick);
            // 
            // album_resim
            // 
            this.album_resim.HeaderText = "album_resim";
            this.album_resim.Image = global::Music_Player.Properties.Resources.oynat;
            this.album_resim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.album_resim.MinimumWidth = 40;
            this.album_resim.Name = "album_resim";
            this.album_resim.ReadOnly = true;
            this.album_resim.Width = 40;
            // 
            // album_ismi
            // 
            this.album_ismi.HeaderText = "album_ismi";
            this.album_ismi.MinimumWidth = 250;
            this.album_ismi.Name = "album_ismi";
            this.album_ismi.ReadOnly = true;
            this.album_ismi.Width = 250;
            // 
            // sanatci
            // 
            this.sanatci.HeaderText = "sanatci";
            this.sanatci.MinimumWidth = 8;
            this.sanatci.Name = "sanatci";
            this.sanatci.ReadOnly = true;
            this.sanatci.Width = 150;
            // 
            // ekleyen
            // 
            this.ekleyen.HeaderText = "ekleyen";
            this.ekleyen.MinimumWidth = 8;
            this.ekleyen.Name = "ekleyen";
            this.ekleyen.ReadOnly = true;
            this.ekleyen.Width = 150;
            // 
            // ekle
            // 
            this.ekle.HeaderText = "ekle";
            this.ekle.Image = global::Music_Player.Properties.Resources.plus;
            this.ekle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ekle.MinimumWidth = 40;
            this.ekle.Name = "ekle";
            this.ekle.ReadOnly = true;
            this.ekle.Width = 40;
            // 
            // Albumler_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridAlbumler);
            this.Name = "Albumler_user_control";
            this.Size = new System.Drawing.Size(997, 396);
            this.Load += new System.EventHandler(this.Albumler_user_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlbumler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView gridAlbumler;
        private System.Windows.Forms.DataGridViewImageColumn album_resim;
        private System.Windows.Forms.DataGridViewTextBoxColumn album_ismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekleyen;
        private System.Windows.Forms.DataGridViewImageColumn ekle;
    }
}
