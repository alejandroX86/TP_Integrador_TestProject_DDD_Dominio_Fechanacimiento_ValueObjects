public class Cliente
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string Email { get; private set; }
    public string Clave { get; private set; }
    public DateTime FechaNacimiento { get; private set; }

    public Cliente(Guid id, string nombre, string email, string clave, DateTime fechaNacimiento)
    {
        Id = id;
        Nombre = nombre;
        Email = email;
        Clave = clave;
        FechaNacimiento = fechaNacimiento;

        if (!EsMayorDeEdad())
        {
            throw new ArgumentException("El cliente debe ser mayor de 18 años.");
        }
    }

    public bool EsMayorDeEdad()
    {
        int edad = DateTime.Today.Year - FechaNacimiento.Year;
        if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
        return edad >= 18;
    }
     }