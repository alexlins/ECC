namespace EccWin.Inscricao
{
    partial class BuscaInscricao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtELEBusca = new System.Windows.Forms.TextBox();
            this.txtELABusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridResultado = new System.Windows.Forms.DataGridView();
            this.btnProcurarInscrição = new System.Windows.Forms.Button();
            this.cboEvento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.NomeEle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encontro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca de Inscrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Participante - Ele";
            // 
            // txtELEBusca
            // 
            this.txtELEBusca.Location = new System.Drawing.Point(26, 69);
            this.txtELEBusca.Name = "txtELEBusca";
            this.txtELEBusca.Size = new System.Drawing.Size(230, 20);
            this.txtELEBusca.TabIndex = 2;
            // 
            // txtELABusca
            // 
            this.txtELABusca.Location = new System.Drawing.Point(26, 108);
            this.txtELABusca.Name = "txtELABusca";
            this.txtELABusca.Size = new System.Drawing.Size(230, 20);
            this.txtELABusca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome da Participante - Ela";
            // 
            // gridResultado
            // 
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeEle,
            this.NomeEla,
            this.Encontro,
            this.Participou});
            this.gridResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridResultado.Location = new System.Drawing.Point(12, 200);
            this.gridResultado.MultiSelect = false;
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RowHeadersVisible = false;
            this.gridResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResultado.Size = new System.Drawing.Size(422, 167);
            this.gridResultado.TabIndex = 5;
            this.gridResultado.Visible = false;
            this.gridResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultado_CellClick);
            this.gridResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultado_CellContentClick);
            // 
            // btnProcurarInscrição
            // 
            this.btnProcurarInscrição.Location = new System.Drawing.Point(57, 144);
            this.btnProcurarInscrição.Name = "btnProcurarInscrição";
            this.btnProcurarInscrição.Size = new System.Drawing.Size(300, 23);
            this.btnProcurarInscrição.TabIndex = 7;
            this.btnProcurarInscrição.Text = "Procurar";
            this.btnProcurarInscrição.UseVisualStyleBackColor = true;
            this.btnProcurarInscrição.Click += new System.EventHandler(this.btnProcurarInscrição_Click);
            // 
            // cboEvento
            // 
            this.cboEvento.FormattingEnabled = true;
            this.cboEvento.Location = new System.Drawing.Point(291, 68);
            this.cboEvento.Name = "cboEvento";
            this.cboEvento.Size = new System.Drawing.Size(121, 21);
            this.cboEvento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Por Encontro";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(133, 222);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(187, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Nenhum registro retornou da consulta.";
            this.lblResultado.Visible = false;
            // 
            // NomeEle
            // 
            this.NomeEle.DataPropertyName = "NomeEle";
            this.NomeEle.HeaderText = "Ele";
            this.NomeEle.Name = "NomeEle";
            // 
            // NomeEla
            // 
            this.NomeEla.DataPropertyName = "NomeEla";
            this.NomeEla.HeaderText = "Ela";
            this.NomeEla.Name = "NomeEla";
            // 
            // Encontro
            // 
            this.Encontro.DataPropertyName = "NomeEncontro";
            this.Encontro.HeaderText = "Encontro";
            this.Encontro.Name = "Encontro";
            // 
            // Participou
            // 
            this.Participou.DataPropertyName = "Participou";
            this.Participou.HeaderText = "Presente";
            this.Participou.Name = "Participou";
            // 
            // BuscaInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 414);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEvento);
            this.Controls.Add(this.btnProcurarInscrição);
            this.Controls.Add(this.gridResultado);
            this.Controls.Add(this.txtELABusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtELEBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaInscricao";
            this.Text = "BuscaInscricao";
            this.Load += new System.EventHandler(this.BuscaInscricao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtELEBusca;
        private System.Windows.Forms.TextBox txtELABusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridResultado;
        private System.Windows.Forms.Button btnProcurarInscrição;
        private System.Windows.Forms.ComboBox cboEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encontro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participou;
    }
}