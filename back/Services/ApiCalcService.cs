using ApiCalc.Interfaces;
using ApiCalc.Models;
using static ApiCalc.Services.ApiCalcService;

namespace ApiCalc.Services
{
    public class ApiCalcService: IApiCalcService
    {
        private readonly ICalcCDB _calcCDB;
        private readonly ICalcImposto _calcImposto;

        public ApiCalcService(ICalcCDB calcCDB, ICalcImposto calcImposto)
        {
            _calcCDB = calcCDB;
            _calcImposto = calcImposto;
        }
        public IApiCalcResultado Calc(decimal valor, int prazo) 
        {
            decimal cdb = _calcCDB.CalcCDB(valor, prazo);
            decimal imposto = _calcImposto.CalcImposto(valor, cdb, prazo);

            return new ApiCalcResultado
            {
                ResultBruto = cdb,
                ResultLiquido = cdb - imposto
            };
        }
    }
    public class CalculoCDB : ICalcCDB
    {
        public decimal CalcCDB(decimal valor, int prazo)
        {
            decimal TB = 1.08m;
            decimal CDI = 0.009m;
            decimal valorFinal = valor;

            for (int i = 0; i < prazo; i++)
            {
                valorFinal *= 1 + (CDI * TB);
            }

            return valorFinal;
        }
    }

    public class CalculoImposto : ICalcImposto
    {
        public decimal CalcImposto(decimal valor, decimal valorFinal, int prazo)
        {
            decimal imposto = 0;

            if (prazo <= 6)
            {
                imposto = valorFinal * 0.225m;
            }
            else if (prazo <= 12)
            {
                imposto = valorFinal * 0.20m;
            }
            else if (prazo <= 24)
            {
                imposto = valorFinal * 0.175m;
            }
            else
            {
                imposto = valorFinal * 0.15m;
            }

            return imposto;
        }
    }

}
