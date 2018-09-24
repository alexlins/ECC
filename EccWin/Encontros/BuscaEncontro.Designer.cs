namespace EccWin.Encontros
{
    partial class BuscaEncontro
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.chkIncluirData = new System.Windows.Forms.CheckBox();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.EncontroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventoConfirmado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventoRealizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeCasais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(97, 127);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(278, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(42, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Local";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(155, 88);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(107, 20);
            this.dtpInicial.TabIndex = 6;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(293, 88);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(107, 20);
            this.dtpFinal.TabIndex = 7;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(155, 34);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(285, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // chkIncluirData
            // 
            this.chkIncluirData.AutoSize = true;
            this.chkIncluirData.Location = new System.Drawing.Point(42, 79);
            this.chkIncluirData.Name = "chkIncluirData";
            this.chkIncluirData.Size = new System.Drawing.Size(93, 17);
            this.chkIncluirData.TabIndex = 8;
            this.chkIncluirData.Text = "Filtrar por data";
            this.chkIncluirData.UseVisualStyleBackColor = true;
            this.chkIncluirData.CheckedChanged += new System.EventHandler(this.chkIncluirData_CheckedChanged);
            // 
            // grdResultado
            // 
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EncontroId,
            this.Nome,
            this.Local,
            this.DtInicial,
            this.DtFinal,
            this.EventoConfirmado,
            this.EventoRealizado,
            this.QtdeCasais,
            this.Link});
            this.grdResultado.Location = new System.Drawing.Point(33, 171);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.Size = new System.Drawing.Size(407, 207);
            this.grdResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(144, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(169, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Não foram encontrados resultados";
            this.lblResultado.Visible = false;
            // 
            // EncontroId
            // 
            this.EncontroId.DataPropertyName = "EncontroId";
            this.EncontroId.HeaderText = "Código";
            this.EncontroId.Name = "EncontroId";
            this.EncontroId.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            // 
            // DtInicial
            // 
            this.DtInicial.DataPropertyName = "DtInicial";
            this.DtInicial.HeaderText = "Data Início";
            this.DtInicial.Name = "DtInicial";
            this.DtInicial.Width = 50;
            // 
            // DtFinal
            // 
            this.DtFinal.DataPropertyName = "DtFinal";
            this.DtFinal.HeaderText = "Data Final";
            this.DtFinal.Name = "DtFinal";
            this.DtFinal.Width = 50;
            // 
            // EventoConfirmado
            // 
            this.EventoConfirmado.DataPropertyName = "EventoConfirmado";
            this.EventoConfirmado.HeaderText = "Confirmado";
            this.EventoConfirmado.Name = "EventoConfirmado";
            this.EventoConfirmado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EventoConfirmado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EventoRealizado
            // 
            this.EventoRealizado.DataPropertyName = "EventoRealizado";
            this.EventoRealizado.HeaderText = "Realizado";
            this.EventoRealizado.Name = "EventoRealizado";
            this.EventoRealizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EventoRealizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QtdeCasais
            // 
            this.QtdeCasais.DataPropertyName = "QtdeCasais";
            this.QtdeCasais.HeaderText = "Casais Participantes";
            this.QtdeCasais.Name = "QtdeCasais";
            this.QtdeCasais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QtdeCasais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QtdeCasais.Width = 50;
            // 
            // Link
            // 
            this.Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Link.HeaderText = "";
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.Text = "Detalhes";
            this.Link.UseColumnTextForButtonValue = true;
            // 
            // BuscaEncontro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 413);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkIncluirData);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnProcurar);
            this.Name = "BuscaEncontro";
            this.Text = "Busca Encontro";
            this.Load += new System.EventHandler(this.BuscaEncontro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.CheckBox chkIncluirData;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncontroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventoConfirmado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventoRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeCasais;
        private System.Windows.Forms.DataGridViewButtonColumn Link;
    }
}