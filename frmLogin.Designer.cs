namespace Estoque
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(41, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 17);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(41, 90);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(156, 17);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________";
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 10;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.White;
            this.btnEntrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.Location = new System.Drawing.Point(29, 152);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(181, 41);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 10;
            this.btnSair.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.White;
            this.btnSair.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSair.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.Location = new System.Drawing.Point(29, 203);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(181, 41);
            this.btnSair.TabIndex = 3;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // comboSetor
            // 
            this.comboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.Location = new System.Drawing.Point(41, 123);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(157, 23);
            this.comboSetor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Procurando banco de dados";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNomeBanco.Location = new System.Drawing.Point(4, 251);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(0, 13);
            this.lblNomeBanco.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 298);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSetor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox comboSetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNomeBanco;
    }
}