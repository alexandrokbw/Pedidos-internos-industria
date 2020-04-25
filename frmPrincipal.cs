using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Estoque
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Pedido novoPedido;
        DataTable dadosTabela;
        private static Font fonte;
        private static string texto;

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedido novoEnviarPedido = new frmPedido();
            novoEnviarPedido.ShowDialog();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControuPrincipal.SelectedTab == tabPedido)
            {
                listarPedidoAguardando();

            }
        }

        private void listarPedidoAguardando()
        {
            btnAguardando.BackColor = Color.SeaGreen;
            btnEnviado.BackColor = DefaultBackColor;
            btnHistorico.BackColor = DefaultBackColor;

            novoPedido = new Pedido();
            dadosTabela = new DataTable();
            dadosTabela = novoPedido.listarPedidoAguardando();
            dtgPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPedido.DataSource = dadosTabela;
            texto = "Prioridade Código\t\tDescrição\t\t\t\t\t\t\tLote\t  Quantidade\n" +
           "____________________________________________________________________________________________________________________\n";
            for (int i = 0; i < dadosTabela.Rows.Count; i++)
            {
                texto +=  dadosTabela.Rows[i]["prioridade"].ToString().PadRight(7)
                        + dadosTabela.Rows[i]["codigo"].ToString().PadLeft(10)+" - "
                        + dadosTabela.Rows[i]["nomeMaterial"].ToString().PadRight(65)
                        + dadosTabela.Rows[i]["lotePedido"].ToString().PadRight(14)
                        + dadosTabela.Rows[i]["quantidadePedido"].ToString().PadRight(5)
                        + dadosTabela.Rows[i]["UM"].ToString() + "\n";
            }
            
        }
        private void listarPedidoEnviado()
        {
            btnEnviado.BackColor = Color.SeaGreen;
            btnAguardando.BackColor = DefaultBackColor;
            btnHistorico.BackColor = DefaultBackColor;

            novoPedido = new Pedido();
            dadosTabela = new DataTable();
            dadosTabela = novoPedido.listarPedidoEnviado();
            dtgPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPedido.DataSource = dadosTabela; 
            texto = "\t\t\t\t\t\t\t\t\t\t  Lote          Quantidade   Lote   Quantidade \nPrioridade Código\t\tDescrição\t\t " +
                                       "\t\t\t  solicitado  \tsolicitada  \tenviado   enviada" +
          "\n____________________________________________________________________________________________________________________\n";
            for (int i = 0; i < dadosTabela.Rows.Count; i++)
            {
                texto += dadosTabela.Rows[i]["prioridade"].ToString().PadRight(7)
                        + dadosTabela.Rows[i]["codigo"].ToString().PadLeft(10) + " - "
                        + dadosTabela.Rows[i]["nomeMaterial"].ToString().Substring(0,30).PadRight(20)

                        + dadosTabela.Rows[i]["lotePedido"].ToString().PadRight(11)
                        + dadosTabela.Rows[i]["quantidadePedido"].ToString().PadRight(7)
                        +" "+ dadosTabela.Rows[i]["loteEnviado"].ToString().PadRight(11)
                        + dadosTabela.Rows[i]["quantidadeEnviada"].ToString().PadRight(4)
                        + dadosTabela.Rows[i]["UM"].ToString() + "\n";
            }
        }
        private void listarPedidoRecebido()
        {
            btnHistorico.BackColor = Color.SeaGreen;
            btnAguardando.BackColor = DefaultBackColor;
            btnEnviado.BackColor = DefaultBackColor;

            novoPedido = new Pedido();
            dadosTabela = new DataTable();
            dadosTabela = novoPedido.listarPedidoRecebido();
            dtgPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtgPedido.DataSource = dadosTabela;
        }
        private void enviarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgPedido.CurrentRow.Cells["statusPedido"].Value.ToString() == "Aguardando")
            {
                frmPedido novoEnviarPedido = new frmPedido();
                novoEnviarPedido.Text = "Enviando material";
                novoEnviarPedido.prioridade = dtgPedido.CurrentRow.Cells["prioridade"].Value.ToString();
                novoEnviarPedido.idPedido = Convert.ToInt32(dtgPedido.CurrentRow.Cells["idPedido"].Value);
                novoEnviarPedido.lblCodigo.Text = "Código \n" + dtgPedido.CurrentRow.Cells["codigo"].Value.ToString();
                novoEnviarPedido.lblNomeMaterial.Text = "Nome \n" + dtgPedido.CurrentRow.Cells["nomematerial"].Value.ToString();
                novoEnviarPedido.lblQuantidade.Text = "Quantidade \n" + dtgPedido.CurrentRow.Cells["quantidadePedido"].Value.ToString();
                novoEnviarPedido.lblUnidadedeMedida.Text = "UM \n" + dtgPedido.CurrentRow.Cells["um"].Value.ToString();
                novoEnviarPedido.lblLote.Text = "Lote \n" + dtgPedido.CurrentRow.Cells["lotePedido"].Value.ToString();
                novoEnviarPedido.lblOdf.Text = "ODF \n" + dtgPedido.CurrentRow.Cells["odf"].Value.ToString();
                novoEnviarPedido.txtObservacao.Text = dtgPedido.CurrentRow.Cells["observacao"].Value.ToString();
                novoEnviarPedido.ShowDialog();
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin novoLogin = new frmLogin();
            novoLogin.ShowDialog();
            lblUsuario.Text = Properties.Settings.Default.usuarioLogado;
            lblSetor.Text = Properties.Settings.Default.setorUsuario;
        }

        private void btnEnviado_Click(object sender, EventArgs e)
        {
            listarPedidoEnviado();
        }

        private void btnAguardando_Click(object sender, EventArgs e)
        {
            listarPedidoAguardando();
            btnAguardando.BackColor = Color.SeaGreen;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            listarPedidoRecebido();
        }

        private void informacãoDetalhadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalhesPedido novoDetalhePedido = new frmDetalhesPedido();
            novoDetalhePedido.idPedido = Convert.ToInt32(dtgPedido.CurrentRow.Cells["idPedido"].Value);
            novoDetalhePedido.ShowDialog();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido novoEnviarPedido = new frmPedido();
            novoEnviarPedido.ShowDialog();

        }

        private void receberPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgPedido.CurrentRow.Cells["statusPedido"].Value.ToString() == "Enviado")
            {
                frmPedido novoEnviarPedido = new frmPedido();
                novoEnviarPedido.Text = "Recebendo material";
                novoEnviarPedido.idPedido = Convert.ToInt32(dtgPedido.CurrentRow.Cells["idPedido"].Value);
                novoEnviarPedido.lblCodigoMrecebido.Text = "Código:\n" + dtgPedido.CurrentRow.Cells["codigo"].Value.ToString();
                novoEnviarPedido.lblNomeMrecebido.Text = "Nome:\n" + dtgPedido.CurrentRow.Cells["nomeMaterial"].Value.ToString();
                novoEnviarPedido.lblQuantidadeMrecebido.Text = "Quantidade:\n" + dtgPedido.CurrentRow.Cells["quantidadeEnviada"].Value.ToString();
                novoEnviarPedido.lblNota.Text = "Nota:\n" + dtgPedido.CurrentRow.Cells["notaFiscal"].Value.ToString();
                novoEnviarPedido.lblLoteMrecebido.Text = "Lote:\n" + dtgPedido.CurrentRow.Cells["loteEnviado"].Value.ToString();
                novoEnviarPedido.txtObservacao.Text = dtgPedido.CurrentRow.Cells["observacao"].Value.ToString();

                novoEnviarPedido.lblQuantidadeSolicitada.Text = "Quantidade solicitada:\n" + dtgPedido.CurrentRow.Cells["quantidadePedido"].Value.ToString();
                novoEnviarPedido.lblLoteSolicitado.Text = "Lote solicitado:\n" + dtgPedido.CurrentRow.Cells["lotePedido"].Value.ToString();


                novoEnviarPedido.ShowDialog();
            }
        }
        private void btnInsumo_Click(object sender, EventArgs e)
        {
            frmInsumo novoInsumo = new frmInsumo();
            novoInsumo.ShowDialog();
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintDialog printdlg = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);

            printPrvDlg.Document = pd;
            pd.DefaultPageSettings.Landscape = true;
            printPrvDlg.MinimumSize = new System.Drawing.Size(900, 600);
            printPrvDlg.ShowDialog(); 
            
            printdlg.Document = pd;
            
            if (printdlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), 100, 45, 966,40);

            e.Graphics.DrawString("Lista de pedidos  " + DateTime.Now.ToShortDateString() , new Font("Consolas", 12), new SolidBrush(Color.Black),
            483,55);

            e.Graphics.DrawString("\nEste documento deve ser assinado e anexado junto a nota fiscal" +
                "\n\nResponsavel pela separação:__________________________" +
                "\n\nResponsavel pelo recebimento ________________________", new Font("MS Reference Sans Serif", 9), new SolidBrush(Color.Black),
            120, 70);

            e.Graphics.DrawString(texto, new Font("Consolas", 12), new SolidBrush(Color.Black),
            25, e.MarginBounds.Top+110);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}