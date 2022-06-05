using Xunit;
using SimpleBank;

namespace Generate.UnitTests.Services
{
    public class GenerateService_IsGenerateShould
    {
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt3()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 4, 6, 1, 7, 3, 9, 3, 3, 6, 7, 2, 4, 2, 7, 5, 9 });

            Assert.Equal(4, result);
        }
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt5()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 3, 2, 4, 4, 7, 1, 5, 6, 8, 7, 9, 9, 0, 3, 9, 9 });

            Assert.Equal(9, result);
        }
    }
}