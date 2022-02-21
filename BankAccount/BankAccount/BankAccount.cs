namespace BankAccountE
{
    public class CuentaBancaria
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string nombrePa, string apellidoPa, string direccionPa, string NITPa, double saldoPa)
        {
            Nombre = nombrePa;
            Apellido = apellidoPa;
            Direccion = direccionPa;
            NIT = NITPa;
            Saldo = saldoPa;
        }
        public double Deposito(double montoPa)
        {
            Saldo = Saldo + montoPa;
            return Saldo;
        }
        public double Retiro(double montoPa)
        {
            if (Saldo > montoPa)
            {
                Saldo = Saldo - montoPa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            return Saldo;
        }
        public void ConsultaSaldo()
        {
            Console.WriteLine($"Saldo:{Saldo}", 18);
        }
        public override string ToString()
        {
            return ($"\nNombre: {Nombre} " +
                      $"\nApellido: {Apellido}" +
                      $"\nDireccion: {Direccion}" +
                      $"\nNIT: {NIT}" +
                      $"\nSaldo: {Saldo}");
        }
    }
}
