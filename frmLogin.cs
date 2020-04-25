using System;
using System.Data;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        DataTable dadosTabela;
        usuario novoUsuario;
        public bool verificaLogin()
        {
            novoUsuario = new usuario();
            dadosTabela = new DataTable();
            dadosTabela = novoUsuario.verificarLogin(txtNome.Text, txtSenha.Text, comboSetor.Text);
            if (dadosTabela.Rows.Count > 0)
            {
                Properties.Settings.Default.usuarioLogado = dadosTabela.Rows[0]["nomeUsuario"].ToString();
                Properties.Settings.Default.setorUsuario = dadosTabela.Rows[0]["setor"].ToString();
                Properties.Settings.Default.Save();
                this.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (verificaLogin())
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (verificaLogin())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!", "Acesso negado");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
            }

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
            }
            txtSenha.PasswordChar = Convert.ToChar("*");

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            novoUsuario = new usuario();
            DataTable dadosTabela = new DataTable();
            dadosTabela = novoUsuario.ListarSetorUsuario();
            comboSetor.DataSource = dadosTabela;
            //comboSetor.ValueMember = "idSetor";
            comboSetor.DisplayMember = "Setor";

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
            }
            txtSenha.PasswordChar = Convert.ToChar("*");
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCaminhoBanco_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "3625")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                   InitialDirectory =@"C: \" ,
                   Title = "Procurando banco de dados" , 

                 CheckFileExists = true ,  
                 CheckPathExists = true ,  
  
                 FilterIndex = 2,  
                 RestoreDirectory = true ,  
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lblNomeBanco.Text = openFileDialog1.FileName;
                    Properties.Settings.Default.bancoDeDadosEstoqueConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

