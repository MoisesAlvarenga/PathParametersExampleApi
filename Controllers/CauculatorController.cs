using Microsoft.AspNetCore.Mvc;
using RestApi.Services;

namespace RestApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;
    public CalculatorController(ICalculatorService calculatorService){
        _calculatorService = calculatorService;
    }

    [HttpGet("Sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {   

        if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
        {
            var sum = _calculatorService.ConvertToDecimal(firstNumber) + _calculatorService.ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("Subtraction/{firstNumber}/{secondNumber}")]
    public IActionResult Subtraction(string firstNumber, string secondNumber)
    {   

        if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
        {
            var sum = _calculatorService.ConvertToDecimal(firstNumber) - _calculatorService.ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("Division/{firstNumber}/{secondNumber}")]
    public IActionResult Division(string firstNumber, string secondNumber)
    {   

        if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
        {
            var sum = _calculatorService.ConvertToDecimal(firstNumber) / _calculatorService.ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("Multiplication/{firstNumber}/{secondNumber}")]
    public IActionResult Multiplication(string firstNumber, string secondNumber)
    {   

        if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
        {
            var sum = _calculatorService.ConvertToDecimal(firstNumber) * _calculatorService.ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("Mean/{firstNumber}/{secondNumber}")]
    public IActionResult Mean(string firstNumber, string secondNumber)
    {   

        if(_calculatorService.IsNumeric(firstNumber) && _calculatorService.IsNumeric(secondNumber))
        {
            var sum = _calculatorService.ConvertToDecimal(firstNumber) + _calculatorService.ConvertToDecimal(secondNumber) / 2;
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("square-root/{number}")]
    public IActionResult SquareRoot(string number)
    {   

        if(_calculatorService.IsNumeric(number))
        {
            var squareRoot = Math.Sqrt((double)_calculatorService.ConvertToDecimal(number));
            return Ok(squareRoot.ToString());
        }
        return BadRequest("Invalid Input");
    }
}
