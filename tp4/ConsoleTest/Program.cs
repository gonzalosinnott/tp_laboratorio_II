using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory miFabrica = new Factory();
            Part part;
            DateTime dateTime = new DateTime(2019, 7, 25);
            string partsPath = AppDomain.CurrentDomain.BaseDirectory + "XMLParts.xml";

            ///INGRESO DE STOCK
            Console.WriteLine("INGRESO DE STOCK\n");           

            part = new Pickup { Name = "Noise Reduction", Type = "HUMBUCKER", EntryDate = dateTime, Manufacturer = "EMG" };
            miFabrica.PartsList.Add(part);

            part = new Pickup { Name = "METAL ZONE", Type = "SINGLECOIL", EntryDate = dateTime, Manufacturer = "DIMARZIO" };
            miFabrica.PartsList.Add(part);

            part = new Pickup { Name = "BLUES WAVES", Type = "P90", EntryDate = dateTime, Manufacturer = "EMG" };
            miFabrica.PartsList.Add(part);

            Console.WriteLine(miFabrica.ShowPartsData());

            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();

            ///ELIMINACION DE UN ITEM
            Console.WriteLine("Eliminacion de Primer Item\n");
            miFabrica.removePart(1);
            Console.WriteLine(miFabrica.ShowPartsData());

            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();

            ///GUARDADO DE ARCHIVOS
            Console.WriteLine("Prueba de apertura y guardado de Archivo\n");
            
            if (miFabrica.SavePartsFile(partsPath) == true)
            {
                Console.WriteLine("Archivo guardado con exito\n");

            }
            else
            {
                Console.WriteLine("Error archivo no guardado.\n");

            }
            
            if (miFabrica.OpenPartsFile(partsPath) == true)
            {
                Console.WriteLine("Archivo abierto con exito\n");

            }
            else
            {
                Console.WriteLine("Error archivo no existente.\n");

            }

            Console.WriteLine("Presione una tecla para finalizar.\n");
            Console.ReadKey();

        }
    }
}
