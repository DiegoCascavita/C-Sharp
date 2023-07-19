//Clase: molde para crear objetos
class Bebida
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    //este es un constructor y debe tener el mismo nombre que la clase
    public Bebida(int Nombre, int Cantidad)
    {
        this.Nombre = Nombre;//atributo del objeto 
        this.Cantidad = Cantidad;
    }
    public void Beberse(int CuantoBebio)
    {
        this.Cantidad -= CuantoBebio;
    }
}