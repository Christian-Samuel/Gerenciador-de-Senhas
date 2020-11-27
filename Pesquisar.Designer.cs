namespace GerenciarSenhas
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.locais = new System.Windows.Forms.ListBox();
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locais
            // 
            this.locais.FormattingEnabled = true;
            this.locais.Location = new System.Drawing.Point(12, 13);
            this.locais.Name = "locais";
            this.locais.Size = new System.Drawing.Size(130, 199);
            this.locais.TabIndex = 0;
            this.locais.SelectedIndexChanged += new System.EventHandler(this.locais_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(148, 39);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(0, 24);
            this.login.TabIndex = 1;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(148, 137);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(0, 24);
            this.senha.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(338, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.locais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 262);
            this.Name = "Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locais;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button button1;
    }
}