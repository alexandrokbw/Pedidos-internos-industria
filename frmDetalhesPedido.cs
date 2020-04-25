using System;
using System.Data;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmDetalhesPedido : Form
    {
        public frmDetalhesPedido()
        {
            InitializeComponent();
        }

        Pedido novoPedido;
        DataTable dadostabela;
        internal int idPedido;

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalhesPedido_Load(object sender, EventArgs e)
        {
            novoPedido = new Pedido();
            dadostabela = new DataTable();
            dadostabela = novoPedido.listarTetalhesPedido(idPedido);
            //Pedido
            lblCodigo.Text = dadostabela.Rows[0]["codigo"].ToString();
            lblDescricao.Text = dadostabela.Rows[0]["nomeMaterial"].ToString();
            lblDataSolicitacao.Text = "Data: " + dadostabela.Rows[0]["dataPedido"].ToString();
            lblHoraSolicitacao.Text = "Hora: " + dadostabela.Rows[0]["horaPedido"].ToString();
            lblNomeSolicitante.Text = dadostabela.Rows[0]["nomeSolicitante"].ToString();
            lblQtdSolicitacao.Text = dadostabela.Rows[0]["quantidadePedido"].ToString();
            lblUMSolicitacao.Text = "UM: " + dadostabela.Rows[0]["UM"].ToString();
            lblLoteSolicitacao.Text = dadostabela.Rows[0]["lotePedido"].ToString();
            txtObservacao.Text = dadostabela.Rows[0]["observacao"].ToString();
            //Envio
            lblDataEnvio.Text = "Data: " + dadostabela.Rows[0]["dataEnvio"].ToString();
            lblHoraEnvio.Text = "Hora: " + dadostabela.Rows[0]["horaEnvio"].ToString();
            lblNomeResponsavel.Text = dadostabela.Rows[0]["nomeResponsavel"].ToString();
            lblQtdEnvio.Text = dadostabela.Rows[0]["quantidadeEnviada"].ToString();
            lblLoteEnvio.Text = dadostabela.Rows[0]["loteEnviado"].ToString();
            lblNotaFiscal.Text = "Nota fiscal: " + dadostabela.Rows[0]["notaFiscal"].ToString();
            lblVeiculo.Text = "Veiculo: " + dadostabela.Rows[0]["veiculo"].ToString();
            //Recebimento

            lblDataRecebimento.Text = "Data: " + dadostabela.Rows[0]["dataRecebimento"].ToString();
            lblHoraRecebimento.Text = "Hora: " + dadostabela.Rows[0]["horaRecebimento"].ToString();
            lblNomeConferente.Text = dadostabela.Rows[0]["nomeConferente"].ToString();
            lblQtdRecebimento.Text = dadostabela.Rows[0]["quantidadeRecebida"].ToString();
            lblLoteRecebimento.Text = dadostabela.Rows[0]["loteRecebido"].ToString();

        }
    }
}
