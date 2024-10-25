using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionDeVehiculos
{
    public partial class Form1 : Form
    {
        private List<Vehiculo> vehiculos;

        public Form1()
        {
            InitializeComponent();
            vehiculos = new List<Vehiculo>();
            InicializarComboBox();
        }


        private void InicializarComboBox()
        {
            cbTipoVehiculo.Items.Add("Auto");
            cbTipoVehiculo.Items.Add("Camion");
            cbTipoVehiculo.Items.Add("Motocicleta");
            cbTipoVehiculo.Items.Add("Vehículo Eléctrico");
            cbTipoVehiculo.SelectedIndex = 0; 
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Vehiculo vehiculo = null;
            string tipoVehiculo = cbTipoVehiculo.SelectedItem.ToString();

            switch (tipoVehiculo)
            {
                case "Auto":
                    vehiculo = new Auto
                    {
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text
                    };
                    break;

                case "Camion":
                    vehiculo = new Camion
                    {
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        CapacidadDeCarga = Convert.ToDouble(txtCapacidadCarga.Text)
                    };
                    break;

                case "Motocicleta":
                    vehiculo = new Motocicleta
                    {
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text
                    };
                    break;

                case "Vehículo Eléctrico":
                    vehiculo = new VehiculoElectrico
                    {
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        CapacidadDeBateria = Convert.ToDouble(txtCapacidadBateria.Text)
                    };
                    break;
            }

            if (vehiculo != null)
            {
                vehiculos.Add(vehiculo);  
                listVehiculos.Items.Add(vehiculo);  
                LimpiarCampos();
            }
        }

        private Vehiculo ObtenerVehiculoSeleccionado()
        {
            return listVehiculos.SelectedItem as Vehiculo;
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtCapacidadCarga.Clear();
            txtCapacidadBateria.Clear();
        }

       

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = ObtenerVehiculoSeleccionado();

            if (vehiculoSeleccionado is ITransporte transporte)
            {
                transporte.Iniciar();
            }
            else
            {
                MessageBox.Show("El vehículo seleccionado no puede ser iniciado.");
            }
        }

        private void btnMover_Click_1(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = ObtenerVehiculoSeleccionado();

            if (vehiculoSeleccionado is ITransporte transporte)
            {
                transporte.Mover();
            }
            else
            {
                MessageBox.Show("El vehículo seleccionado no puede moverse.");
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = ObtenerVehiculoSeleccionado();

            if (vehiculoSeleccionado is ITransporte transporte)
            {
                transporte.Detener();
            }
            else
            {
                MessageBox.Show("El vehículo seleccionado no puede detenerse.");
            }
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = ObtenerVehiculoSeleccionado();

            if (vehiculoSeleccionado is IElectrico electrico)
            {
                electrico.CargarBateria();
            }
            else
            {
                MessageBox.Show("El vehículo seleccionado no tiene batería para cargar.");
            }
        }

        private void cbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVehiculo = cbTipoVehiculo.SelectedItem.ToString();

            if (tipoVehiculo == "Camion")
            {
                txtCapacidadCarga.Visible = true;
                txtCapacidadBateria.Visible = false;
                lblCapacidadCarga.Visible = true;
                lblCapacidadBateria.Visible = false;
            }
            else if (tipoVehiculo == "Vehículo Eléctrico")
            {
                txtCapacidadCarga.Visible = false;
                txtCapacidadBateria.Visible = true;
                lblCapacidadCarga.Visible = false;
                lblCapacidadBateria.Visible = true;
            }
            else
            {
                
                txtCapacidadCarga.Visible = false;
                txtCapacidadBateria.Visible = false;
                lblCapacidadCarga.Visible = false;
                lblCapacidadBateria.Visible = false;
            }
        }

        private void ActualizarListaVehiculos()
        {
            listVehiculos.Items.Clear();
            foreach (var vehiculo in vehiculos)
            {
                listVehiculos.Items.Add(vehiculo.ToString());
            }
        }
    }
}