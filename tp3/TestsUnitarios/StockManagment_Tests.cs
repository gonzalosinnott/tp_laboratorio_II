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
            string name = "Noise Reduction";
            DateTime dateTime = new DateTime(2012, 12, 31, 16, 45, 0);
            string manufacturer = "EMG";

            miFabrica.AddPart(piece, name, type,dateTime,manufacturer);

            Assert.IsTrue(miFabrica.AddPart(piece, name, type, dateTime, manufacturer));           
        }       
        /// <summary>
        /// Test para probar si existe o no el archivo de stock
        /// </summary>
        [TestMethod]
        public void OpenStockFile_Test()
        {
            Factory miFabrica = new Factory();
            string partsPath = AppDomain.CurrentDomain.BaseDirectory + @"\XMLParts.xml";

            miFabrica.OpenPartsFile(partsPath);

            Assert.IsTrue(miFabrica.OpenPartsFile(partsPath));
        }
        /// <summary>
        /// Test para probar ruta de apertura de archivo de stock invalida
        /// </summary>
        [TestMethod]
        public void OpenStockFileFail_Test()
        {
            Factory miFabrica = new Factory();
            string partsPath = null;

            miFabrica.OpenPartsFile(partsPath);

            Assert.IsFalse(miFabrica.OpenPartsFile(partsPath));
        }
        /// <summary>
        /// Test para probar ruta de guardado
        /// </summary>
        [TestMethod]
        public void SaveStockFile_Test()
        {
            Factory miFabrica = new Factory();
            string partsPath = AppDomain.CurrentDomain.BaseDirectory + @"\XMLParts.xml";

            miFabrica.SavePartsFile(partsPath);

            Assert.IsTrue(miFabrica.SavePartsFile(partsPath));
        }
        /// <summary>
        /// Test para probar ruta  de guardado invalida
        /// </summary>
        [TestMethod]
        public void SaveStockFileFail_Test()
        {
            Factory miFabrica = new Factory();
            string partsPath = null;

            miFabrica.SavePartsFile(partsPath);

            Assert.IsFalse(miFabrica.SavePartsFile(partsPath));
        }


    }
}
