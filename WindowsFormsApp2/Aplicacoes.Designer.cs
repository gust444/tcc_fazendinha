﻿namespace WindowsFormsApp2
{
    partial class Aplicacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicacoes));
            this.bt_voltar_aplica = new System.Windows.Forms.Button();
            this.bt_cad_aplica = new System.Windows.Forms.Button();
            this.bt_info_aplica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar_aplica
            // 
            this.bt_voltar_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_aplica.FlatAppearance.BorderSize = 0;
            this.bt_voltar_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_aplica.Location = new System.Drawing.Point(173, 603);
            this.bt_voltar_aplica.Name = "bt_voltar_aplica";
            this.bt_voltar_aplica.Size = new System.Drawing.Size(78, 76);
            this.bt_voltar_aplica.TabIndex = 0;
            this.bt_voltar_aplica.UseVisualStyleBackColor = false;
            this.bt_voltar_aplica.Click += new System.EventHandler(this.bt_voltar_talhao_Click);
            // 
            // bt_cad_aplica
            // 
            this.bt_cad_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_cad_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cad_aplica.FlatAppearance.BorderSize = 0;
            this.bt_cad_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cad_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cad_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cad_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cad_aplica.Location = new System.Drawing.Point(277, 212);
            this.bt_cad_aplica.Name = "bt_cad_aplica";
            this.bt_cad_aplica.Size = new System.Drawing.Size(309, 241);
            this.bt_cad_aplica.TabIndex = 1;
            this.bt_cad_aplica.UseVisualStyleBackColor = false;
            this.bt_cad_aplica.Click += new System.EventHandler(this.bt_cad_aplica_Click);
            // 
            // bt_info_aplica
            // 
            this.bt_info_aplica.BackColor = System.Drawing.Color.Transparent;
            this.bt_info_aplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_info_aplica.FlatAppearance.BorderSize = 0;
            this.bt_info_aplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_info_aplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_info_aplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info_aplica.ForeColor = System.Drawing.Color.Transparent;
            this.bt_info_aplica.Location = new System.Drawing.Point(770, 212);
            this.bt_info_aplica.Name = "bt_info_aplica";
            this.bt_info_aplica.Size = new System.Drawing.Size(302, 241);
            this.bt_info_aplica.TabIndex = 2;
            this.bt_info_aplica.UseVisualStyleBackColor = false;
            this.bt_info_aplica.Click += new System.EventHandler(this.bt_info_aplica_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 751);
            this.Controls.Add(this.bt_info_aplica);
            this.Controls.Add(this.bt_cad_aplica);
            this.Controls.Add(this.bt_voltar_aplica);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_aplica;
        private System.Windows.Forms.Button bt_cad_aplica;
        private System.Windows.Forms.Button bt_info_aplica;
    }
}