using ProyectoFinal;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(4, 4, 8)]
        ////[DataRow(4, 0, -1)]
        ////[DataRow(20, 5, 4)]
        [TestMethod]
        public void Suma_Retonar_Valor(int a, int b, int esperado)
        {
            //Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 8;
            //Act
            int actual = clsCalculadora.Suma(a, b);
            Assert.AreEqual(esperado, actual);

        }
        [DataRow(4, 4, 0)]
        [TestMethod]
        public void Resta_Retonar_Valor(int a, int b, int esperado)
        {
            //Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 0;
            //Act
            int actual = clsCalculadora.Resta(a, b);
            Assert.AreEqual(esperado, actual);
        }

        [DataRow(4, 4, 16)]
        [TestMethod]
        public void Multiplicacion_Retonar_Valor(int a, int b, int esperado)
        {
            //Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 16;
            //Act
            int actual = clsCalculadora.Multiplicacion(a, b);
            Assert.AreEqual(esperado, actual);
        }

        [DataRow(4, 4, 1)]
        [TestMethod]
        public void Division_Retonar_Valor(int a, int b, int esperado)
        {
            //Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 0;
            //Act
            double actual = clsCalculadora.Division(a, b);
            Assert.AreEqual(esperado, actual);
        }


    }
}
