using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestNetCore.Enum;
using RestNetCore.Services.Implementations;

namespace RestNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;
        private IPersonService _personService;

        public CalculatorController(ILogger<CalculatorController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet("{firstNumber}/{secundNumber}")]
        public IActionResult Get(string firstNumber, string secundNumber, OperatorsType operators)
        {
            decimal sum;
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                sum = operators switch
                {
                    OperatorsType.addition => ConvertToDecimal(firstNumber) + ConvertToDecimal(secundNumber),
                    OperatorsType.subtraction => ConvertToDecimal(firstNumber) - ConvertToDecimal(secundNumber),
                    OperatorsType.multiplication => ConvertToDecimal(firstNumber) * ConvertToDecimal(secundNumber),
                    OperatorsType.division => ConvertToDecimal(firstNumber) / ConvertToDecimal(secundNumber),
                    OperatorsType.mean => (ConvertToDecimal(firstNumber) + ConvertToDecimal(secundNumber)) /2,
                    _ => 0,
                };
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private static bool IsNumeric(string strNumber)
        {
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out _);

            return isNumber;
        }

        private static decimal ConvertToDecimal(string strNumber)
        {
            return decimal.TryParse(strNumber, out decimal decimalValue) ? decimalValue : 0;
        }
    }
}
