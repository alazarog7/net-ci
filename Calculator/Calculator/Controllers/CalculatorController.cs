using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController(){}

        [HttpGet("Add/{num1}/{num2}")]
        public async Task<IActionResult> Add(int num1, int num2)
        {
            return Ok(num1 + num2);
        }


        [HttpGet("Multiply/{num1}/{num2}")]
        public async Task<IActionResult> Multiply(int num1, int num2)
        {
            return Ok(num1 * num2);
        }

        [HttpGet("Divition/{num1}/{num2}")]
        public async Task<IActionResult> Divition(int num1, int num2)
        {
            if(num2 == 0)
            {
                return BadRequest();
            }

            return Ok(num1 / num2);
        }
    }
}
