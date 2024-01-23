class Persona 
{
    private string nombre;
    private int edad;

    //Propiedades Públicas para acceder alos campos privados
    public string Nombre
    {
        get {return nombre;}
        set {nombre = value;}
    }

    public int Edad
    {
        get {return edad;}
        set
        {
            if(value >= 0)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("La edad no puede ser un valor negativo.")
            }
        }
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}
//---------------------------------------------------------------
class Program
{
    static void Main()
    {
        Persona persona = new Persona();

        persona.Nombre = "Juan";
        persona.Edad = 25;

        persona.MostrarInformacion();
    }
}