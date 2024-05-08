using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido usuario a Qatar Airlines");
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su DNI");
        int dni = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su Edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su Destino");
        string destino = Console.ReadLine();
        Console.WriteLine("Cual es su clase de vuelo? (Economica: 1, Ejecutiva: 2, Primera Clase: 3)");
        int claseVuelo = int.Parse(Console.ReadLine());
        Console.WriteLine("Posee equipaje de mano? (Si: 1, No: 0)");
        int equipajeMano = int.Parse(Console.ReadLine());
        Console.WriteLine("Tiene el equipaje en bodega facturado? (Si: 1, No: 0)");
        int equipajeBodega = int.Parse(Console.ReadLine());
        Console.WriteLine("Viaja con un perro de servicio? (Si: 1, No: 0");
        int perroServicio = int.Parse(Console.ReadLine());

        if( edad >= 2 && edad < 5)
        {
            Console.WriteLine("Ingrese el DNI del acompañante");
            int dniAcompañante = int.Parse(Console.ReadLine());
        }else if (edad > 5 && edad <= 11)
        {
            Console.WriteLine("Desea solicitar el servicio de menor no acompañado? Si: 1, No: 0");
            int smna = int.Parse(Console.ReadLine());

            if(smna == 0)
            {
                int dniAcompañante = int.Parse(Console.ReadLine());
            }
            
        }

        if(equipajeMano == 1)
        {
            Console.WriteLine("Ingrese su cantidad de equipaje");
            int cantEquipaje = int.Parse(Console.ReadLine());
            if(cantEquipaje > 3)
            {
                Console.WriteLine("Excede la cantidad permitida por pasajero");
            }
        }

        if(equipajeBodega == 0)
        {
            Console.write
        }
    }
}