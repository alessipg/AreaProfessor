namespace AreaProfessor
{
    partial class AreaProfessorWindow
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
            this.lblAmigos = new System.Windows.Forms.Label();
            this.lblAreaProfessor = new System.Windows.Forms.Label();
            this.listPontuacoes = new System.Windows.Forms.ListView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbPontuacoes = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPontuacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmigos
            // 
            this.lblAmigos.AutoSize = true;
            this.lblAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmigos.Location = new System.Drawing.Point(12, 19);
            this.lblAmigos.Name = "lblAmigos";
            this.lblAmigos.Size = new System.Drawing.Size(288, 38);
            this.lblAmigos.TabIndex = 0;
            this.lblAmigos.Text = "Amigos das Flores";
            // 
            // lblAreaProfessor
            // 
            this.lblAreaProfessor.AutoSize = true;
            this.lblAreaProfessor.Location = new System.Drawing.Point(16, 57);
            this.lblAreaProfessor.Name = "lblAreaProfessor";
            this.lblAreaProfessor.Size = new System.Drawing.Size(116, 16);
            this.lblAreaProfessor.TabIndex = 1;
            this.lblAreaProfessor.Text = "Área do Professor";
            // 
            // listPontuacoes
            // 
            this.listPontuacoes.HideSelection = false;
            this.listPontuacoes.Location = new System.Drawing.Point(6, 21);
            this.listPontuacoes.Name = "listPontuacoes";
            this.listPontuacoes.Size = new System.Drawing.Size(848, 286);
            this.listPontuacoes.TabIndex = 2;
            this.listPontuacoes.UseCompatibleStateImageBehavior = false;
            this.listPontuacoes.SelectedIndexChanged += new System.EventHandler(this.listPontuacoes_SelectedIndexChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(758, 104);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(114, 36);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // gbPontuacoes
            // 
            this.gbPontuacoes.Controls.Add(this.txtObs);
            this.gbPontuacoes.Controls.Add(this.listPontuacoes);
            this.gbPontuacoes.Location = new System.Drawing.Point(12, 146);
            this.gbPontuacoes.Name = "gbPontuacoes";
            this.gbPontuacoes.Size = new System.Drawing.Size(860, 410);
            this.gbPontuacoes.TabIndex = 4;
            this.gbPontuacoes.TabStop = false;
            this.gbPontuacoes.Text = "Pontuações";
            this.gbPontuacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(3, 339);
            this.txtObs.MaxLength = 300;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(848, 65);
            this.txtObs.TabIndex = 8;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(472, 104);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(160, 36);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Nova Pontuação";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditExcluir
            // 
            this.btnEditExcluir.Location = new System.Drawing.Point(638, 104);
            this.btnEditExcluir.Name = "btnEditExcluir";
            this.btnEditExcluir.Size = new System.Drawing.Size(114, 36);
            this.btnEditExcluir.TabIndex = 6;
            this.btnEditExcluir.Text = "Editar/Excluir";
            this.btnEditExcluir.UseVisualStyleBackColor = true;
            this.btnEditExcluir.Click += new System.EventHandler(this.btnEditExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Observações:";
            // 
            // AreaProfessorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gbPontuacoes);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblAreaProfessor);
            this.Controls.Add(this.lblAmigos);
            this.Name = "AreaProfessorWindow";
            this.Text = "Área do Professor";
            this.gbPontuacoes.ResumeLayout(false);
            this.gbPontuacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmigos;
        private System.Windows.Forms.Label lblAreaProfessor;
        private System.Windows.Forms.ListView listPontuacoes;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gbPontuacoes;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditExcluir;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
    }
}

