namespace WindowsFormsApp2
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.bt_plantio = new System.Windows.Forms.Button();
            this.bt_talhoes = new System.Windows.Forms.Button();
            this.bt_aplicacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_plantio
            // 
            this.bt_plantio.BackColor = System.Drawing.Color.Transparent;
            this.bt_plantio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_plantio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_plantio.FlatAppearance.BorderSize = 0;
            this.bt_plantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_plantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_plantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_plantio.ForeColor = System.Drawing.Color.Transparent;
            this.bt_plantio.Location = new System.Drawing.Point(578, 379);
            this.bt_plantio.Name = "bt_plantio";
            this.bt_plantio.Size = new System.Drawing.Size(212, 185);
            this.bt_plantio.TabIndex = 0;
            this.bt_plantio.UseVisualStyleBackColor = false;
            this.bt_plantio.Click += new System.EventHandler(this.bt_plantio_Click);
            // 
            // bt_talhoes
            // 
            this.bt_talhoes.BackColor = System.Drawing.Color.Transparent;
            this.bt_talhoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_talhoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_talhoes.FlatAppearance.BorderSize = 0;
            this.bt_talhoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_talhoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_talhoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_talhoes.ForeColor = System.Drawing.Color.Transparent;
            this.bt_talhoes.Location = new System.Drawing.Point(423, 114);
            this.bt_talhoes.Name = "bt_talhoes";
            this.bt_talhoes.Size = new System.Drawing.Size(208, 176);
            this.bt_talhoes.TabIndex = 1;
            this.bt_talhoes.UseVisualStyleBackColor = false;
            this.bt_talhoes.Click += new System.EventHandler(this.bt_talhoes_Click);
            // 
            // bt_aplicacao
            // 
            this.bt_aplicacao.BackColor = System.Drawing.Color.Transparent;
            this.bt_aplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_aplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aplicacao.FlatAppearance.BorderSize = 0;
            this.bt_aplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_aplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_aplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aplicacao.ForeColor = System.Drawing.Color.Transparent;
            this.bt_aplicacao.Location = new System.Drawing.Point(705, 105);
            this.bt_aplicacao.Name = "bt_aplicacao";
            this.bt_aplicacao.Size = new System.Drawing.Size(274, 185);
            this.bt_aplicacao.TabIndex = 2;
            this.bt_aplicacao.UseVisualStyleBackColor = false;
            this.bt_aplicacao.Click += new System.EventHandler(this.bt_aplicacao_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.bt_aplicacao);
            this.Controls.Add(this.bt_talhoes);
            this.Controls.Add(this.bt_plantio);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_plantio;
        private System.Windows.Forms.Button bt_talhoes;
        private System.Windows.Forms.Button bt_aplicacao;
    }
}