
namespace Projeto_Chamada
{
    partial class Form6
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
            this.lblPalestra = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cmbPalestra = new System.Windows.Forms.ComboBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPalestra
            // 
            this.lblPalestra.AutoSize = true;
            this.lblPalestra.Location = new System.Drawing.Point(42, 39);
            this.lblPalestra.Name = "lblPalestra";
            this.lblPalestra.Size = new System.Drawing.Size(64, 17);
            this.lblPalestra.TabIndex = 0;
            this.lblPalestra.Text = "Palestra:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(49, 87);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(53, 17);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Turma:";
            // 
            // cmbPalestra
            // 
            this.cmbPalestra.FormattingEnabled = true;
            this.cmbPalestra.Location = new System.Drawing.Point(139, 32);
            this.cmbPalestra.Name = "cmbPalestra";
            this.cmbPalestra.Size = new System.Drawing.Size(391, 24);
            this.cmbPalestra.TabIndex = 2;
            this.cmbPalestra.SelectedIndexChanged += new System.EventHandler(this.cmbPalestra_SelectedIndexChanged);
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "1IND",
            "2IND",
            "3IND",
            "1NN",
            "2NN",
            "3NN",
            "1CTI",
            "2CTI"});
            this.cmbTurma.Location = new System.Drawing.Point(139, 80);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(144, 24);
            this.cmbTurma.TabIndex = 3;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(346, 76);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(184, 28);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Gerar relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.Location = new System.Drawing.Point(556, 76);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(184, 28);
            this.btnGerarPdf.TabIndex = 5;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 316);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.cmbPalestra);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblPalestra);
            this.Name = "Form6";
            this.Text = "Relatórios de presença";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalestra;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbPalestra;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnGerarPdf;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}