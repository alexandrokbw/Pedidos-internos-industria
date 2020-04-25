namespace Estoque
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtQuantidadeEnviada = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeMaterial = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblUnidadedeMedida = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblOdf = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.lblIdMaterial = new System.Windows.Forms.Label();
            this.comboUnidadeDeMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblNomeMaterial1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuantidadePedido = new System.Windows.Forms.TextBox();
            this.txtlotePedido = new System.Windows.Forms.TextBox();
            this.txtOdf = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            this.tabEnviar = new System.Windows.Forms.TabPage();
            this.txtLoteEnviado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabReceber = new System.Windows.Forms.TabPage();
            this.lblLoteSolicitado = new System.Windows.Forms.Label();
            this.lblQuantidadeSolicitada = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLoteMrecebido = new System.Windows.Forms.Label();
            this.lblCodigoMrecebido = new System.Windows.Forms.Label();
            this.lblQuantidadeMrecebido = new System.Windows.Forms.Label();
            this.lblNomeMrecebido = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtLoteRecebido = new System.Windows.Forms.TextBox();
            this.txtQuantidadeRecebida = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPedido.SuspendLayout();
            this.tabEnviar.SuspendLayout();
            this.tabReceber.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaFiscal.Location = new System.Drawing.Point(7, 117);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(121, 21);
            this.txtNotaFiscal.TabIndex = 0;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeiculo.Location = new System.Drawing.Point(290, 117);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(131, 21);
            this.txtVeiculo.TabIndex = 2;
            // 
            // txtQuantidadeEnviada
            // 
            this.txtQuantidadeEnviada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeEnviada.Location = new System.Drawing.Point(141, 117);
            this.txtQuantidadeEnviada.Name = "txtQuantidadeEnviada";
            this.txtQuantidadeEnviada.Size = new System.Drawing.Size(136, 21);
            this.txtQuantidadeEnviada.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblNomeMaterial
            // 
            this.lblNomeMaterial.AutoSize = true;
            this.lblNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMaterial.Location = new System.Drawing.Point(104, 12);
            this.lblNomeMaterial.Name = "lblNomeMaterial";
            this.lblNomeMaterial.Size = new System.Drawing.Size(105, 16);
            this.lblNomeMaterial.TabIndex = 2;
            this.lblNomeMaterial.Text = "NomeMaterial";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(7, 51);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(88, 16);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblUnidadedeMedida
            // 
            this.lblUnidadedeMedida.AutoSize = true;
            this.lblUnidadedeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadedeMedida.Location = new System.Drawing.Point(121, 51);
            this.lblUnidadedeMedida.Name = "lblUnidadedeMedida";
            this.lblUnidadedeMedida.Size = new System.Drawing.Size(31, 16);
            this.lblUnidadedeMedida.TabIndex = 2;
            this.lblUnidadedeMedida.Text = "UM";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(222, 51);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(38, 16);
            this.lblLote.TabIndex = 2;
            this.lblLote.Text = "Lote";
            // 
            // lblOdf
            // 
            this.lblOdf.AutoSize = true;
            this.lblOdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdf.Location = new System.Drawing.Point(362, 51);
            this.lblOdf.Name = "lblOdf";
            this.lblOdf.Size = new System.Drawing.Size(39, 16);
            this.lblOdf.TabIndex = 2;
            this.lblOdf.Text = "ODF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nota fiscal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Veiculo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ActiveBorderThickness = 1;
            this.btnSalvar.ActiveCornerRadius = 20;
            this.btnSalvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.IdleBorderThickness = 1;
            this.btnSalvar.IdleCornerRadius = 20;
            this.btnSalvar.IdleFillColor = System.Drawing.Color.White;
            this.btnSalvar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.Location = new System.Drawing.Point(4, 354);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(437, 41);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 25);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(169, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(3, 243);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacao.Size = new System.Drawing.Size(437, 112);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.Text = "Solicitante:\r\n\r\n\r\nResponsavel pelo envio:\r\n\r\n\r\nConferente:";
            this.txtObservacao.TextChanged += new System.EventHandler(this.txtObservacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Observações";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPedido);
            this.tabControl1.Controls.Add(this.tabEnviar);
            this.tabControl1.Controls.Add(this.tabReceber);
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 201);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPedido
            // 
            this.tabPedido.Controls.Add(this.lblIdMaterial);
            this.tabPedido.Controls.Add(this.comboUnidadeDeMedida);
            this.tabPedido.Controls.Add(this.label4);
            this.tabPedido.Controls.Add(this.lblNomeProduto);
            this.tabPedido.Controls.Add(this.lblNomeMaterial1);
            this.tabPedido.Controls.Add(this.label8);
            this.tabPedido.Controls.Add(this.label7);
            this.tabPedido.Controls.Add(this.label6);
            this.tabPedido.Controls.Add(this.label12);
            this.tabPedido.Controls.Add(this.label13);
            this.tabPedido.Controls.Add(this.txtQuantidadePedido);
            this.tabPedido.Controls.Add(this.txtlotePedido);
            this.tabPedido.Controls.Add(this.txtOdf);
            this.tabPedido.Controls.Add(this.txtCodigo);
            this.tabPedido.Controls.Add(this.comboPrioridade);
            this.tabPedido.Location = new System.Drawing.Point(4, 22);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedido.Size = new System.Drawing.Size(434, 175);
            this.tabPedido.TabIndex = 1;
            this.tabPedido.Text = "Pedido";
            this.tabPedido.UseVisualStyleBackColor = true;
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.AutoSize = true;
            this.lblIdMaterial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdMaterial.Location = new System.Drawing.Point(79, 48);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(0, 13);
            this.lblIdMaterial.TabIndex = 24;
            // 
            // comboUnidadeDeMedida
            // 
            this.comboUnidadeDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUnidadeDeMedida.FormattingEnabled = true;
            this.comboUnidadeDeMedida.Items.AddRange(new object[] {
            "KG",
            "Pallet",
            "Litro"});
            this.comboUnidadeDeMedida.Location = new System.Drawing.Point(145, 145);
            this.comboUnidadeDeMedida.Name = "comboUnidadeDeMedida";
            this.comboUnidadeDeMedida.Size = new System.Drawing.Size(98, 24);
            this.comboUnidadeDeMedida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ODF";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(120, 115);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(0, 15);
            this.lblNomeProduto.TabIndex = 20;
            // 
            // lblNomeMaterial1
            // 
            this.lblNomeMaterial1.AutoSize = true;
            this.lblNomeMaterial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMaterial1.Location = new System.Drawing.Point(120, 69);
            this.lblNomeMaterial1.Name = "lblNomeMaterial1";
            this.lblNomeMaterial1.Size = new System.Drawing.Size(0, 15);
            this.lblNomeMaterial1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lote";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Unidade de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Código";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Prioridade";
            // 
            // txtQuantidadePedido
            // 
            this.txtQuantidadePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadePedido.Location = new System.Drawing.Point(14, 147);
            this.txtQuantidadePedido.Name = "txtQuantidadePedido";
            this.txtQuantidadePedido.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidadePedido.TabIndex = 4;
            // 
            // txtlotePedido
            // 
            this.txtlotePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlotePedido.Location = new System.Drawing.Point(254, 145);
            this.txtlotePedido.Name = "txtlotePedido";
            this.txtlotePedido.Size = new System.Drawing.Size(168, 22);
            this.txtlotePedido.TabIndex = 6;
            // 
            // txtOdf
            // 
            this.txtOdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdf.Location = new System.Drawing.Point(14, 105);
            this.txtOdf.Name = "txtOdf";
            this.txtOdf.Size = new System.Drawing.Size(100, 22);
            this.txtOdf.TabIndex = 3;
            this.txtOdf.Leave += new System.EventHandler(this.txtOdf_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.comboPrioridade.Location = new System.Drawing.Point(14, 21);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(138, 24);
            this.comboPrioridade.TabIndex = 1;
            this.comboPrioridade.SelectedIndexChanged += new System.EventHandler(this.comboPrioridade_SelectedIndexChanged);
            // 
            // tabEnviar
            // 
            this.tabEnviar.Controls.Add(this.txtLoteEnviado);
            this.tabEnviar.Controls.Add(this.lblLote);
            this.tabEnviar.Controls.Add(this.txtNotaFiscal);
            this.tabEnviar.Controls.Add(this.txtVeiculo);
            this.tabEnviar.Controls.Add(this.txtQuantidadeEnviada);
            this.tabEnviar.Controls.Add(this.lblCodigo);
            this.tabEnviar.Controls.Add(this.label3);
            this.tabEnviar.Controls.Add(this.label11);
            this.tabEnviar.Controls.Add(this.lblQuantidade);
            this.tabEnviar.Controls.Add(this.label10);
            this.tabEnviar.Controls.Add(this.lblNomeMaterial);
            this.tabEnviar.Controls.Add(this.label9);
            this.tabEnviar.Controls.Add(this.lblOdf);
            this.tabEnviar.Controls.Add(this.lblUnidadedeMedida);
            this.tabEnviar.Location = new System.Drawing.Point(4, 22);
            this.tabEnviar.Name = "tabEnviar";
            this.tabEnviar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnviar.Size = new System.Drawing.Size(434, 175);
            this.tabEnviar.TabIndex = 0;
            this.tabEnviar.Text = "Enviar";
            this.tabEnviar.UseVisualStyleBackColor = true;
            // 
            // txtLoteEnviado
            // 
            this.txtLoteEnviado.Location = new System.Drawing.Point(141, 144);
            this.txtLoteEnviado.Name = "txtLoteEnviado";
            this.txtLoteEnviado.Size = new System.Drawing.Size(136, 20);
            this.txtLoteEnviado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lote";
            // 
            // tabReceber
            // 
            this.tabReceber.Controls.Add(this.lblLoteSolicitado);
            this.tabReceber.Controls.Add(this.lblQuantidadeSolicitada);
            this.tabReceber.Controls.Add(this.label20);
            this.tabReceber.Controls.Add(this.label19);
            this.tabReceber.Controls.Add(this.lblLoteMrecebido);
            this.tabReceber.Controls.Add(this.lblCodigoMrecebido);
            this.tabReceber.Controls.Add(this.lblQuantidadeMrecebido);
            this.tabReceber.Controls.Add(this.lblNomeMrecebido);
            this.tabReceber.Controls.Add(this.lblNota);
            this.tabReceber.Controls.Add(this.txtLoteRecebido);
            this.tabReceber.Controls.Add(this.txtQuantidadeRecebida);
            this.tabReceber.Location = new System.Drawing.Point(4, 22);
            this.tabReceber.Name = "tabReceber";
            this.tabReceber.Size = new System.Drawing.Size(434, 175);
            this.tabReceber.TabIndex = 2;
            this.tabReceber.Text = "Receber";
            this.tabReceber.UseVisualStyleBackColor = true;
            // 
            // lblLoteSolicitado
            // 
            this.lblLoteSolicitado.AutoSize = true;
            this.lblLoteSolicitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteSolicitado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLoteSolicitado.Location = new System.Drawing.Point(222, 55);
            this.lblLoteSolicitado.Name = "lblLoteSolicitado";
            this.lblLoteSolicitado.Size = new System.Drawing.Size(110, 16);
            this.lblLoteSolicitado.TabIndex = 11;
            this.lblLoteSolicitado.Text = "Lote solicitado";
            // 
            // lblQuantidadeSolicitada
            // 
            this.lblQuantidadeSolicitada.AutoSize = true;
            this.lblQuantidadeSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeSolicitada.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblQuantidadeSolicitada.Location = new System.Drawing.Point(7, 55);
            this.lblQuantidadeSolicitada.Name = "lblQuantidadeSolicitada";
            this.lblQuantidadeSolicitada.Size = new System.Drawing.Size(160, 16);
            this.lblQuantidadeSolicitada.TabIndex = 12;
            this.lblQuantidadeSolicitada.Text = "Quantidade solicitada";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(179, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 10;
            this.label20.Text = "Lote";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Quantidade";
            // 
            // lblLoteMrecebido
            // 
            this.lblLoteMrecebido.AutoSize = true;
            this.lblLoteMrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteMrecebido.Location = new System.Drawing.Point(222, 92);
            this.lblLoteMrecebido.Name = "lblLoteMrecebido";
            this.lblLoteMrecebido.Size = new System.Drawing.Size(38, 16);
            this.lblLoteMrecebido.TabIndex = 3;
            this.lblLoteMrecebido.Text = "Lote";
            // 
            // lblCodigoMrecebido
            // 
            this.lblCodigoMrecebido.AutoSize = true;
            this.lblCodigoMrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMrecebido.Location = new System.Drawing.Point(7, 13);
            this.lblCodigoMrecebido.Name = "lblCodigoMrecebido";
            this.lblCodigoMrecebido.Size = new System.Drawing.Size(58, 16);
            this.lblCodigoMrecebido.TabIndex = 4;
            this.lblCodigoMrecebido.Text = "Código";
            this.lblCodigoMrecebido.Click += new System.EventHandler(this.lblCodigoMrecebido_Click);
            // 
            // lblQuantidadeMrecebido
            // 
            this.lblQuantidadeMrecebido.AutoSize = true;
            this.lblQuantidadeMrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeMrecebido.Location = new System.Drawing.Point(7, 92);
            this.lblQuantidadeMrecebido.Name = "lblQuantidadeMrecebido";
            this.lblQuantidadeMrecebido.Size = new System.Drawing.Size(88, 16);
            this.lblQuantidadeMrecebido.TabIndex = 5;
            this.lblQuantidadeMrecebido.Text = "Quantidade";
            // 
            // lblNomeMrecebido
            // 
            this.lblNomeMrecebido.AutoSize = true;
            this.lblNomeMrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMrecebido.Location = new System.Drawing.Point(104, 13);
            this.lblNomeMrecebido.Name = "lblNomeMrecebido";
            this.lblNomeMrecebido.Size = new System.Drawing.Size(105, 16);
            this.lblNomeMrecebido.TabIndex = 6;
            this.lblNomeMrecebido.Text = "NomeMaterial";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(120, 92);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(41, 16);
            this.lblNota.TabIndex = 8;
            this.lblNota.Text = "Nota";
            // 
            // txtLoteRecebido
            // 
            this.txtLoteRecebido.Location = new System.Drawing.Point(176, 146);
            this.txtLoteRecebido.Name = "txtLoteRecebido";
            this.txtLoteRecebido.Size = new System.Drawing.Size(143, 20);
            this.txtLoteRecebido.TabIndex = 2;
            // 
            // txtQuantidadeRecebida
            // 
            this.txtQuantidadeRecebida.Location = new System.Drawing.Point(9, 146);
            this.txtQuantidadeRecebida.Name = "txtQuantidadeRecebida";
            this.txtQuantidadeRecebida.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeRecebida.TabIndex = 1;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 394);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitando material";
            this.Load += new System.EventHandler(this.frmEnviaPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPedido.ResumeLayout(false);
            this.tabPedido.PerformLayout();
            this.tabEnviar.ResumeLayout(false);
            this.tabEnviar.PerformLayout();
            this.tabReceber.ResumeLayout(false);
            this.tabReceber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtQuantidadeEnviada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalvar;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Label lblNomeMaterial;
        public System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.Label lblUnidadedeMedida;
        public System.Windows.Forms.Label lblLote;
        public System.Windows.Forms.Label lblOdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLoteRecebido;
        private System.Windows.Forms.TextBox txtQuantidadeRecebida;
        private System.Windows.Forms.Label lblIdMaterial;
        private System.Windows.Forms.ComboBox comboUnidadeDeMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblNomeMaterial1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantidadePedido;
        private System.Windows.Forms.TextBox txtlotePedido;
        private System.Windows.Forms.TextBox txtOdf;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox comboPrioridade;
        public System.Windows.Forms.Label lblLoteMrecebido;
        public System.Windows.Forms.Label lblCodigoMrecebido;
        public System.Windows.Forms.Label lblQuantidadeMrecebido;
        public System.Windows.Forms.Label lblNomeMrecebido;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabEnviar;
        public System.Windows.Forms.TabPage tabReceber;
        public System.Windows.Forms.TabPage tabPedido;
        public System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtLoteEnviado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblLoteSolicitado;
        public System.Windows.Forms.Label lblQuantidadeSolicitada;
        public System.Windows.Forms.Label lblNota;
    }
}