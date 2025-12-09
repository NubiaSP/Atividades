namespace SistemaEleicoes
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
            this.btVotacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btApuracao = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVotacao
            // 
            this.btVotacao.BackColor = System.Drawing.Color.PeachPuff;
            this.btVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotacao.Location = new System.Drawing.Point(75, 189);
            this.btVotacao.Name = "btVotacao";
            this.btVotacao.Size = new System.Drawing.Size(283, 47);
            this.btVotacao.TabIndex = 0;
            this.btVotacao.Text = "Votação Interativa";
            this.btVotacao.UseVisualStyleBackColor = false;
            this.btVotacao.Click += new System.EventHandler(this.btVotacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Eleições";
            // 
            // btApuracao
            // 
            this.btApuracao.BackColor = System.Drawing.Color.Aquamarine;
            this.btApuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApuracao.Location = new System.Drawing.Point(75, 289);
            this.btApuracao.Name = "btApuracao";
            this.btApuracao.Size = new System.Drawing.Size(283, 44);
            this.btApuracao.TabIndex = 3;
            this.btApuracao.Text = "Apuração e Resultados";
            this.btApuracao.UseVisualStyleBackColor = false;
            this.btApuracao.Click += new System.EventHandler(this.btApuracao_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.LightCyan;
            this.btCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(75, 93);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(283, 47);
            this.btCadastro.TabIndex = 5;
            this.btCadastro.Text = " Cadastro de Candidatos";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 410);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btApuracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVotacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVotacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btApuracao;
        private System.Windows.Forms.Button btCadastro;
    }
}

