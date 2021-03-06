﻿namespace Condominio.DeskTop.Formularios.Informativo
{
    partial class FrmInformativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformativo));
            this.tblCtrlInformativo = new System.Windows.Forms.TabControl();
            this.tabMoradorConsulta = new System.Windows.Forms.TabPage();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvInformativo = new System.Windows.Forms.DataGridView();
            this.tabMoradorCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tblCtrlInformativo.SuspendLayout();
            this.tabMoradorConsulta.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformativo)).BeginInit();
            this.tabMoradorCadastro.SuspendLayout();
            this.groupBoxCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCtrlInformativo
            // 
            this.tblCtrlInformativo.Controls.Add(this.tabMoradorConsulta);
            this.tblCtrlInformativo.Controls.Add(this.tabMoradorCadastro);
            this.tblCtrlInformativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrlInformativo.Location = new System.Drawing.Point(0, 0);
            this.tblCtrlInformativo.Name = "tblCtrlInformativo";
            this.tblCtrlInformativo.SelectedIndex = 0;
            this.tblCtrlInformativo.Size = new System.Drawing.Size(701, 444);
            this.tblCtrlInformativo.TabIndex = 0;
            this.tblCtrlInformativo.Click += new System.EventHandler(this.tblCtrlInformativo_Click);
            // 
            // tabMoradorConsulta
            // 
            this.tabMoradorConsulta.Controls.Add(this.grpPesquisa);
            this.tabMoradorConsulta.Controls.Add(this.dgvInformativo);
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
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.txtConsulta);
            this.grpPesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.grpPesquisa.Location = new System.Drawing.Point(25, 18);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(633, 92);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Consultar Informativos";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título do Informativo";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(10, 43);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(346, 23);
            this.txtConsulta.TabIndex = 0;
            this.txtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyUp);
            // 
            // dgvInformativo
            // 
            this.dgvInformativo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInformativo.Location = new System.Drawing.Point(12, 133);
            this.dgvInformativo.Name = "dgvInformativo";
            this.dgvInformativo.RowTemplate.Height = 20;
            this.dgvInformativo.Size = new System.Drawing.Size(675, 251);
            this.dgvInformativo.TabIndex = 0;
            this.dgvInformativo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInformativo_CellMouseDoubleClick);
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
            this.groupBoxCadastrar.Controls.Add(this.label2);
            this.groupBoxCadastrar.Controls.Add(this.txtCodigo);
            this.groupBoxCadastrar.Controls.Add(this.label8);
            this.groupBoxCadastrar.Controls.Add(this.txtDescricao);
            this.groupBoxCadastrar.Controls.Add(this.label4);
            this.groupBoxCadastrar.Controls.Add(this.txtTitulo);
            this.groupBoxCadastrar.Controls.Add(this.btnExcluir);
            this.groupBoxCadastrar.Controls.Add(this.btnAtualizar);
            this.groupBoxCadastrar.Controls.Add(this.btnInserir);
            this.groupBoxCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBoxCadastrar.Location = new System.Drawing.Point(23, 19);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(631, 336);
            this.groupBoxCadastrar.TabIndex = 0;
            this.groupBoxCadastrar.TabStop = false;
            this.groupBoxCadastrar.Text = "Cadastrar Informativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 158);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(614, 118);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(14, 97);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(313, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExcluir.Location = new System.Drawing.Point(337, 290);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(152, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = " Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(175, 290);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 40);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "  Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInserir.Location = new System.Drawing.Point(13, 290);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(152, 40);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = " Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FrmInformativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 444);
            this.Controls.Add(this.tblCtrlInformativo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informativo";
            this.Load += new System.EventHandler(this.FrmInformativo_Load);
            this.tblCtrlInformativo.ResumeLayout(false);
            this.tabMoradorConsulta.ResumeLayout(false);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformativo)).EndInit();
            this.tabMoradorCadastro.ResumeLayout(false);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblCtrlInformativo;
        private System.Windows.Forms.TabPage tabMoradorConsulta;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvInformativo;
        private System.Windows.Forms.TabPage tabMoradorCadastro;
        private System.Windows.Forms.GroupBox groupBoxCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}