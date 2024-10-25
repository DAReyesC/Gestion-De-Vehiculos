public sealed class Motocicleta : Vehiculo, ITransporte
{
    public void Iniciar()
    {
        MessageBox.Show("La motocicleta está encendida y lista para moverse.");
    }

    public override void Mover()
    {
        MessageBox.Show("La motocicleta está en movimiento.");
    }

    public override void Detener()
    {
        MessageBox.Show("La motocicleta se ha detenido.");
    }

        public override string ToString()
        {
            return $"{Marca} {Modelo} - Motocicleta";
        }
    
}