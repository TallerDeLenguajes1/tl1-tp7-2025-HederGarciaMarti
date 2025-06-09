using Empleados;
internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleadoNum1 = new Empleado("Heder", "Safe", new DateTime(1990, 10, 19), 's', new DateTime(2008, 09, 05), 150000, Cargo.Especialista);
        Empleado empleadoNum2 = new Empleado("Assuan", "Garcia", new DateTime(1986, 07, 15), 'c', new DateTime(2010, 07, 05), 100000, Cargo.Administrativo);
        Empleado empleadoNum3 = new Empleado("Suel", "Marti", new DateTime(1978, 01, 05), 's', new DateTime(1996, 09, 01), 110000, Cargo.Ingeniero);
        Empleado empleadoNum4 = new Empleado("Nico", "Moreno", new DateTime(1970, 05, 06), 'c', new DateTime(2000, 11, 10), 120000, Cargo.Investigador);
        Empleado empleadoNum5 = new Empleado("Maxi", "Toledo", new DateTime(1940, 08, 20), 'c', new DateTime(1965, 08, 20), 180000, Cargo.Ingeniero);
        Empleado empleadoNum6 = new Empleado("Javier", "Martin", new DateTime(1993, 11, 23), 'c', new DateTime(2005, 01, 07), 200000, Cargo.Auxiliar);
        double salarioNum1, salarioNum2, salarioNum3, salarioNum4, salarioNum5, salarioNum6, salarioTotal;
        int añosJubilacionNum1, añosJubilacionNum2, añosJubilacionNum3, añosJubilacionNum4, añosJubilacionNum5, añosJubilacionNum6;

        salarioNum1 = empleadoNum1.Sueldo;
        añosJubilacionNum1 = empleadoNum1.AñosJubi();

        salarioNum2 = empleadoNum2.Sueldo;
        añosJubilacionNum2 = empleadoNum2.AñosJubi();

        salarioNum3 = empleadoNum3.Sueldo;
        añosJubilacionNum3 = empleadoNum3.AñosJubi();

        salarioNum4 = empleadoNum4.Sueldo;
        añosJubilacionNum4 = empleadoNum4.AñosJubi();

        salarioNum5 = empleadoNum5.Sueldo;
        añosJubilacionNum5 = empleadoNum5.AñosJubi();

        salarioNum6 = empleadoNum6.Sueldo;
        añosJubilacionNum6 = empleadoNum6.AñosJubi();

        salarioTotal = salarioNum1 + salarioNum2 + salarioNum3 + salarioNum4 + salarioNum5 + salarioNum6;
        Console.WriteLine($"Monto Total: {salarioTotal}");

        if (añosJubilacionNum1 <= añosJubilacionNum2 && añosJubilacionNum1 <= añosJubilacionNum3 &&
        añosJubilacionNum1 <= añosJubilacionNum4 && añosJubilacionNum1 <= añosJubilacionNum5
        && añosJubilacionNum1 <= añosJubilacionNum6)
        {
            MostrarDatos(empleadoNum1);
        }
        if (añosJubilacionNum2 <= añosJubilacionNum1 && añosJubilacionNum2 <= añosJubilacionNum3 &&
        añosJubilacionNum2 <= añosJubilacionNum4 && añosJubilacionNum2 <= añosJubilacionNum5
        && añosJubilacionNum2 <= añosJubilacionNum6)
        {
            MostrarDatos(empleadoNum2);
        }
        if (añosJubilacionNum3 <= añosJubilacionNum1 && añosJubilacionNum3 <= añosJubilacionNum2 &&
        añosJubilacionNum3 <= añosJubilacionNum4 && añosJubilacionNum3 <= añosJubilacionNum5
        && añosJubilacionNum3 <= añosJubilacionNum6)
        {
            MostrarDatos(empleadoNum3);
        }
        if (añosJubilacionNum4 <= añosJubilacionNum1 && añosJubilacionNum4 <= añosJubilacionNum2 &&
        añosJubilacionNum4 <= añosJubilacionNum3 && añosJubilacionNum4 <= añosJubilacionNum5
        && añosJubilacionNum4 <= añosJubilacionNum6)
        {
            MostrarDatos(empleadoNum4);
        }
        if (añosJubilacionNum5 <= añosJubilacionNum1 && añosJubilacionNum5 <= añosJubilacionNum2 &&
        añosJubilacionNum5 <= añosJubilacionNum3 && añosJubilacionNum5 <= añosJubilacionNum4
        && añosJubilacionNum5 <= añosJubilacionNum6)
        {
            MostrarDatos(empleadoNum5);
        }
        if (añosJubilacionNum6 <= añosJubilacionNum1 && añosJubilacionNum6 <= añosJubilacionNum2 && 
        añosJubilacionNum6 <= añosJubilacionNum3 && añosJubilacionNum6 <= añosJubilacionNum4
        && añosJubilacionNum6 <= añosJubilacionNum5)
        {
            MostrarDatos(empleadoNum6);
        }

    }
    public static void MostrarDatos(Empleado empleado)
    {
        Console.WriteLine("\tDatos del empleado");
        Console.WriteLine($"Nombre y Apellido: {empleado.Nombre} {empleado.Apellido}");
        Console.WriteLine($"Fecha Nacimiento: {empleado.FechaNacimiento.ToString("dd-mm-yyyy")}");
        Console.WriteLine($"Edad: {empleado.Edad()}");
        if (empleado.EstadoCivil == 'c' || empleado.EstadoCivil == 'C')
        {
            Console.WriteLine("Estado civil: Casado");
        }
        else
        {
            Console.WriteLine("Estado civil: Soltero");
        }
        Console.WriteLine($"Fecha de ingreso: {empleado.FechaIngreso.ToString("dd-mm-yyyy")}" );
        Console.WriteLine($"Antiguedad: {empleado.Antiguedad()}");
        if (empleado.AñosJubi() < 0)
        {
            Console.WriteLine("Puede Jubilarse");
        }else
        {
            Console.WriteLine($"Años restante para jubilacion: {empleado.AñosJubi()}");
        }
        
        Console.WriteLine($"Cargo: {empleado.Cargo}");
        Console.WriteLine($"Basico: {empleado.Sueldo}");
        Console.WriteLine($"Sueldo Final: {empleado.SueldoFinal()}");
    }
}