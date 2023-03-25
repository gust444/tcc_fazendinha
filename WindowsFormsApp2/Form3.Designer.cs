namespace WindowsFormsApp2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bt_voltar_talhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltar_talhao
            // 
            this.bt_voltar_talhao.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_talhao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar_talhao.FlatAppearance.BorderSize = 0;
            this.bt_voltar_talhao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_talhao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_voltar_talhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar_talhao.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar_talhao.Location = new System.Drawing.Point(173, 603);
            this.bt_voltar_talhao.Name = "bt_voltar_talhao";
            this.bt_voltar_talhao.Size = new System.Drawing.Size(78, 76);
            this.bt_voltar_talhao.TabIndex = 0;
            this.bt_voltar_talhao.UseVisualStyleBackColor = false;
            this.bt_voltar_talhao.Click += new System.EventHandler(this.bt_voltar_talhao_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 743);
            this.Controls.Add(this.bt_voltar_talhao);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltar_talhao;
    }
}