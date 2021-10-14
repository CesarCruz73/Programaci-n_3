
namespace POO
{
    partial class CuentaBancaria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.MontoMovimientoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrearCruentaButton = new System.Windows.Forms.Button();
            this.AgregarMovimientoButton = new System.Windows.Forms.Button();
            this.MovimientoListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.IdentidadTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(98, 79);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(222, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(98, 33);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(222, 20);
            this.IdentidadTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaldoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumeroCuentaTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(444, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(120, 76);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(222, 20);
            this.SaldoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo:";
            // 
            // NumeroCuentaTextBox
            // 
            this.NumeroCuentaTextBox.Location = new System.Drawing.Point(120, 36);
            this.NumeroCuentaTextBox.Name = "NumeroCuentaTextBox";
            this.NumeroCuentaTextBox.Size = new System.Drawing.Size(222, 20);
            this.NumeroCuentaTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de Cuenta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimientoComboBox);
            this.groupBox3.Controls.Add(this.MontoMovimientoTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(36, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar Movimineto";
            // 
            // TipoMovimientoComboBox
            // 
            this.TipoMovimientoComboBox.FormattingEnabled = true;
            this.TipoMovimientoComboBox.Items.AddRange(new object[] {
            "Depósito",
            "Retiro"});
            this.TipoMovimientoComboBox.Location = new System.Drawing.Point(528, 30);
            this.TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            this.TipoMovimientoComboBox.Size = new System.Drawing.Size(222, 21);
            this.TipoMovimientoComboBox.TabIndex = 5;
            // 
            // MontoMovimientoTextBox
            // 
            this.MontoMovimientoTextBox.Location = new System.Drawing.Point(98, 35);
            this.MontoMovimientoTextBox.Name = "MontoMovimientoTextBox";
            this.MontoMovimientoTextBox.Size = new System.Drawing.Size(222, 20);
            this.MontoMovimientoTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo Movimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto:";
            // 
            // CrearCruentaButton
            // 
            this.CrearCruentaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCruentaButton.Location = new System.Drawing.Point(852, 58);
            this.CrearCruentaButton.Name = "CrearCruentaButton";
            this.CrearCruentaButton.Size = new System.Drawing.Size(111, 41);
            this.CrearCruentaButton.TabIndex = 3;
            this.CrearCruentaButton.Text = "Crear Cuenta";
            this.CrearCruentaButton.UseVisualStyleBackColor = true;
            this.CrearCruentaButton.Click += new System.EventHandler(this.CrearCruentaButton_Click);
            // 
            // AgregarMovimientoButton
            // 
            this.AgregarMovimientoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMovimientoButton.Location = new System.Drawing.Point(852, 185);
            this.AgregarMovimientoButton.Name = "AgregarMovimientoButton";
            this.AgregarMovimientoButton.Size = new System.Drawing.Size(111, 41);
            this.AgregarMovimientoButton.TabIndex = 4;
            this.AgregarMovimientoButton.Text = "Agregar Movimiento";
            this.AgregarMovimientoButton.UseVisualStyleBackColor = true;
            this.AgregarMovimientoButton.Click += new System.EventHandler(this.AgregarMovimientoButton_Click);
            // 
            // MovimientoListBox
            // 
            this.MovimientoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovimientoListBox.FormattingEnabled = true;
            this.MovimientoListBox.ItemHeight = 15;
            this.MovimientoListBox.Location = new System.Drawing.Point(36, 289);
            this.MovimientoListBox.Name = "MovimientoListBox";
            this.MovimientoListBox.Size = new System.Drawing.Size(792, 184);
            this.MovimientoListBox.TabIndex = 5;
            // 
            // CuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 520);
            this.Controls.Add(this.MovimientoListBox);
            this.Controls.Add(this.AgregarMovimientoButton);
            this.Controls.Add(this.CrearCruentaButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CuentaBancaria";
            this.Text = "CuentaBancaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroCuentaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoMovimientoComboBox;
        private System.Windows.Forms.TextBox MontoMovimientoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CrearCruentaButton;
        private System.Windows.Forms.Button AgregarMovimientoButton;
        private System.Windows.Forms.ListBox MovimientoListBox;
    }
}