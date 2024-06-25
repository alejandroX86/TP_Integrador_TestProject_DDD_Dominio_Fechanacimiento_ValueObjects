public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Trabajo Practico de Laboratorio de Software");
        Console.WriteLine("Proyecto Hotel: Prueba Unitaria Capa Dominio FechadeNacimiento ValueOjjects");
        Console.WriteLine();
        Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
        Console.WriteLine("Alumnos: Julia Avalos");
        Console.WriteLine("         Leonardo Caceres");
        Console.WriteLine("         Eduardo Arizza");
        Console.WriteLine("         Gonzalo Arizza");
        Console.WriteLine("         Omar Bazar");
        Console.WriteLine("-----------------------------------------------------");
        // Crear instancias de clientes
        DateTime fechaNacimiento1 = new DateTime(1990, 1, 1);
        DateTime fechaNacimiento2 = DateTime.Today.AddYears(-17); // Menos de 18 años

        try
        {
            var cliente1 = new Cliente(Guid.NewGuid(), "John Doe", "john.doe@example.com", "password", fechaNacimiento1);
            Console.WriteLine($"Cliente 1 es mayor de edad: {cliente1.EsMayorDeEdad()}");

            var cliente2 = new Cliente(Guid.NewGuid(), "Jane Doe", "jane.doe@example.com", "password", fechaNacimiento2);
            Console.WriteLine($"Cliente 2 es mayor de edad: {cliente2.EsMayorDeEdad()}");
        }
        catch (ArgumentException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error al crear cliente: {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
        }
    }
}