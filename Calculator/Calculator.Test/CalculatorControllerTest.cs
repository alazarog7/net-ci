using Calculator.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Test
{
    public class CalculatorControllerTest
    {
        private readonly CalculatorController _calculatorController;
        public CalculatorControllerTest()
        {
            _calculatorController = new CalculatorController();
        }

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-2, 4, 2)]
        public async Task Add_ReturnsCorrectSum(int num1, int num2, int expected)
        {
            var result = await _calculatorController.Add(num1, num2) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(expected, result.Value);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(-2, 4, -8)]
        public async Task Multiply_ReturnsCorrectProduct(int num1, int num2, int expected)
        {
            var result = await _calculatorController.Multiply(num1, num2) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(expected, result.Value);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        public async Task Divition_ReturnsCorrectQuotient(int num1, int num2, int expected)
        {
            var result = await _calculatorController.Divition(num1, num2) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(expected, result.Value);
        }

        [Fact]
        public async Task Divition_ByZero_ReturnsBadRequest()
        {
            var result = await _calculatorController.Divition(10, 0);

            Assert.IsType<BadRequestResult>(result);
        }

    }
}
