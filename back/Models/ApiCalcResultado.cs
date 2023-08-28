using ApiCalc.Interfaces;

namespace ApiCalc.Models
{
    public class ApiCalcResultado: IApiCalcResultado
    {
        public decimal ResultBruto { get; set; }
        public decimal ResultLiquido { get; set; }
    }
}
