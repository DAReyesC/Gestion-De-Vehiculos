public class Auto : Vehiculo, ITransporte
{
    public void Iniciar()
    {
        MessageBox.Show("El auto está encendido y listo para moverse.");
    }

    public override void Mover()
    {
        MessageBox.Show("El auto está en movimiento.");
    }

    public override void Detener()
    {
        MessageBox.Show("El auto se ha detenido.");
    }

     public override string ToString()
        {
            return $"{Marca} {Modelo} - Auto";
        }
    
}