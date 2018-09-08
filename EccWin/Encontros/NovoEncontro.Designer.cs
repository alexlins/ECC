namespace EccWin.Encontros
{
    partial class NovoEncontro
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
            this.txtCadastro = new System.Windows.Forms.Label();
            this.chkConfirmado = new System.Windows.Forms.CheckBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.cboQtde = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.chkRealizado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCadastro
            // 
            this.txtCadastro.AutoSize = true;
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(24, 19);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(280, 24);
            this.txtCadastro.TabIndex = 0;
            this.txtCadastro.Text = "Cadastro de Encontro de Casais";
            // 
            // chkConfirmado
            // 
            this.chkConfirmado.AutoSize = true;
            this.chkConfirmado.Location = new System.Drawing.Point(191, 202);
            this.chkConfirmado.Name = "chkConfirmado";
            this.chkConfirmado.Size = new System.Drawing.Size(116, 17);
            this.chkConfirmado.TabIndex = 1;
            this.chkConfirmado.Text = "Evento Confirmado";
            this.chkConfirmado.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(226, 264);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(27, 119);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(105, 20);
            this.dtpInicial.TabIndex = 3;
            // 
            // cboQtde
            // 
            this.cboQtde.FormattingEnabled = true;
            this.cboQtde.Location = new System.Drawing.Point(28, 223);
            this.cboQtde.Name = "cboQtde";
            this.cboQtde.Size = new System.Drawing.Size(121, 21);
            this.cboQtde.TabIndex = 4;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(27, 163);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(368, 20);
            this.txtLocal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade Máxima de casais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Incial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Final";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(191, 119);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(105, 20);
            this.dtpFinal.TabIndex = 10;
            // 
            // chkRealizado
            // 
            this.chkRealizado.AutoSize = true;
            this.chkRealizado.Location = new System.Drawing.Point(191, 225);
            this.chkRealizado.Name = "chkRealizado";
            this.chkRealizado.Size = new System.Drawing.Size(110, 17);
            this.chkRealizado.TabIndex = 11;
            this.chkRealizado.Text = "Evento Realizado";
            this.chkRealizado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.lblResultado);
            this.pnlResultado.Controls.Add(this.btnFechar);
            this.pnlResultado.Location = new System.Drawing.Point(12, 305);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(389, 43);
            this.pnlResultado.TabIndex = 13;
            this.pnlResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(31, 13);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(151, 13);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Evento gravado com sucesso!";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(308, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 20);
            this.txtNome.TabIndex = 14;
            // 
            // NovoEncontro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkRealizado);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.cboQtde);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.chkConfirmado);
            this.Controls.Add(this.txtCadastro);
            this.Name = "NovoEncontro";
            this.Text = "Novo Encontro";
            this.Load += new System.EventHandler(this.NovoEncontro_Load);
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCadastro;
        private System.Windows.Forms.CheckBox chkConfirmado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.ComboBox cboQtde;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.CheckBox chkRealizado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
    }
}