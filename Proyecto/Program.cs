using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto //Nombre del proyecto
{
    public class Estudiante //El proyecto se va a dividir en clases, la primera es la del estudiante la cual contendra toda la informacion de cada estudiante
    {
        //Atributos
        public string NombreCompleto { get; set; }
        public string NumeroDeCedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public void Identificarse() //Metodo: primer menu
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de matrícula de la Casa de Idiomas de la Universidad de Costa Rica");
            Console.WriteLine("Por favor identifíquese:");
            Console.Write("Nombre Completo: ");
            NombreCompleto = Console.ReadLine();
            Console.Write("Número de Cédula: ");
            NumeroDeCedula = Console.ReadLine();
            Console.Write("Teléfono: ");
            Telefono = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {NombreCompleto}");
            Console.WriteLine($"Cédula: {NumeroDeCedula}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Matricula //Esta clase tiene todo lo relacionado a la matricula, como lo son el idioma y el curso a escoger
    {
        public string Idioma { get; set; }
        public string Curso { get; set; }

        public void EscogerIdioma() //Metodo menu 2
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione el idioma que desea matricular:");
                Console.WriteLine("1. Francés");
                Console.WriteLine("2. Inglés");
                Console.WriteLine("3. Japonés");
                Console.WriteLine("4. Italiano");
                Console.WriteLine("5. Portugués");
                Console.Write("Seleccione una opción: ");

                string opcionIdioma = Console.ReadLine();
                switch (opcionIdioma)
                {
                    case "1":
                        Idioma = "Francés";
                        break;
                    case "2":
                        Idioma = "Inglés";
                        break;
                    case "3":
                        Idioma = "Japonés";
                        break;
                    case "4":
                        Idioma = "Italiano";
                        break;
                    case "5":
                        Idioma = "Portugués";
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        continue;
                }
                break;
            }
        }

        public void EscogerCurso() //Metodo escoger curso
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine($"Seleccione el curso de {Idioma}:");
                Console.WriteLine($"1. {Idioma} Nivel 1 L 6pm a 9pm");
                Console.WriteLine($"2. {Idioma} Nivel 2 K 6pm a 9pm");
                Console.WriteLine($"3. {Idioma} Nivel 3 M 6pm a 9pm");
                Console.WriteLine($"4. {Idioma} Nivel 4 J 6pm a 9pm");
                Console.Write("Seleccione una opción: ");

                string opcionCurso = Console.ReadLine();
                switch (opcionCurso)
                {
                    case "1":
                        Curso = $"{Idioma} Nivel 1";
                        break;
                    case "2":
                        Curso = $"{Idioma} Nivel 2";
                        break;
                    case "3":
                        Curso = $"{Idioma} Nivel 3";
                        break;
                    case "4":
                        Curso = $"{Idioma} Nivel 4";
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        continue;
                }
                break;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Idioma: {Idioma}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }

    public class Pago //Ultima clase que tiene los atributos del pago y el metodo para ejecutar el pago
    {
        public float Monto { get; set; }
        public string MetodoPago { get; set; } // "Tarjeta" o "Deposito"
        public string NumeroConfirmacion { get; set; } // Solo para depósito
        public string NumeroTarjeta { get; set; } // Solo para tarjeta
        public string CVV { get; set; } // Solo para tarjeta
        public string FechaCaducidad { get; set; } // Solo para tarjeta (mes/año)

        public void RealizarPago() //Los estudiantes pueden pagar de dos formas, con tarjeta ingresando los datos o con el numero de confirmacion del deposito
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Método de Pago:");
                Console.WriteLine("1. Con Tarjeta");
                Console.WriteLine("2. Con Numero de Confirmación de Depósito");
                Console.Write("Seleccione una opción: ");

                string opcionPago = Console.ReadLine();
                switch (opcionPago)
                {
                    case "1":
                        MetodoPago = "Tarjeta";
                        Console.Write("Ingrese el número de tarjeta: ");
                        NumeroTarjeta = Console.ReadLine();
                        Console.Write("Ingrese el CVV: ");
                        CVV = Console.ReadLine();
                        Console.Write("Ingrese la fecha de caducidad (MM/AAAA): ");
                        FechaCaducidad = Console.ReadLine();
                        break;
                    case "2":
                        MetodoPago = "Deposito";
                        Console.Write("Ingrese el número de confirmación del depósito: ");
                        NumeroConfirmacion = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        continue;
                }
                break;
            }

            Monto = 100000; // Costo fijo para el curso

            Console.Clear();
            Console.WriteLine("Información del Pago:");
            MostrarInformacion();
            Console.WriteLine("\nTodo fue satisfactorio. Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Monto: {Monto:C}");
            Console.WriteLine($"Método de Pago: {MetodoPago}");
            if (MetodoPago == "Tarjeta")
            {
                Console.WriteLine($"Número de Tarjeta: {NumeroTarjeta}");
                Console.WriteLine($"CVV: {CVV}");
                Console.WriteLine($"Fecha de Caducidad: {FechaCaducidad}");
            }
            if (MetodoPago == "Deposito")
            {
                Console.WriteLine($"Número de Confirmación: {NumeroConfirmacion}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.Identificarse();

                Matricula matricula = new Matricula();
                matricula.EscogerIdioma();
                matricula.EscogerCurso();

                Console.Clear();
                Console.WriteLine("Información del estudiante:");
                estudiante.MostrarInformacion();
                Console.WriteLine("\nCurso a matricular:");
                matricula.MostrarInformacion();
                Console.Write("\n¿Está seguro de su confirmación de matrícula? (S/N): ");
                string confirmacion = Console.ReadLine();

                if (confirmacion.ToUpper() == "S")
                {
                    Pago pago = new Pago();
                    pago.RealizarPago();
                }
                else
                {
                    Console.WriteLine("Matrícula cancelada. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}

