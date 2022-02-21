using BankAccountE;
/*Variables*/
int opcion = 0;
double montoPa;
/*Codigo*/
Console.WriteLine("Bienvenido señor usuario.");
Console.WriteLine("===============");

Console.WriteLine("Ingrese sus datos de usuario: ");
Console.WriteLine("Nombre: ");
string nombrePa = Console.ReadLine();
Console.WriteLine("Apellido: ");
string apellidoPa = Console.ReadLine();
Console.WriteLine("Direccion: ");
string direccionPa = Console.ReadLine();
Console.WriteLine("NIT: ");
string NITPa = Console.ReadLine();
Console.WriteLine("Saldo: ");
double saldoPa = int.Parse(Console.ReadLine());

var usuario = new CuentaBancaria(nombrePa, apellidoPa, direccionPa, NITPa, saldoPa);

do
{
    Console.WriteLine($"\n1. Deposito" +
                            $"\n2. Retiro" +
                            $"\n3. Consultar Saldo" +
                            $"\n4. Mostrar informacion de la cuenta" +
                            $"\n5. Salir");

    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese la cantidad a depositar: ");
            montoPa = double.Parse(Console.ReadLine());
            usuario.Deposito(montoPa);
            break;
        case 2:
            Console.WriteLine("Ingrese la cantidad a retirar: ");
            montoPa = double.Parse(Console.ReadLine());
            usuario.Retiro(montoPa);
            break;

        case 3:
            usuario.ConsultaSaldo();
            break;
        case 4:
            Console.WriteLine(usuario);
            break;
        case 5:
            Console.WriteLine("Saliendo");
            break;
        default:
            Console.WriteLine("Opcion invalida, intente de nuevo.");
            break;
    }
} while (opcion != 5);

