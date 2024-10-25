namespace GestionDeVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbTipoVehiculo = new ComboBox();
            txtMarca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCapacidadCarga = new Label();
            lblCapacidadBateria = new Label();
            txtModelo = new TextBox();
            txtCapacidadCarga = new TextBox();
            txtCapacidadBateria = new TextBox();
            listVehiculos = new ListBox();
            btnAgregar = new Button();
            btnMover = new Button();
            label7 = new Label();
            btnDetener = new Button();
            btnCargarBateria = new Button();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 8);
            label1.Name = "label1";
            label1.Size = new Size(415, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Flota Empresarial";
            // 
            // cbTipoVehiculo
            // 
            cbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoVehiculo.FormattingEnabled = true;
            cbTipoVehiculo.Location = new Point(261, 91);
            cbTipoVehiculo.Name = "cbTipoVehiculo";
            cbTipoVehiculo.Size = new Size(151, 28);
            cbTipoVehiculo.TabIndex = 1;
            cbTipoVehiculo.SelectedIndexChanged += cbTipoVehiculo_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(261, 138);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(8, 91);
            label2.Name = "label2";
            label2.Size = new Size(239, 23);
            label2.TabIndex = 3;
            label2.Text = "Seleccionar tipo de vehiculo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(176, 138);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(164, 180);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 5;
            label4.Text = "Modelo:";
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCapacidadCarga.Location = new Point(28, 223);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(212, 23);
            lblCapacidadCarga.TabIndex = 6;
            lblCapacidadCarga.Text = "Capacidad De Carga(Kg):";
            lblCapacidadCarga.Visible = false;
            // 
            // lblCapacidadBateria
            // 
            lblCapacidadBateria.AutoSize = true;
            lblCapacidadBateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCapacidadBateria.Location = new Point(7, 267);
            lblCapacidadBateria.Name = "lblCapacidadBateria";
            lblCapacidadBateria.Size = new Size(233, 23);
            lblCapacidadBateria.TabIndex = 7;
            lblCapacidadBateria.Text = "Capacidad de Bateria(Kwh):";
            lblCapacidadBateria.Visible = false;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(261, 180);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 8;
            // 
            // txtCapacidadCarga
            // 
            txtCapacidadCarga.Location = new Point(261, 223);
            txtCapacidadCarga.Name = "txtCapacidadCarga";
            txtCapacidadCarga.Size = new Size(125, 27);
            txtCapacidadCarga.TabIndex = 9;
            txtCapacidadCarga.Visible = false;
            // 
            // txtCapacidadBateria
            // 
            txtCapacidadBateria.Location = new Point(261, 267);
            txtCapacidadBateria.Name = "txtCapacidadBateria";
            txtCapacidadBateria.Size = new Size(125, 27);
            txtCapacidadBateria.TabIndex = 10;
            txtCapacidadBateria.Visible = false;
            // 
            // listVehiculos
            // 
            listVehiculos.FormattingEnabled = true;
            listVehiculos.Location = new Point(412, 223);
            listVehiculos.Name = "listVehiculos";
            listVehiculos.Size = new Size(395, 164);
            listVehiculos.TabIndex = 11;
            listVehiculos.SelectedIndexChanged += cbTipoVehiculo_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(210, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(577, 132);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(94, 29);
            btnMover.TabIndex = 13;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(412, 197);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 14;
            label7.Text = "Lista de vehiculos:";
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(577, 174);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 15;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnCargarBateria
            // 
            btnCargarBateria.Location = new Point(463, 408);
            btnCargarBateria.Name = "btnCargarBateria";
            btnCargarBateria.Size = new Size(197, 29);
            btnCargarBateria.TabIndex = 16;
            btnCargarBateria.Text = "Cargar Bateria";
            btnCargarBateria.UseVisualStyleBackColor = true;
            btnCargarBateria.Click += btnCargarBateria_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(577, 91);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 17;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 450);
            Controls.Add(btnIniciar);
            Controls.Add(btnCargarBateria);
            Controls.Add(btnDetener);
            Controls.Add(label7);
            Controls.Add(btnMover);
            Controls.Add(btnAgregar);
            Controls.Add(listVehiculos);
            Controls.Add(txtCapacidadBateria);
            Controls.Add(txtCapacidadCarga);
            Controls.Add(txtModelo);
            Controls.Add(lblCapacidadBateria);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(cbTipoVehiculo);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTipoVehiculo;
        private TextBox txtMarca;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCapacidadCarga;
        private Label lblCapacidadBateria;
        private TextBox txtModelo;
        private TextBox txtCapacidadCarga;
        private TextBox txtCapacidadBateria;
        private ListBox listVehiculos;
        private Button btnAgregar;
        private Button btnMover;
        private Label label7;
        private Button btnDetener;
        private Button btnCargarBateria;
        private Button btnIniciar;
    }
}
