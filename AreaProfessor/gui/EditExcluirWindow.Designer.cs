using System;
using System.Windows.Forms;

namespace AreaProfessor
{
    partial class EditExcluirWindow
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
            this.gbNovaPontuacao = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtFase2 = new System.Windows.Forms.TextBox();
            this.txtFase1 = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblFase2 = new System.Windows.Forms.Label();
            this.lblFase1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbNovaPontuacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNovaPontuacao
            // 
            this.gbNovaPontuacao.Controls.Add(this.textBox1);
            this.gbNovaPontuacao.Controls.Add(this.txtData);
            this.gbNovaPontuacao.Controls.Add(this.txtTempo);
            this.gbNovaPontuacao.Controls.Add(this.monthCalendar1);
            this.gbNovaPontuacao.Controls.Add(this.txtObs);
            this.gbNovaPontuacao.Controls.Add(this.txtFase2);
            this.gbNovaPontuacao.Controls.Add(this.txtFase1);
            this.gbNovaPontuacao.Controls.Add(this.txtNomeAluno);
            this.gbNovaPontuacao.Controls.Add(this.lblObs);
            this.gbNovaPontuacao.Controls.Add(this.lblTempo);
            this.gbNovaPontuacao.Controls.Add(this.lblFase2);
            this.gbNovaPontuacao.Controls.Add(this.lblFase1);
            this.gbNovaPontuacao.Controls.Add(this.lblData);
            this.gbNovaPontuacao.Controls.Add(this.lblAluno);
            this.gbNovaPontuacao.Location = new System.Drawing.Point(12, 17);
            this.gbNovaPontuacao.Name = "gbNovaPontuacao";
            this.gbNovaPontuacao.Size = new System.Drawing.Size(877, 327);
            this.gbNovaPontuacao.TabIndex = 0;
            this.gbNovaPontuacao.TabStop = false;
            this.gbNovaPontuacao.Text = "Nova Pontuação";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(144, 70);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(87, 22);
            this.txtData.TabIndex = 14;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtData_MouseClick);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(130, 165);
            this.txtTempo.Mask = "00:00";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(47, 22);
            this.txtTempo.TabIndex = 13;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(518, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(23, 226);
            this.txtObs.MaxLength = 300;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(848, 95);
            this.txtObs.TabIndex = 11;
            // 
            // txtFase2
            // 
            this.txtFase2.Location = new System.Drawing.Point(77, 133);
            this.txtFase2.Name = "txtFase2";
            this.txtFase2.Size = new System.Drawing.Size(100, 22);
            this.txtFase2.TabIndex = 9;
            this.txtFase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFase2_KeyPress);
            // 
            // txtFase1
            // 
            this.txtFase1.Location = new System.Drawing.Point(77, 102);
            this.txtFase1.Name = "txtFase1";
            this.txtFase1.Size = new System.Drawing.Size(100, 22);
            this.txtFase1.TabIndex = 8;
            this.txtFase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFase1_KeyPress);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(129, 36);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(319, 22);
            this.txtNomeAluno.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(20, 207);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 16);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "Observações:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(20, 168);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(104, 16);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "Tempo: (mm:ss)";
            // 
            // lblFase2
            // 
            this.lblFase2.AutoSize = true;
            this.lblFase2.Location = new System.Drawing.Point(20, 136);
            this.lblFase2.Name = "lblFase2";
            this.lblFase2.Size = new System.Drawing.Size(51, 16);
            this.lblFase2.TabIndex = 3;
            this.lblFase2.Text = "Fase 2:";
            // 
            // lblFase1
            // 
            this.lblFase1.AutoSize = true;
            this.lblFase1.Location = new System.Drawing.Point(20, 105);
            this.lblFase1.Name = "lblFase1";
            this.lblFase1.Size = new System.Drawing.Size(51, 16);
            this.lblFase1.TabIndex = 2;
            this.lblFase1.Text = "Fase 1:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 73);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(118, 16);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data da Atividade:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(20, 42);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(103, 16);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do Aluno:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(621, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 35);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(476, 350);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(139, 35);
            this.btnLimparCampos.TabIndex = 2;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(744, 350);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 73);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "IMPORTANTE: A alteração de pontuações só deve ser feita em casos de falha no arma" +
    "zenamento do jogo.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditExcluirWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 397);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbNovaPontuacao);
            this.Name = "EditExcluirWindow";
            this.Text = "Editar/Excluir Pontuações";
            this.gbNovaPontuacao.ResumeLayout(false);
            this.gbNovaPontuacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovaPontuacao;
        private System.Windows.Forms.Label lblFase2;
        private System.Windows.Forms.Label lblFase1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtFase2;
        private System.Windows.Forms.TextBox txtFase1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimparCampos;
        private MaskedTextBox txtData;
        private MaskedTextBox txtTempo;
        private Button btnExcluir;
        private TextBox textBox1;
    }
}