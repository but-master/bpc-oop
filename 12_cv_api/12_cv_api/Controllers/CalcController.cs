using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _12_cv_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpPost(Name = "Calculate")]
        public decimal Post([FromBody] CalcDTO calcDTO)
        {
            decimal result = 0;
            switch (calcDTO.Operation)
            {
                case "+":
                    result = calcDTO.Operand1 + calcDTO.Operand2;
                    break;
                case "-":
                    result = calcDTO.Operand1 - calcDTO.Operand2;
                    break;
                case "*":
                    result = calcDTO.Operand1 * calcDTO.Operand2;
                    break;
                case "/":
                    result = calcDTO.Operand1 / calcDTO.Operand2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
