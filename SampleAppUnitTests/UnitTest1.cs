using SampleApp.Core;


namespace SampleAppUnitTests
{
    public class SampleAppTests
    {
        [Fact]
        public void test1()
        {
            // arrange
            int two = 2;
            int three = 3;

            // act
            var result = two + three;

            // assert
            result.Should().Be(5);
        }
        [Fact]
        public void should_translate_number()
        {
            // arrange
            var sample = "fiskpinnar";

            // act
            var result = PhonewordTranslator.ToNumber(sample);

            // assert
            result.Should().Be("3475746627");
        }
    }
}