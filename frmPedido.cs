using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        public int idPedido;
        public string prioridade;
        Pedido novoPedido;
        Material novoMaterial;

        DataTable dadosTabela;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPedido)
            {
                if (comboPrioridade.Text!=""&&txtQuantidadePedido.Text!="")
                {

                    novoPedido = new Pedido();
                    novoPedido.salvarPedido(Properties.Settings.Default.usuarioLogado, Convert.ToInt32(lblIdMaterial.Text), comboPrioridade.Text, DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString(), txtOdf.Text, comboUnidadeDeMedida.Text, txtQuantidadePedido.Text, txtlotePedido.Text, txtObservacao.Text, "Aguardando");
                    MessageBox.Show("Novo pedido inserido");
                    this.Close();
                }
                
               
            }
            if (tabControl1.SelectedTab == tabEnviar)
            {
                if (txtQuantidadeEnviada.Text!=""&&txtLoteEnviado.Text!="")
                {
                    novoPedido = new Pedido();
                    novoPedido.enviarPedido(idPedido, DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString(), txtNotaFiscal.Text, txtVeiculo.Text, txtQuantidadeEnviada.Text, txtLoteEnviado.Text, Properties.Settings.Default.usuarioLogado, txtObservacao.Text, "Enviado");
                    MessageBox.Show("Pedido enviado");
                    this.Close();
                }
            }
            if (tabControl1.SelectedTab == tabReceber)
            {
                if (txtLoteRecebido.Text!=""&&txtQuantidadeRecebida.Text!="")
                {
                    novoPedido = new Pedido();
                    novoPedido.receberPedido(idPedido, DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString(), Properties.Settings.Default.usuarioLogado, txtQuantidadeRecebida.Text, txtLoteRecebido.Text, txtObservacao.Text, "Recebido");
                    MessageBox.Show("Pedido recebido");
                    this.Close();
                }
            }
           
        }

        private void frmEnviaPedido_Load(object sender, EventArgs e)
        {

            switch (this.Text)
            {
                case "Solicitando material":
                    tabControl1.TabPages.Remove(tabEnviar);
                    tabControl1.TabPages.Remove(tabReceber);
                    break;
                case "Enviando material":
                    tabControl1.TabPages.Remove(tabPedido);
                    tabControl1.TabPages.Remove(tabReceber);
                    break;
                case "Recebendo material":
                    tabControl1.TabPages.Remove(tabPedido);
                    tabControl1.TabPages.Remove(tabEnviar);
                    break;
            }
            txtlotePedido.Focus();
            switch (prioridade)
            {
                case "Alta":
                    panel1.BackColor = Color.Red;
                    label1.Text = "Prioridade alta";
                    break;
                case "Média":
                    panel1.BackColor = Color.Yellow;
                    label1.Text = "Prioridade média";
                    break;
                case "Baixa":
                    panel1.BackColor = Color.LightBlue;
                    label1.Text = "Prioridade baixa";
                    break;
            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                novoMaterial = new Material();
                dadosTabela = new DataTable();
                dadosTabela = novoMaterial.pesquisarMaterial(txtCodigo.Text);
                if (dadosTabela.Rows.Count > 0)
                {
                    lblNomeMaterial1.Text = dadosTabela.Rows[0]["nomeMaterial"].ToString();
                    lblIdMaterial.Text = dadosTabela.Rows[0]["idMaterial"].ToString();
                }
                else
                {
                    lblNomeMaterial1.Text = "Nada encontrado !";
                    lblIdMaterial.Text = "Nada encontrado !";
                }
            }

        }

        private void txtOdf_Leave(object sender, EventArgs e)
        {
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPrioridade.Text)
            {
                case "Alta":
                    panel1.BackColor = Color.Red;
                    label1.Text = "Prioridade alta";
                    break;
                case "Média":
                    panel1.BackColor = Color.Yellow;
                    label1.Text = "Prioridade média";
                    break;
                case "Baixa":
                    panel1.BackColor = Color.Lime;
                    label1.Text = "Prioridade baixa";
                    break;
            }
        }

        private void lblCodigoMrecebido_Click(object sender, EventArgs e)
        {

        }
    }
}
