public class Camion : Vehiculo, ITransporte
{
    public double CapacidadDeCarga { get; set; }

    public void Iniciar()
    {
        MessageBox.Show("El camión está encendido y listo para moverse.");
    }

    public override void Mover()
    {
        MessageBox.Show("El camión está en movimiento.");
    }

    public override void Detener()
    {
        MessageBox.Show("El camión se ha detenido.");
    }
  

        public override string ToString()
        {
            return $"{Marca} {Modelo} - Camion - Capacidad de Carga: {CapacidadDeCarga} kg";
        }
    
}