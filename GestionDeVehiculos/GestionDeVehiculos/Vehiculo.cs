public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void Mover();
    public abstract void Detener();

    
    public override string ToString()
    {
        return Marca + " " + Modelo;
    }
}