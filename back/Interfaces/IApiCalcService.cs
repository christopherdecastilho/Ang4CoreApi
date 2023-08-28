namespace ApiCalc.Interfaces
{
    public interface IApiCalcService
    {
        IApiCalcResultado Calc(decimal valor, int prazo);
    }

    public interface ICalcCDB
    {
        decimal CalcCDB(decimal valor, int prazo);
    }

    public interface ICalcImposto
    {
        decimal CalcImposto(decimal valor, decimal valorFinal, int prazo);
    }
}
