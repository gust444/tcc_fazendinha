﻿namespace WindowsFormsApp2
{
    partial class InfoAplicacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoAplicacoes));
            this.bt_voltar_info_aplica = new System.Windows.Forms.Button();
            this.bt_editar_aplica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar_info_aplica
            // 
            this.bt_voltar_info_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_info_aplica.FlatAppearance.BorderSize = 0;
            this.bt_voltar_info_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_info_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_info_aplica.Location = new System.Drawing.Point(155, 653);
            this.bt_voltar_info_aplica.Name = "bt_voltar_info_aplica";
            this.bt_voltar_info_aplica.Size = new System.Drawing.Size(74, 76);
            this.bt_voltar_info_aplica.TabIndex = 2;
            this.bt_voltar_info_aplica.UseVisualStyleBackColor = false;
            this.bt_voltar_info_aplica.Click += new System.EventHandler(this.bt_voltar_info_aplica_Click);
            // 
            // bt_editar_aplica
            // 
            this.bt_editar_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_editar_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar_aplica.FlatAppearance.BorderSize = 0;
            this.bt_editar_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_editar_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_editar_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_editar_aplica.Location = new System.Drawing.Point(1137, 653);
            this.bt_editar_aplica.Name = "bt_editar_aplica";
            this.bt_editar_aplica.Size = new System.Drawing.Size(74, 76);
            this.bt_editar_aplica.TabIndex = 3;
            this.bt_editar_aplica.UseVisualStyleBackColor = false;
            // 
            // InfoAplicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 751);
            this.Controls.Add(this.bt_editar_aplica);
            this.Controls.Add(this.bt_voltar_info_aplica);
            this.Name = "InfoAplicacoes";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_info_aplica;
        private System.Windows.Forms.Button bt_editar_aplica;
    }
}