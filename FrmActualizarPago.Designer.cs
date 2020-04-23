namespace Tarea6 {
    partial class FrmActualizarPago {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.CboPréstamos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnCambio = new System.Windows.Forms.Button();
            this.DtgGeneral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // CboClientes
            // 
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(22, 30);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(121, 21);
            this.CboClientes.TabIndex = 0;
            this.CboClientes.SelectedIndexChanged += new System.EventHandler(this.CboClientes_SelectedIndexChanged);
            // 
            // CboPréstamos
            // 
            this.CboPréstamos.Enabled = false;
            this.CboPréstamos.FormattingEnabled = true;
            this.CboPréstamos.Location = new System.Drawing.Point(162, 30);
            this.CboPréstamos.Name = "CboPréstamos";
            this.CboPréstamos.Size = new System.Drawing.Size(121, 21);
            this.CboPréstamos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Préstamo:";
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(325, 28);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(98, 23);
            this.BtnAlta.TabIndex = 4;
            this.BtnAlta.Text = "Agregar Pago";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Visible = false;
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(440, 28);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(98, 23);
            this.BtnBaja.TabIndex = 5;
            this.BtnBaja.Text = "Eliminar Pago";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Visible = false;
            // 
            // BtnCambio
            // 
            this.BtnCambio.Location = new System.Drawing.Point(555, 28);
            this.BtnCambio.Name = "BtnCambio";
            this.BtnCambio.Size = new System.Drawing.Size(98, 23);
            this.BtnCambio.TabIndex = 6;
            this.BtnCambio.Text = "Modificar Pago";
            this.BtnCambio.UseVisualStyleBackColor = true;
            this.BtnCambio.Visible = false;
            // 
            // DtgGeneral
            // 
            this.DtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgGeneral.Location = new System.Drawing.Point(12, 71);
            this.DtgGeneral.Name = "DtgGeneral";
            this.DtgGeneral.Size = new System.Drawing.Size(658, 367);
            this.DtgGeneral.TabIndex = 7;
            // 
            // FrmActualizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.DtgGeneral);
            this.Controls.Add(this.BtnCambio);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboPréstamos);
            this.Controls.Add(this.CboClientes);
            this.Name = "FrmActualizarPago";
            this.Text = "FrmActualizarPago";
            this.Load += new System.EventHandler(this.FrmActualizarPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboClientes;
        private System.Windows.Forms.ComboBox CboPréstamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnCambio;
        private System.Windows.Forms.DataGridView DtgGeneral;
    }
}