namespace Empleados
{
    public enum Cargo
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
    }
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldo, Cargo cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public DateTime FechaNacimiento { get => fechaNacimiento; }
        public char EstadoCivil { get => estadoCivil; }
        public DateTime FechaIngreso { get => fechaIngreso; }
        public double Sueldo { get => sueldo; }
        public Cargo Cargo { get => cargo; }

        public int Antiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            int antiguedad = fechaActual.Year - fechaIngreso.Year;
            if (fechaActual.Month < fechaIngreso.Month || fechaActual.Month == fechaIngreso.Month && fechaActual.Day < fechaIngreso.Day)
            {
                antiguedad = antiguedad - 1;
            }
            return antiguedad;
        }

        public int Edad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual.Month < fechaNacimiento.Month || fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day)
            {
                edad = edad - 1;
            }
            return edad;
        }
        public int AñosJubi()
        {
            return 65 - Edad();
        }

        private double Adicional()
        {
            double sueldoAdicional = 0;
            int añosAntiguedad = Antiguedad();
            if (añosAntiguedad >= 20)
            {
                sueldoAdicional = sueldo * 0.25;
            }
            else
            {
                sueldoAdicional = sueldo * añosAntiguedad * 0.01;
            }
            if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
            {
                sueldoAdicional = sueldoAdicional * 0.50;
            }
            if (estadoCivil == 'C' || estadoCivil == 'c')
            {
                sueldoAdicional = sueldoAdicional + 150000;
            }
            return sueldoAdicional;
        }
        public double SueldoFinal()
        {
            double sueldoAdicional = Adicional();
            return sueldo + sueldoAdicional;
        }
    }
}