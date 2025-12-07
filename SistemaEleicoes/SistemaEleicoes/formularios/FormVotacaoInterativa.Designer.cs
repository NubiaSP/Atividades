namespace SistemaEleicoes.formularios
{
    partial class FormVotacaoInterativa
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
            this.dgvCanditados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btBranco = new System.Windows.Forms.Button();
            this.btCorrigir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanditados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCanditados
            // 
            this.dgvCanditados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanditados.Location = new System.Drawing.Point(1, 197);
            this.dgvCanditados.Name = "dgvCanditados";
            this.dgvCanditados.RowHeadersWidth = 51;
            this.dgvCanditados.RowTemplate.Height = 24;
            this.dgvCanditados.Size = new System.Drawing.Size(896, 325);
            this.dgvCanditados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votação Interativa";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 34);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero do Candidato";
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.LightGreen;
            this.btConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirma.Location = new System.Drawing.Point(334, 97);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(152, 44);
            this.btConfirma.TabIndex = 4;
            this.btConfirma.Text = "COMFIRMAR";
            this.btConfirma.UseVisualStyleBackColor = false;
            // 
            // btBranco
            // 
            this.btBranco.BackColor = System.Drawing.Color.White;
            this.btBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBranco.Location = new System.Drawing.Point(648, 98);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(138, 44);
            this.btBranco.TabIndex = 5;
            this.btBranco.Text = "BRANCO";
            this.btBranco.UseVisualStyleBackColor = false;
            // 
            // btCorrigir
            // 
            this.btCorrigir.BackColor = System.Drawing.Color.OrangeRed;
            this.btCorrigir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCorrigir.Location = new System.Drawing.Point(497, 98);
            this.btCorrigir.Name = "btCorrigir";
            this.btCorrigir.Size = new System.Drawing.Size(138, 44);
            this.btCorrigir.TabIndex = 6;
            this.btCorrigir.Text = "CORRIGE";
            this.btCorrigir.UseVisualStyleBackColor = false;
            // 
            // FormVotacaoInterativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 522);
            this.Controls.Add(this.btCorrigir);
            this.Controls.Add(this.btBranco);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCanditados);
            this.Name = "FormVotacaoInterativa";
            this.Text = "FormVotacaoInterativa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanditados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCanditados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btBranco;
        private System.Windows.Forms.Button btCorrigir;
    }
}