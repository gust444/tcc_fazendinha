namespace WindowsFormsApp2
{
    partial class Plantios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plantios));
            this.bt_cad_plantio = new System.Windows.Forms.Button();
            this.bt_info_plantio = new System.Windows.Forms.Button();
            this.bt_voltar_plantio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cad_plantio
            // 
            this.bt_cad_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_cad_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cad_plantio.FlatAppearance.BorderSize = 0;
            this.bt_cad_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cad_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cad_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cad_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cad_plantio.Location = new System.Drawing.Point(282, 217);
            this.bt_cad_plantio.Name = "bt_cad_plantio";
            this.bt_cad_plantio.Size = new System.Drawing.Size(302, 234);
            this.bt_cad_plantio.TabIndex = 2;
            this.bt_cad_plantio.UseVisualStyleBackColor = false;
            this.bt_cad_plantio.Click += new System.EventHandler(this.bt_cad_plantio_Click);
            // 
            // bt_info_plantio
            // 
            this.bt_info_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_info_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_info_plantio.FlatAppearance.BorderSize = 0;
            this.bt_info_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_info_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_info_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_info_plantio.Location = new System.Drawing.Point(772, 214);
            this.bt_info_plantio.Name = "bt_info_plantio";
            this.bt_info_plantio.Size = new System.Drawing.Size(302, 237);
            this.bt_info_plantio.TabIndex = 3;
            this.bt_info_plantio.UseVisualStyleBackColor = false;
            this.bt_info_plantio.Click += new System.EventHandler(this.bt_info_plantio_Click);
            // 
            // bt_voltar_plantio
            // 
            this.bt_voltar_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_plantio.FlatAppearance.BorderSize = 0;
            this.bt_voltar_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_plantio.Location = new System.Drawing.Point(176, 603);
            this.bt_voltar_plantio.Name = "bt_voltar_plantio";
            this.bt_voltar_plantio.Size = new System.Drawing.Size(72, 74);
            this.bt_voltar_plantio.TabIndex = 4;
            this.bt_voltar_plantio.UseVisualStyleBackColor = false;
            this.bt_voltar_plantio.Click += new System.EventHandler(this.bt_voltar_plantio_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 751);
            this.Controls.Add(this.bt_voltar_plantio);
            this.Controls.Add(this.bt_info_plantio);
            this.Controls.Add(this.bt_cad_plantio);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cad_plantio;
        private System.Windows.Forms.Button bt_info_plantio;
        private System.Windows.Forms.Button bt_voltar_plantio;
    }
}