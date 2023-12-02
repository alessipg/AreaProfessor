using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaProfessor
{
    public partial class EditExcluirWindow : Form
    {
        private Pontuacao pontuacao;
        public EditExcluirWindow(Pontuacao pontuacao)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.pontuacao = pontuacao;
            txtNomeAluno.Text = pontuacao.Nome;
            txtData.Text = pontuacao.Data;
            txtFase1.Text = pontuacao.Fase1.ToString();
            txtFase2.Text = pontuacao.Fase2.ToString();
            txtTempo.Text = pontuacao.Tempo;
            txtObs.Text = pontuacao.Obs;

        }

        private void txtData_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Obtenha a data selecionada no MonthCalendar
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Atualize o texto do TextBox com a data selecionada
            txtData.Text = selectedDate.ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = null;
            txtData.Text = null;
            txtFase1.Text = null;
            txtFase2.Text = null;
            txtTempo.Text = null;
            txtObs.Text = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNomeAluno.Text.Equals("") && !txtFase1.Text.Equals("") && !txtFase2.Text.Equals(""))
                {
                    if (VerificarFormatoData(txtData.Text))
                    {
                        if (VerificarFormatoHora(txtTempo.Text))
                        {
                            if (int.Parse(txtFase1.Text) >= 0 && int.Parse(txtFase1.Text) <= 100 && int.Parse(txtFase2.Text) >= 0 && int.Parse(txtFase2.Text) <= 100)
                            {

                                DialogResult result = MessageBox.Show("Deseja editar essa pontuação?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result == DialogResult.OK)
                                {
                                    Pontuacao pontuacao = new Pontuacao
                                    {
                                        Id = this.pontuacao.Id,
                                        Nome = txtNomeAluno.Text,
                                        Data = txtData.Text,
                                        Fase1 = int.Parse(txtFase1.Text),
                                        Fase2 = int.Parse(txtFase2.Text),
                                        Tempo = "00:" + txtTempo.Text,
                                        Obs = txtObs.Text,
                                    };

                                    new AreaProfessorDAO().editar(pontuacao);
                                    MessageBox.Show("Pontuação editada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }else
                            {
                                MessageBox.Show("Pontuações da Fase 1 e Fase 2 devem possuir valores de 0 a 100.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um tempo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira uma data válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, insira todos os valores necessários.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DBException db)
            {
                MessageBox.Show($"Database Error: {db.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            new AreaProfessorDAO().excluir(pontuacao.Id);
        }
        private bool VerificarFormatoHora(string texto)
        {
            // Expressão regular para validar o formato mm:ss
            string pattern = @"^\d{2}:\d{2}$";

            // Verificar se o texto corresponde ao padrão
            return Regex.IsMatch(texto, pattern);
        }
        private bool VerificarFormatoData(string texto)
        {
            // Expressão regular para validar o formato dd/MM/yyyy
            string pattern = @"^\d{2}/\d{2}/\d{4}$";

            // Verificar se o texto corresponde ao padrão
            return Regex.IsMatch(texto, pattern);
        }

        private void txtFase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada da tecla no TextBox
            }
        }

        private void txtFase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada da tecla no TextBox
            }
        }
    }
}
