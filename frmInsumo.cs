using System;
using System.Data;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmInsumo : Form
    {
        public frmInsumo()
        {
            InitializeComponent();
        }
        Material novoMaterial;
        DataTable dadosTabela;
        private void limpar()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            comboUM.Text = "";
            lblId.Text = "0";
        }

        private void listarMaterial()
        {
            novoMaterial = new Material();
            dadosTabela = new DataTable();
            dadosTabela = novoMaterial.listarMaterial();
            dtgMaterial.DataSource = dadosTabela;
        }

        private void frmInsumo_Load(object sender, EventArgs e)
        {
            listarMaterial();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (raidCodigo.Checked == true)
            {
                novoMaterial = new Material();
                dadosTabela = new DataTable();
                dadosTabela = novoMaterial.pesquisarMaterial(txtPesquisa.Text);
                dtgMaterial.DataSource = dadosTabela;
            }
            if (raidDescricao.Checked == true)
            {
                novoMaterial = new Material();
                dadosTabela = new DataTable();
                dadosTabela = novoMaterial.pesquisarMaterialPeloNome(txtPesquisa.Text);
                dtgMaterial.DataSource = dadosTabela;
            }
            if (txtPesquisa.Text == "")
            {
                novoMaterial = new Material();
                dadosTabela = new DataTable();
                dadosTabela = novoMaterial.listarMaterial();
                dtgMaterial.DataSource = dadosTabela;
            }
        }

        private void dtgMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgMaterial.CurrentRow.Cells["codigo"].Value.ToString();
            comboUM.Text = dtgMaterial.CurrentRow.Cells["unidadeDeMedida"].Value.ToString();
            txtDescricao.Text = dtgMaterial.CurrentRow.Cells["descricao"].Value.ToString();
            lblId.Text = dtgMaterial.CurrentRow.Cells["idMaterial"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0" && pesquisaMaterial() == true)
            {
                novoMaterial = new Material();
                novoMaterial.salvar(txtCodigo.Text, txtDescricao.Text, comboUM.Text);
                limpar();
                listarMaterial();
            }
            else
            {
                novoMaterial = new Material();
                novoMaterial.atualiza(Convert.ToInt32(lblId.Text), txtCodigo.Text, txtDescricao.Text, comboUM.Text);
                limpar();
                listarMaterial();
            }

        }

        private bool pesquisaMaterial()
        {
            novoMaterial = new Material();
            dadosTabela = new DataTable();
            dadosTabela = novoMaterial.pesquisarMaterial(txtCodigo.Text);
            if (dadosTabela.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Esse material ja existe", "Erro");
                return false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza de que deseja excluir \no material? ", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && lblId.Text != "0")
            {
                novoMaterial = new Material();
                novoMaterial.excluir(Convert.ToInt32(lblId.Text));
                limpar();
                listarMaterial();
            }
        }
    }
}
