namespace Estoque
{
    partial class frmInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgMaterial = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.comboUM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raidDescricao = new System.Windows.Forms.RadioButton();
            this.raidCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblId = new System.Windows.Forms.Label();
            this.btnNovo = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalvar.Location = new System.Drawing.Point(13, 95);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveBorderThickness = 1;
            this.btnExcluir.ActiveCornerRadius = 20;
            this.btnExcluir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcluir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.ButtonText = "Excluir";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.IdleBorderThickness = 1;
            this.btnExcluir.IdleCornerRadius = 20;
            this.btnExcluir.IdleFillColor = System.Drawing.Color.White;
            this.btnExcluir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.Location = new System.Drawing.Point(149, 95);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 36);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgMaterial
            // 
            this.dtgMaterial.AllowUserToAddRows = false;
            this.dtgMaterial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMaterial.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterial,
            this.Codigo,
            this.Descricao,
            this.unidadeDeMedida});
            this.dtgMaterial.DoubleBuffered = true;
            this.dtgMaterial.EnableHeadersVisualStyles = false;
            this.dtgMaterial.HeaderBgColor = System.Drawing.Color.Teal;
            this.dtgMaterial.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dtgMaterial.Location = new System.Drawing.Point(1, 189);
            this.dtgMaterial.Name = "dtgMaterial";
            this.dtgMaterial.ReadOnly = true;
            this.dtgMaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgMaterial.RowHeadersVisible = false;
            this.dtgMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMaterial.Size = new System.Drawing.Size(427, 418);
            this.dtgMaterial.TabIndex = 2;
            this.dtgMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMaterial_CellClick);
            // 
            // idMaterial
            // 
            this.idMaterial.DataPropertyName = "idMaterial";
            this.idMaterial.HeaderText = "idMaterial";
            this.idMaterial.Name = "idMaterial";
            this.idMaterial.ReadOnly = true;
            this.idMaterial.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 25F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nomeMaterial";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // unidadeDeMedida
            // 
            this.unidadeDeMedida.DataPropertyName = "unidadeDeMedida";
            this.unidadeDeMedida.FillWeight = 20F;
            this.unidadeDeMedida.HeaderText = "UM";
            this.unidadeDeMedida.Name = "unidadeDeMedida";
            this.unidadeDeMedida.ReadOnly = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(361, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(12, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // comboUM
            // 
            this.comboUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUM.FormattingEnabled = true;
            this.comboUM.Items.AddRange(new object[] {
            "Kg",
            "Pallet",
            "Litro"});
            this.comboUM.Location = new System.Drawing.Point(145, 20);
            this.comboUM.Name = "comboUM";
            this.comboUM.Size = new System.Drawing.Size(121, 24);
            this.comboUM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unidade de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raidDescricao);
            this.groupBox1.Controls.Add(this.raidCodigo);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(5, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // raidDescricao
            // 
            this.raidDescricao.AutoSize = true;
            this.raidDescricao.Location = new System.Drawing.Point(325, 21);
            this.raidDescricao.Name = "raidDescricao";
            this.raidDescricao.Size = new System.Drawing.Size(73, 17);
            this.raidDescricao.TabIndex = 4;
            this.raidDescricao.TabStop = true;
            this.raidDescricao.Text = "Descrição";
            this.raidDescricao.UseVisualStyleBackColor = true;
            // 
            // raidCodigo
            // 
            this.raidCodigo.AutoSize = true;
            this.raidCodigo.Location = new System.Drawing.Point(261, 21);
            this.raidCodigo.Name = "raidCodigo";
            this.raidCodigo.Size = new System.Drawing.Size(58, 17);
            this.raidCodigo.TabIndex = 4;
            this.raidCodigo.TabStop = true;
            this.raidCodigo.Text = "Código";
            this.raidCodigo.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(7, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(165, 23);
            this.txtPesquisa.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveBorderThickness = 1;
            this.btnBuscar.ActiveCornerRadius = 20;
            this.btnBuscar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuscar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleCornerRadius = 20;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.White;
            this.btnBuscar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Location = new System.Drawing.Point(177, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 37);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(374, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "0";
            // 
            // btnNovo
            // 
            this.btnNovo.ActiveBorderThickness = 1;
            this.btnNovo.ActiveCornerRadius = 20;
            this.btnNovo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNovo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNovo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.ButtonText = "Novo";
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNovo.IdleBorderThickness = 1;
            this.btnNovo.IdleCornerRadius = 20;
            this.btnNovo.IdleFillColor = System.Drawing.Color.White;
            this.btnNovo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNovo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNovo.Location = new System.Drawing.Point(292, 95);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUM);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtgMaterial);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Insumo";
            this.Load += new System.EventHandler(this.frmInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSalvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluir;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDeMedida;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox comboUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton raidDescricao;
        private System.Windows.Forms.RadioButton raidCodigo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuscar;
        private System.Windows.Forms.Label lblId;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNovo;
    }
}