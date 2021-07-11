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
        
        


    }
}
