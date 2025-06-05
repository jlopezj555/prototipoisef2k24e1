using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Modelo_Planilla;

namespace Ismar_PR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularPlanillaDetalleSimulado()
        {
            Sentencias sentencias = new Sentencias();

            int ifkIdRegistroPlanillaEncabezado = 2;
            int ifkClaveEmpleado = 1234;

            // Ejecuta la funci�n simulada y verifica que se complete sin errores
            bool resultado = sentencias.funCalcularPlanillaDetalleSimulado(ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);

            Assert.IsTrue(resultado); // Verifica que la funci�n se ejecute sin errores
        }
    }
}