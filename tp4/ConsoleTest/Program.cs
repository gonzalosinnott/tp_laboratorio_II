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
            DAO dao = new DAO();
            string partsPathPdf = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PDFParts.pdf";

            ///INGRESO DE STOCK
            Console.WriteLine("LEYENDO BASE DE DATOS.....\n");
            miFabrica.OpenDB();

            Console.WriteLine("STOCK DE PIEZAS.....\n");
            Console.WriteLine(miFabrica.PartsInfo());
            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();

            Console.WriteLine("STOCK DE PRODUCTOS.....\n");
            Console.WriteLine(miFabrica.ProductsInfo());
            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();

            ///ELIMINACION DE UN ITEM
            Console.WriteLine("ELIMINAR UNA PIEZA.....\n");
            Console.WriteLine("ELIMINAR LA PIEZA WO-2.....\n");
            int id = 8;
            miFabrica.removePart(id);
            dao.DeletePiece(id);
            Console.WriteLine("STOCK DE PIEZAS.....\n");
            Console.WriteLine(miFabrica.PartsInfo());
            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();

            ///GUARDADO DE ARCHIVOS
            Console.WriteLine("GUARDADO DE ARCHIVOS.....\n");
            if (miFabrica.CreatePdf(miFabrica.PartsInfo(), partsPathPdf) ==true)
            {
                Console.WriteLine("ARCHIVO GUARDADO CON EXITO.\n");
            }
            else
            {
                Console.WriteLine("ALGO FALLO.\n");
            }
            Console.WriteLine("Presione una tecla para seguir con la prueba de consola.\n");
            Console.ReadKey();
        }
    }
}
