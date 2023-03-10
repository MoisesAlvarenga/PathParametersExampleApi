namespace RestApi.Services;


public class CalculatorService : ICalculatorService
{
    public decimal ConvertToDecimal(string number)
    {
        decimal decimalValue;
        if(decimal.TryParse(number, out decimalValue)){
            return decimalValue;
        }
        return 0;
    }

    public bool IsNumeric(string strNumber)
    {
        double number;
        bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return isNumber;
    }
}