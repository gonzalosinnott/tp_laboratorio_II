using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestsUnitarios
{
    [TestClass]
    public class StockManagment_Tests
    {
        /// <summary>
        /// Test para comprobar si todos los valores de una pieza son cargados al stock
        /// </summary>
        [TestMethod]
        public void AddStock_Test()
        {
            Factory miFabrica = new Factory();

            string piece = "PICKUP";
            string type = "Humbucker";
            string manufacturer = "EMG";

            miFabrica.AddPart(piece, type,manufacturer);

            Assert.IsTrue(miFabrica.AddPart(piece, type, manufacturer));           
        }

        /// <summary>
        /// Test para comprobar la correcta apertura de la tabla Partes de la Base de Datos
        /// </summary>
        [TestMethod]
        public void ReadPartsDB_Test()
        {
            Factory miFabrica = new Factory();
            DAO dao = new DAO();
            bool emptylist = true;

            miFabrica.PartsList = dao.GetAllParts();
            
            if (miFabrica.PartsList.Count != 0)
            {
                emptylist = false;
            }

            Assert.IsFalse(emptylist);
        }

        /// <summary>
        /// Test para comprobar la correcta apertura de la tabla Productos de la Base de Datos
        /// </summary>
        [TestMethod]
        public void ReadProductsDB_Test()
        {
            Factory miFabrica = new Factory();
            DAO dao = new DAO();
            bool emptylist = true;

            miFabrica.GuitarsList = dao.GetAllProducts();

            if (miFabrica.GuitarsList.Count != 0)
            {
                emptylist = false;
            }

            Assert.IsFalse(emptylist);
        }

        /// <summary>
        /// Test para comprobar el guardado en formato PDF
        /// </summary>
        [TestMethod]
        public void SavePDF_Test()
        {
            Factory miFabrica = new Factory();
            string partsPathPdf = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PDFParts.pdf";
            bool test;

            test = miFabrica.CreatePdf(miFabrica.PartsInfo(), partsPathPdf);
            
            Assert.IsTrue(test);
        }

        /// <summary>
        /// Test para comprobar el guardado en formato XML
        /// </summary>
        [TestMethod]
        public void SaveXML_Test()
        {
            Factory miFabrica = new Factory();
            string partsPathXml = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/XMLParts.xml";
            AddStock_Test();
            bool test;

            test = miFabrica.CreateXml(partsPathXml, miFabrica.PartsList);

            Assert.IsTrue(test);
        }
    }
}
