namespace RestApi.Services;

public interface ICalculatorService{

    decimal ConvertToDecimal(string number);
  

    bool IsNumeric(string strNumber);
}