namespace WindowsFormsApp2
{
    partial class InfoPlantio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPlantio));
            this.bt_voltar_info_plantio = new System.Windows.Forms.Button();
            this.bt_editar_plantio = new System.Windows.Forms.Button();
            this.tb_plantio = new System.Windows.Forms.DataGridView();
            this.bt_apagar_plantio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_plantio)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_voltar_info_plantio
            // 
            this.bt_voltar_info_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_info_plantio.FlatAppearance.BorderSize = 0;
            this.bt_voltar_info_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_info_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_plantio.Location = new System.Drawing.Point(155, 656);
            this.bt_voltar_info_plantio.Name = "bt_voltar_info_plantio";
            this.bt_voltar_info_plantio.Size = new System.Drawing.Size(73, 70);
            this.bt_voltar_info_plantio.TabIndex = 9;
            this.bt_voltar_info_plantio.UseVisualStyleBackColor = false;
            this.bt_voltar_info_plantio.Click += new System.EventHandler(this.bt_voltar_info_plantio_Click);
            // 
            // bt_editar_plantio
            // 
            this.bt_editar_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_editar_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_plantio.FlatAppearance.BorderSize = 0;
            this.bt_editar_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_editar_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_editar_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_editar_plantio.Location = new System.Drawing.Point(1137, 656);
            this.bt_editar_plantio.Name = "bt_editar_plantio";
            this.bt_editar_plantio.Size = new System.Drawing.Size(73, 70);
            this.bt_editar_plantio.TabIndex = 10;
            this.bt_editar_plantio.UseVisualStyleBackColor = false;
            // 
            // tb_plantio
            // 
            this.tb_plantio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(202)))), ((int)(((byte)(11)))));
            this.tb_plantio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_plantio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_plantio.Location = new System.Drawing.Point(210, 160);
            this.tb_plantio.Name = "tb_plantio";
            this.tb_plantio.Size = new System.Drawing.Size(950, 450);
            this.tb_plantio.TabIndex = 11;
            this.tb_plantio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.tb_plantio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_plantio_CellContentClick);
            // 
            // bt_apagar_plantio
            // 
            this.bt_apagar_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_apagar_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_apagar_plantio.FlatAppearance.BorderSize = 0;
            this.bt_apagar_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_apagar_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_apagar_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_apagar_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_apagar_plantio.Location = new System.Drawing.Point(646, 656);
            this.bt_apagar_plantio.Name = "bt_apagar_plantio";
            this.bt_apagar_plantio.Size = new System.Drawing.Size(73, 70);
            this.bt_apagar_plantio.TabIndex = 12;
            this.bt_apagar_plantio.UseVisualStyleBackColor = false;
            // 
            // InfoPlantio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 751);
            this.Controls.Add(this.bt_apagar_plantio);
            this.Controls.Add(this.tb_plantio);
            this.Controls.Add(this.bt_editar_plantio);
            this.Controls.Add(this.bt_voltar_info_plantio);
            this.Name = "InfoPlantio";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.InfoPlantio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_plantio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_info_plantio;
        private System.Windows.Forms.Button bt_editar_plantio;
        private System.Windows.Forms.DataGridView tb_plantio;
        private System.Windows.Forms.Button bt_apagar_plantio;
    }
}