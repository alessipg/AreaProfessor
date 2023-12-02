using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AreaProfessor
{
    public partial class AreaProfessorWindow : Form
    {
        private List<Pontuacao> pontuacoes;
        public AreaProfessorWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            inicializarTabela();
            atualizarTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                atualizarTabela();
                MessageBox.Show("Dados atualizados","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void inicializarTabela()
        {
            listPontuacoes.View = View.Details;
            listPontuacoes.LabelEdit = true;
            listPontuacoes.AllowColumnReorder = true;
            listPontuacoes.FullRowSelect = true;
            listPontuacoes.GridLines = true;
            listPontuacoes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listPontuacoes.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listPontuacoes.Columns.Add("Fase 1", 100, HorizontalAlignment.Left);
            listPontuacoes.Columns.Add("Fase 2", 100, HorizontalAlignment.Left);
            listPontuacoes.Columns.Add("Tempo", 100, HorizontalAlignment.Left);
            listPontuacoes.Columns.Add("Total", 80, HorizontalAlignment.Left);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirWindow novaJanela = new InserirWindow();

            novaJanela.Show();
            novaJanela.FormClosed += (s, args) =>
            {
                // Este código será executado quando a nova janela for fechada
                atualizarTabela();
            };
        }
        private void atualizarTabela()
        {
            try
            {
                pontuacoes = new AreaProfessorDAO().buscarTodos();
                listPontuacoes.Items.Clear();
                foreach (var pontuacao in pontuacoes)
                {
                    // Criar um novo item para a ListView com os dados da pontuação
                    ListViewItem item = new ListViewItem(pontuacao.Nome);
                    item.SubItems.Add(pontuacao.Data);
                    item.SubItems.Add(pontuacao.Fase1.ToString());
                    item.SubItems.Add(pontuacao.Fase2.ToString());
                    item.SubItems.Add(pontuacao.Tempo);
                    item.SubItems.Add(pontuacao.Total);
                    item.SubItems.Add(pontuacao.Obs);
                    item.SubItems.Add(pontuacao.Id.ToString());

                    // Adicionar o item à ListView
                    listPontuacoes.Items.Add(item);
                }
            }
            catch (DBException db)
            {
                MessageBox.Show($"Database Error: {db.Message}");
            }
            
        }

        private void listPontuacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPontuacoes.SelectedItems.Count > 0)
            {
                // Obtém a pontuação correspondente à linha selecionada
                Pontuacao pontuacaoSelecionada = pontuacoes[listPontuacoes.SelectedIndices[0]];

                // Exibe as observações na sua TextBox ou onde desejar
                txtObs.Text = pontuacaoSelecionada.Obs;
            }
        }

        private void btnEditExcluir_Click(object sender, EventArgs e)
        {
            if (listPontuacoes.SelectedItems.Count > 0)
            {
                // Obtém a pontuação correspondente à linha selecionada
                Pontuacao pontuacaoSelecionada = pontuacoes[listPontuacoes.SelectedIndices[0]];
                EditExcluirWindow novaJanela = new EditExcluirWindow(pontuacaoSelecionada);
                novaJanela.Show();
                novaJanela.FormClosed += (s, args) =>
                {
                    // Este código será executado quando a nova janela for fechada
                    atualizarTabela();
                };
            }
            else
                MessageBox.Show("É necessário selecionar um item para editar/excluir","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }
}
