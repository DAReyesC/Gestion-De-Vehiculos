public class VehiculoElectrico : Vehiculo, ITransporte, IElectrico
{
    public double CapacidadDeBateria { get; set; }

    public void Iniciar()
    {
        MessageBox.Show("El vehículo eléctrico está encendido y listo para moverse.");
    }

    public override void Mover()
    {
        MessageBox.Show("El vehículo eléctrico está en movimiento.");
    }

    public override void Detener()
    {
        MessageBox.Show("El vehículo eléctrico se ha detenido.");
    }

    public void CargarBateria()
    {
        MessageBox.Show("La batería está cargándose.");
    }

        public override string ToString()
        {
            return $"{Marca} {Modelo} - Eléctrico - Batería: {CapacidadDeBateria} kWh";
        }
    
}