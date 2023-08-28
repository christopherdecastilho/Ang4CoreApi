using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiCalc.Services;
using ApiCalc.Interfaces;
using ApiCalc.Models;

namespace TestProject1
{
    [TestClass]
    public class ApiCalcServiceTests
    {
        [TestMethod]
        public void Calc_ShouldCalculateResultsCorrectly()
        {
            decimal valor = 1000;
            int prazo = 12;

            ICalcCDB calcCDB = new CalculoCDB();
            ICalcImposto calcImposto = new CalculoImposto();
            IApiCalcService apiCalcService = new ApiCalcService(calcCDB, calcImposto);

            IApiCalcResultado resultado = apiCalcService.Calc(valor, prazo);

            Assert.IsNotNull(resultado);
            Assert.IsTrue(Math.Abs(1123.08m - resultado.ResultBruto) < 0.01m);
            Assert.IsTrue(Math.Abs(898.47m - resultado.ResultLiquido) < 0.01m);
        }
    }
}
