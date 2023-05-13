namespace WindowsFormsApp2
{
    partial class CadAplicacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAplicacoes));
            this.bt_voltar_cad_aplica = new System.Windows.Forms.Button();
            this.bt_confirma_cad_aplica = new System.Windows.Forms.Button();
            this.bt_salvar_aplica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar_cad_aplica
            // 
            this.bt_voltar_cad_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_cad_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_cad_aplica.FlatAppearance.BorderSize = 0;
            this.bt_voltar_cad_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_cad_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_cad_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_cad_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_cad_aplica.Location = new System.Drawing.Point(176, 668);
            this.bt_voltar_cad_aplica.Name = "bt_voltar_cad_aplica";
            this.bt_voltar_cad_aplica.Size = new System.Drawing.Size(73, 71);
            this.bt_voltar_cad_aplica.TabIndex = 1;
            this.bt_voltar_cad_aplica.UseVisualStyleBackColor = false;
            this.bt_voltar_cad_aplica.Click += new System.EventHandler(this.bt_voltar_cad_aplica_Click);
            // 
            // bt_confirma_cad_aplica
            // 
            this.bt_confirma_cad_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_confirma_cad_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_confirma_cad_aplica.FlatAppearance.BorderSize = 0;
            this.bt_confirma_cad_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_confirma_cad_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_confirma_cad_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirma_cad_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_confirma_cad_aplica.Location = new System.Drawing.Point(995, 678);
            this.bt_confirma_cad_aplica.Name = "bt_confirma_cad_aplica";
            this.bt_confirma_cad_aplica.Size = new System.Drawing.Size(196, 51);
            this.bt_confirma_cad_aplica.TabIndex = 2;
            this.bt_confirma_cad_aplica.UseVisualStyleBackColor = false;
            // 
            // bt_salvar_aplica
            // 
            this.bt_salvar_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar_aplica.FlatAppearance.BorderSize = 0;
            this.bt_salvar_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_salvar_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_salvar_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_salvar_aplica.Location = new System.Drawing.Point(586, 678);
            this.bt_salvar_aplica.Name = "bt_salvar_aplica";
            this.bt_salvar_aplica.Size = new System.Drawing.Size(196, 51);
            this.bt_salvar_aplica.TabIndex = 3;
            this.bt_salvar_aplica.UseVisualStyleBackColor = false;
            // 
            // CadAplicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 751);
            this.Controls.Add(this.bt_salvar_aplica);
            this.Controls.Add(this.bt_confirma_cad_aplica);
            this.Controls.Add(this.bt_voltar_cad_aplica);
            this.Name = "CadAplicacoes";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_cad_aplica;
        private System.Windows.Forms.Button bt_confirma_cad_aplica;
        private System.Windows.Forms.Button bt_salvar_aplica;
    }
}