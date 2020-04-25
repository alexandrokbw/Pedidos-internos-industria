namespace Estoque
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInsumo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControuPrincipal = new System.Windows.Forms.TabControl();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnEnviado = new System.Windows.Forms.Button();
            this.btnAguardando = new System.Windows.Forms.Button();
            this.dtgPedido = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacãoDetalhadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.tabControuPrincipal.SuspendLayout();
            this.tabPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblSetor);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.btnInsumo);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 45);
            this.panel1.TabIndex = 0;
            // 
            // lblSetor
            // 
            this.lblSetor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSetor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSetor.Location = new System.Drawing.Point(806, 24);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSetor.Size = new System.Drawing.Size(242, 18);
            this.lblSetor.TabIndex = 2;
            this.lblSetor.Text = "Setor";
            this.lblSetor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(790, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(258, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usúario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInsumo
            // 
            this.btnInsumo.ActiveBorderThickness = 1;
            this.btnInsumo.ActiveCornerRadius = 20;
            this.btnInsumo.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnInsumo.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsumo.ActiveLineColor = System.Drawing.Color.White;
            this.btnInsumo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInsumo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInsumo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsumo.BackgroundImage")));
            this.btnInsumo.ButtonText = "Insumo";
            this.btnInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumo.ForeColor = System.Drawing.Color.White;
            this.btnInsumo.IdleBorderThickness = 1;
            this.btnInsumo.IdleCornerRadius = 20;
            this.btnInsumo.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnInsumo.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.btnInsumo.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnInsumo.Location = new System.Drawing.Point(143, 3);
            this.btnInsumo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Size = new System.Drawing.Size(120, 40);
            this.btnInsumo.TabIndex = 0;
            this.btnInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.ActiveBorderThickness = 1;
            this.btnPedidos.ActiveCornerRadius = 20;
            this.btnPedidos.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.btnPedidos.ActiveForecolor = System.Drawing.Color.White;
            this.btnPedidos.ActiveLineColor = System.Drawing.Color.White;
            this.btnPedidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPedidos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.BackgroundImage")));
            this.btnPedidos.ButtonText = "Novo pedido";
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.IdleBorderThickness = 1;
            this.btnPedidos.IdleCornerRadius = 20;
            this.btnPedidos.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPedidos.IdleForecolor = System.Drawing.Color.DarkTurquoise;
            this.btnPedidos.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btnPedidos.Location = new System.Drawing.Point(5, 3);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(120, 40);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // tabControuPrincipal
            // 
            this.tabControuPrincipal.Controls.Add(this.tabPedido);
            this.tabControuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControuPrincipal.Location = new System.Drawing.Point(0, 45);
            this.tabControuPrincipal.Name = "tabControuPrincipal";
            this.tabControuPrincipal.SelectedIndex = 0;
            this.tabControuPrincipal.Size = new System.Drawing.Size(1051, 575);
            this.tabControuPrincipal.TabIndex = 1;
            // 
            // tabPedido
            // 
            this.tabPedido.Controls.Add(this.btnImprimirPedido);
            this.tabPedido.Controls.Add(this.btnHistorico);
            this.tabPedido.Controls.Add(this.btnEnviado);
            this.tabPedido.Controls.Add(this.btnAguardando);
            this.tabPedido.Controls.Add(this.dtgPedido);
            this.tabPedido.Location = new System.Drawing.Point(4, 25);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedido.Size = new System.Drawing.Size(1043, 546);
            this.tabPedido.TabIndex = 1;
            this.tabPedido.Text = "Pedidos";
            this.tabPedido.UseVisualStyleBackColor = true;
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPedido.Location = new System.Drawing.Point(318, 10);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(94, 29);
            this.btnImprimirPedido.TabIndex = 1;
            this.btnImprimirPedido.Text = "Imprimir";
            this.btnImprimirPedido.UseVisualStyleBackColor = true;
            this.btnImprimirPedido.Click += new System.EventHandler(this.btnImprimirPedido_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(217, 10);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(94, 29);
            this.btnHistorico.TabIndex = 1;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnEnviado
            // 
            this.btnEnviado.Location = new System.Drawing.Point(116, 10);
            this.btnEnviado.Name = "btnEnviado";
            this.btnEnviado.Size = new System.Drawing.Size(94, 29);
            this.btnEnviado.TabIndex = 0;
            this.btnEnviado.Text = "Enviado";
            this.btnEnviado.UseVisualStyleBackColor = true;
            this.btnEnviado.Click += new System.EventHandler(this.btnEnviado_Click);
            // 
            // btnAguardando
            // 
            this.btnAguardando.Location = new System.Drawing.Point(15, 10);
            this.btnAguardando.Name = "btnAguardando";
            this.btnAguardando.Size = new System.Drawing.Size(94, 29);
            this.btnAguardando.TabIndex = 0;
            this.btnAguardando.Text = "Aguardando";
            this.btnAguardando.UseVisualStyleBackColor = true;
            this.btnAguardando.Click += new System.EventHandler(this.btnAguardando_Click);
            // 
            // dtgPedido
            // 
            this.dtgPedido.AllowUserToAddRows = false;
            this.dtgPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedido.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.idMaterial,
            this.prioridade,
            this.codigo,
            this.nomeMaterial,
            this.quantidadePedido,
            this.lotePedido,
            this.um,
            this.dataPedido,
            this.horaPedido,
            this.odf,
            this.observacao,
            this.statusPedido});
            this.dtgPedido.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgPedido.DoubleBuffered = true;
            this.dtgPedido.EnableHeadersVisualStyles = false;
            this.dtgPedido.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgPedido.HeaderForeColor = System.Drawing.Color.Lime;
            this.dtgPedido.Location = new System.Drawing.Point(0, 45);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgPedido.RowHeadersVisible = false;
            this.dtgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedido.Size = new System.Drawing.Size(1037, 493);
            this.dtgPedido.TabIndex = 2;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "idPedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.Visible = false;
            // 
            // idMaterial
            // 
            this.idMaterial.DataPropertyName = "idMaterial";
            this.idMaterial.HeaderText = "idMaterial";
            this.idMaterial.Name = "idMaterial";
            this.idMaterial.Visible = false;
            // 
            // prioridade
            // 
            this.prioridade.DataPropertyName = "prioridade";
            this.prioridade.FillWeight = 50F;
            this.prioridade.HeaderText = "Prioridade";
            this.prioridade.Name = "prioridade";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nomeMaterial
            // 
            this.nomeMaterial.DataPropertyName = "nomeMaterial";
            this.nomeMaterial.FillWeight = 200F;
            this.nomeMaterial.HeaderText = "Material";
            this.nomeMaterial.Name = "nomeMaterial";
            // 
            // quantidadePedido
            // 
            this.quantidadePedido.DataPropertyName = "quantidadePedido";
            this.quantidadePedido.FillWeight = 60F;
            this.quantidadePedido.HeaderText = "Quantidade";
            this.quantidadePedido.Name = "quantidadePedido";
            // 
            // lotePedido
            // 
            this.lotePedido.DataPropertyName = "lotePedido";
            this.lotePedido.HeaderText = "Lote";
            this.lotePedido.Name = "lotePedido";
            // 
            // um
            // 
            this.um.DataPropertyName = "um";
            this.um.FillWeight = 25F;
            this.um.HeaderText = "UM";
            this.um.Name = "um";
            // 
            // dataPedido
            // 
            this.dataPedido.DataPropertyName = "dataPedido";
            this.dataPedido.HeaderText = "Data";
            this.dataPedido.Name = "dataPedido";
            // 
            // horaPedido
            // 
            this.horaPedido.DataPropertyName = "horaPedido";
            this.horaPedido.FillWeight = 50F;
            this.horaPedido.HeaderText = "Hora";
            this.horaPedido.Name = "horaPedido";
            // 
            // odf
            // 
            this.odf.DataPropertyName = "odf";
            this.odf.FillWeight = 50F;
            this.odf.HeaderText = "ODF";
            this.odf.Name = "odf";
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "Observaçõoes";
            this.observacao.Name = "observacao";
            this.observacao.Visible = false;
            // 
            // statusPedido
            // 
            this.statusPedido.DataPropertyName = "statusPedido";
            this.statusPedido.HeaderText = "Status";
            this.statusPedido.Name = "statusPedido";
            this.statusPedido.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.enviarPedidoToolStripMenuItem,
            this.receberPedidoToolStripMenuItem,
            this.informacãoDetalhadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 92);
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo pedido";
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // enviarPedidoToolStripMenuItem
            // 
            this.enviarPedidoToolStripMenuItem.Name = "enviarPedidoToolStripMenuItem";
            this.enviarPedidoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.enviarPedidoToolStripMenuItem.Text = "Enviar pedido";
            this.enviarPedidoToolStripMenuItem.Click += new System.EventHandler(this.enviarPedidoToolStripMenuItem_Click);
            // 
            // receberPedidoToolStripMenuItem
            // 
            this.receberPedidoToolStripMenuItem.Name = "receberPedidoToolStripMenuItem";
            this.receberPedidoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.receberPedidoToolStripMenuItem.Text = "Receber pedido";
            this.receberPedidoToolStripMenuItem.Click += new System.EventHandler(this.receberPedidoToolStripMenuItem_Click);
            // 
            // informacãoDetalhadaToolStripMenuItem
            // 
            this.informacãoDetalhadaToolStripMenuItem.Name = "informacãoDetalhadaToolStripMenuItem";
            this.informacãoDetalhadaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.informacãoDetalhadaToolStripMenuItem.Text = "Informação detalhada";
            this.informacãoDetalhadaToolStripMenuItem.Click += new System.EventHandler(this.informacãoDetalhadaToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 620);
            this.Controls.Add(this.tabControuPrincipal);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.tabControuPrincipal.ResumeLayout(false);
            this.tabPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPedidos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsumo;
        private System.Windows.Forms.TabControl tabControuPrincipal;
        private System.Windows.Forms.TabPage tabPedido;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgPedido;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnEnviado;
        private System.Windows.Forms.Button btnAguardando;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enviarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ToolStripMenuItem receberPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacãoDetalhadaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn um;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn odf;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedido;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

