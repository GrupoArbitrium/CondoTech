﻿namespace Condominio.DeskTop.Formularios.Morador
{
    partial class FrmMorador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMorador));
            this.tblCtrlMorador = new System.Windows.Forms.TabControl();
            this.tabMoradorConsulta = new System.Windows.Forms.TabPage();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDataNascimentoConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.dgvMorador = new System.Windows.Forms.DataGridView();
            this.tabMoradorCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.btnExcluirMorador = new System.Windows.Forms.Button();
            this.btnAtualizarMorador = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserirMorador = new System.Windows.Forms.Button();
            this.txtEmailMorador = new System.Windows.Forms.TextBox();
            this.txtTelefoneCelularMorador = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefoneFixoMorador = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpfMorador = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataNascimentoMorador = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeMorador = new System.Windows.Forms.TextBox();
            this.tblCtrlMorador.SuspendLayout();
            this.tabMoradorConsulta.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorador)).BeginInit();
            this.tabMoradorCadastro.SuspendLayout();
            this.groupBoxCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCtrlMorador
            // 
            this.tblCtrlMorador.Controls.Add(this.tabMoradorConsulta);
            this.tblCtrlMorador.Controls.Add(this.tabMoradorCadastro);
            this.tblCtrlMorador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrlMorador.Location = new System.Drawing.Point(0, 0);
            this.tblCtrlMorador.Name = "tblCtrlMorador";
            this.tblCtrlMorador.SelectedIndex = 0;
            this.tblCtrlMorador.Size = new System.Drawing.Size(701, 444);
            this.tblCtrlMorador.TabIndex = 0;
            this.tblCtrlMorador.Click += new System.EventHandler(this.tblCtrlMorador_Click);
            // 
            // tabMoradorConsulta
            // 
            this.tabMoradorConsulta.Controls.Add(this.grpPesquisa);
            this.tabMoradorConsulta.Controls.Add(this.dgvMorador);
            this.tabMoradorConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabMoradorConsulta.Name = "tabMoradorConsulta";
            this.tabMoradorConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoradorConsulta.Size = new System.Drawing.Size(693, 418);
            this.tabMoradorConsulta.TabIndex = 0;
            this.tabMoradorConsulta.Text = "Consulta";
            this.tabMoradorConsulta.UseVisualStyleBackColor = true;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtDataNascimentoConsulta);
            this.grpPesquisa.Controls.Add(this.label2);
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.txtNomeConsulta);
            this.grpPesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grpPesquisa.Location = new System.Drawing.Point(25, 18);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(633, 92);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Consultar Morador";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(397, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(204, 43);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "     Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDataNascimentoConsulta
            // 
            this.txtDataNascimentoConsulta.Location = new System.Drawing.Point(243, 43);
            this.txtDataNascimentoConsulta.Mask = "00/00/0000";
            this.txtDataNascimentoConsulta.Name = "txtDataNascimentoConsulta";
            this.txtDataNascimentoConsulta.Size = new System.Drawing.Size(130, 23);
            this.txtDataNascimentoConsulta.TabIndex = 2;
            this.txtDataNascimentoConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(7, 43);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(204, 23);
            this.txtNomeConsulta.TabIndex = 0;
            this.txtNomeConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomeConsulta_KeyUp);
            // 
            // dgvMorador
            // 
            this.dgvMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMorador.Location = new System.Drawing.Point(12, 133);
            this.dgvMorador.Name = "dgvMorador";
            this.dgvMorador.Size = new System.Drawing.Size(675, 251);
            this.dgvMorador.TabIndex = 0;
            this.dgvMorador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMorador_CellDoubleClick);
            // 
            // tabMoradorCadastro
            // 
            this.tabMoradorCadastro.Controls.Add(this.groupBoxCadastrar);
            this.tabMoradorCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabMoradorCadastro.Name = "tabMoradorCadastro";
            this.tabMoradorCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoradorCadastro.Size = new System.Drawing.Size(693, 418);
            this.tabMoradorCadastro.TabIndex = 1;
            this.tabMoradorCadastro.Text = "Cadastro";
            this.tabMoradorCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Controls.Add(this.btnExcluirMorador);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizarMorador);
            this.groupBoxCadastrar.Controls.Add(this.label8);
            this.groupBoxCadastrar.Controls.Add(this.btnInserirMorador);
            this.groupBoxCadastrar.Controls.Add(this.txtEmailMorador);
            this.groupBoxCadastrar.Controls.Add(this.txtTelefoneCelularMorador);
            this.groupBoxCadastrar.Controls.Add(this.label6);
            this.groupBoxCadastrar.Controls.Add(this.txtTelefoneFixoMorador);
            this.groupBoxCadastrar.Controls.Add(this.label5);
            this.groupBoxCadastrar.Controls.Add(this.txtCpfMorador);
            this.groupBoxCadastrar.Controls.Add(this.label7);
            this.groupBoxCadastrar.Controls.Add(this.txtDataNascimentoMorador);
            this.groupBoxCadastrar.Controls.Add(this.label4);
            this.groupBoxCadastrar.Controls.Add(this.label9);
            this.groupBoxCadastrar.Controls.Add(this.label3);
            this.groupBoxCadastrar.Controls.Add(this.txtCodigo);
            this.groupBoxCadastrar.Controls.Add(this.txtNomeMorador);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(23, 19);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(631, 336);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Morador";
            // 
            // btnExcluirMorador
            // 
            this.btnExcluirMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnExcluirMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluirMorador.ForeColor = System.Drawing.Color.White;
            this.btnExcluirMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMorador.Image")));
            this.btnExcluirMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExcluirMorador.Location = new System.Drawing.Point(335, 285);
            this.btnExcluirMorador.Name = "btnExcluirMorador";
            this.btnExcluirMorador.Size = new System.Drawing.Size(152, 40);
            this.btnExcluirMorador.TabIndex = 16;
            this.btnExcluirMorador.Text = " Excluir";
            this.btnExcluirMorador.UseVisualStyleBackColor = false;
            this.btnExcluirMorador.Click += new System.EventHandler(this.btnExcluirMorador_Click);
            // 
            // btnAtualizarMorador
            // 
            this.btnAtualizarMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.btnAtualizarMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizarMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarMorador.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarMorador.Image")));
            this.btnAtualizarMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtualizarMorador.Location = new System.Drawing.Point(173, 285);
            this.btnAtualizarMorador.Name = "btnAtualizarMorador";
            this.btnAtualizarMorador.Size = new System.Drawing.Size(152, 40);
            this.btnAtualizarMorador.TabIndex = 15;
            this.btnAtualizarMorador.Text = "  Atualizar";
            this.btnAtualizarMorador.UseVisualStyleBackColor = false;
            this.btnAtualizarMorador.Click += new System.EventHandler(this.btnAtualizarMorador_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-mail*";
            // 
            // btnInserirMorador
            // 
            this.btnInserirMorador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnInserirMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserirMorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirMorador.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInserirMorador.ForeColor = System.Drawing.Color.White;
            this.btnInserirMorador.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirMorador.Image")));
            this.btnInserirMorador.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInserirMorador.Location = new System.Drawing.Point(11, 285);
            this.btnInserirMorador.Name = "btnInserirMorador";
            this.btnInserirMorador.Size = new System.Drawing.Size(152, 40);
            this.btnInserirMorador.TabIndex = 14;
            this.btnInserirMorador.Text = " Inserir";
            this.btnInserirMorador.UseVisualStyleBackColor = false;
            this.btnInserirMorador.Click += new System.EventHandler(this.btnInserirMorador_Click);
            // 
            // txtEmailMorador
            // 
            this.txtEmailMorador.Location = new System.Drawing.Point(15, 211);
            this.txtEmailMorador.Name = "txtEmailMorador";
            this.txtEmailMorador.Size = new System.Drawing.Size(594, 23);
            this.txtEmailMorador.TabIndex = 13;
            // 
            // txtTelefoneCelularMorador
            // 
            this.txtTelefoneCelularMorador.Location = new System.Drawing.Point(237, 160);
            this.txtTelefoneCelularMorador.Mask = "(00)00000-0000";
            this.txtTelefoneCelularMorador.Name = "txtTelefoneCelularMorador";
            this.txtTelefoneCelularMorador.Size = new System.Drawing.Size(201, 23);
            this.txtTelefoneCelularMorador.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone Celular";
            // 
            // txtTelefoneFixoMorador
            // 
            this.txtTelefoneFixoMorador.Location = new System.Drawing.Point(14, 160);
            this.txtTelefoneFixoMorador.Mask = "(00)0000-0000";
            this.txtTelefoneFixoMorador.Name = "txtTelefoneFixoMorador";
            this.txtTelefoneFixoMorador.Size = new System.Drawing.Size(201, 23);
            this.txtTelefoneFixoMorador.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone Fixo";
            // 
            // txtCpfMorador
            // 
            this.txtCpfMorador.Location = new System.Drawing.Point(453, 103);
            this.txtCpfMorador.Mask = "000000000-00";
            this.txtCpfMorador.Name = "txtCpfMorador";
            this.txtCpfMorador.Size = new System.Drawing.Size(154, 23);
            this.txtCpfMorador.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cpf*";
            // 
            // txtDataNascimentoMorador
            // 
            this.txtDataNascimentoMorador.Location = new System.Drawing.Point(233, 103);
            this.txtDataNascimentoMorador.Mask = "00/00/0000";
            this.txtDataNascimentoMorador.Name = "txtDataNascimentoMorador";
            this.txtDataNascimentoMorador.Size = new System.Drawing.Size(202, 23);
            this.txtDataNascimentoMorador.TabIndex = 5;
            this.txtDataNascimentoMorador.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome completo*";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNomeMorador
            // 
            this.txtNomeMorador.Location = new System.Drawing.Point(11, 103);
            this.txtNomeMorador.Name = "txtNomeMorador";
            this.txtNomeMorador.Size = new System.Drawing.Size(204, 23);
            this.txtNomeMorador.TabIndex = 3;
            // 
            // FrmMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.tblCtrlMorador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morador";
            this.Load += new System.EventHandler(this.FrmMorador_Load);
            this.tblCtrlMorador.ResumeLayout(false);
            this.tabMoradorConsulta.ResumeLayout(false);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorador)).EndInit();
            this.tabMoradorCadastro.ResumeLayout(false);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblCtrlMorador;
        private System.Windows.Forms.TabPage tabMoradorConsulta;
        private System.Windows.Forms.TabPage tabMoradorCadastro;
        private System.Windows.Forms.DataGridView dgvMorador;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnInserirMorador;
        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailMorador;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelularMorador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixoMorador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpfMorador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoMorador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeMorador;
        private System.Windows.Forms.Button btnExcluirMorador;
        private System.Windows.Forms.Button btnAtualizarMorador;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoConsulta;
        private System.Windows.Forms.Label label2;
    }
}