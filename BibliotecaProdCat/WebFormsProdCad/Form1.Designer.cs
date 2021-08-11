
namespace WebFormsProdCad
{
    partial class Form1
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
            this.btnProd = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(125, 87);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(237, 54);
            this.btnProd.TabIndex = 0;
            this.btnProd.Text = "Cadastro Produtos";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(125, 147);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(237, 54);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastro Categorias";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(202, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(73, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "CADASTROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 283);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label lbNome;
    }
}

