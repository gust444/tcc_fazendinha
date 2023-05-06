namespace WindowsFormsApp2
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_login = new System.Windows.Forms.Button();
            this.box_login = new System.Windows.Forms.TextBox();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Transparent;
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.ForeColor = System.Drawing.Color.Transparent;
            this.bt_login.Location = new System.Drawing.Point(794, 461);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(139, 31);
            this.bt_login.TabIndex = 0;
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // box_login
            // 
            this.box_login.BackColor = System.Drawing.Color.White;
            this.box_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_login.Location = new System.Drawing.Point(778, 411);
            this.box_login.Name = "box_login";
            this.box_login.Size = new System.Drawing.Size(169, 13);
            this.box_login.TabIndex = 1;
            // 
            // box_senha
            // 
            this.box_senha.BackColor = System.Drawing.Color.White;
            this.box_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.box_senha.Location = new System.Drawing.Point(778, 330);
            this.box_senha.Name = "box_senha";
            this.box_senha.Size = new System.Drawing.Size(169, 13);
            this.box_senha.TabIndex = 2;
            this.box_senha.TextChanged += new System.EventHandler(this.box_senha_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.box_senha);
            this.Controls.Add(this.box_login);
            this.Controls.Add(this.bt_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox box_login;
        private System.Windows.Forms.TextBox box_senha;
    }
}

