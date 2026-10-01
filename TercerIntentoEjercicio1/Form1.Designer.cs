namespace TercerIntentoEjercicio1
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblGastoDiario = new System.Windows.Forms.Label();
            this.lblMedioTransporte = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.numericDias = new System.Windows.Forms.NumericUpDown();
            this.trackBarGastoDiario = new System.Windows.Forms.TrackBar();
            this.cmbTransporte = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGastoDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDias, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblImporteTotal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMedioTransporte, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGastoDiario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericDias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarGastoDiario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTransporte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmar, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDias
            // 
            this.lblDias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(3, 13);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(66, 13);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Nº. de Días.";
            // 
            // lblGastoDiario
            // 
            this.lblGastoDiario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGastoDiario.AutoSize = true;
            this.lblGastoDiario.Location = new System.Drawing.Point(3, 56);
            this.lblGastoDiario.Name = "lblGastoDiario";
            this.lblGastoDiario.Size = new System.Drawing.Size(83, 13);
            this.lblGastoDiario.TabIndex = 1;
            this.lblGastoDiario.Text = "Gasto Diario (€).";
            // 
            // lblMedioTransporte
            // 
            this.lblMedioTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMedioTransporte.AutoSize = true;
            this.lblMedioTransporte.Location = new System.Drawing.Point(3, 98);
            this.lblMedioTransporte.Name = "lblMedioTransporte";
            this.lblMedioTransporte.Size = new System.Drawing.Size(108, 13);
            this.lblMedioTransporte.TabIndex = 2;
            this.lblMedioTransporte.Text = "Medio de Transporte.";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(3, 256);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(72, 13);
            this.lblImporteTotal.TabIndex = 3;
            this.lblImporteTotal.Text = "Importe Total.";
            // 
            // numericDias
            // 
            this.numericDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericDias.Location = new System.Drawing.Point(117, 10);
            this.numericDias.Name = "numericDias";
            this.numericDias.Size = new System.Drawing.Size(680, 20);
            this.numericDias.TabIndex = 4;
            // 
            // trackBarGastoDiario
            // 
            this.trackBarGastoDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGastoDiario.Location = new System.Drawing.Point(117, 43);
            this.trackBarGastoDiario.Maximum = 200;
            this.trackBarGastoDiario.Minimum = 10;
            this.trackBarGastoDiario.Name = "trackBarGastoDiario";
            this.trackBarGastoDiario.Size = new System.Drawing.Size(680, 39);
            this.trackBarGastoDiario.TabIndex = 5;
            this.trackBarGastoDiario.Value = 50;
            // 
            // cmbTransporte
            // 
            this.cmbTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTransporte.FormattingEnabled = true;
            this.cmbTransporte.Location = new System.Drawing.Point(117, 94);
            this.cmbTransporte.Name = "cmbTransporte";
            this.cmbTransporte.Size = new System.Drawing.Size(680, 21);
            this.cmbTransporte.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(117, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(680, 275);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "€";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmar.Location = new System.Drawing.Point(679, 408);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(118, 33);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar reserva.";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de gastos de viaje.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGastoDiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblMedioTransporte;
        private System.Windows.Forms.Label lblGastoDiario;
        private System.Windows.Forms.NumericUpDown numericDias;
        private System.Windows.Forms.TrackBar trackBarGastoDiario;
        private System.Windows.Forms.ComboBox cmbTransporte;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

