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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcurarInscrição = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Participante - Ele";
            // 
            // txtELEBusca
            // 
            this.txtELEBusca.Location = new System.Drawing.Point(30, 97);
            this.txtELEBusca.Name = "txtELEBusca";
            this.txtELEBusca.Size = new System.Drawing.Size(230, 20);
            this.txtELEBusca.TabIndex = 2;
            // 
            // txtELABusca
            // 
            this.txtELABusca.Location = new System.Drawing.Point(33, 157);
            this.txtELABusca.Name = "txtELABusca";
            this.txtELABusca.Size = new System.Drawing.Size(230, 20);
            this.txtELABusca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome da Participante - Ela";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // btnProcurarInscrição
            // 
            this.btnProcurarInscrição.Location = new System.Drawing.Point(268, 356);
            this.btnProcurarInscrição.Name = "btnProcurarInscrição";
            this.btnProcurarInscrição.Size = new System.Drawing.Size(101, 32);
            this.btnProcurarInscrição.TabIndex = 7;
            this.btnProcurarInscrição.Text = "Procurar";
            this.btnProcurarInscrição.UseVisualStyleBackColor = true;
            // 
            // BuscaInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 414);
            this.Controls.Add(this.btnProcurarInscrição);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtELABusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtELEBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaInscricao";
            this.Text = "BuscaInscricao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtELEBusca;
        private System.Windows.Forms.TextBox txtELABusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcurarInscrição;
    }
}