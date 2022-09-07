using SampleApp.Core;


namespace SampleAppUnitTests
{
    public class PhonewordTranslatorTests
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
        public void should_translate_word_to_number()
        {
            // arrange
            var sample = "fiskpinnar";

            // act
            var result = PhonewordTranslator.ToNumber(sample);

            // assert
            result.Should().Be("3475746627");
        }
        [Fact]
        public void should_translate_word_with_number()
        {
            // arrange
            var sample = "3is5pinna7";

            // act
            var result = PhonewordTranslator.ToNumber(sample);

            // assert
            result.Should().Be("3475746627");
        }
        [Fact]
        public void should_return_null()
        {
            // arrange
            var sample = "едц";

            // act
            var result = PhonewordTranslator.ToNumber(sample);

            // assert
            result.Should().Be(null);
        }
    }
    public class BinaryTranslatorTests
    {
        [Fact]
        public void should_return_binary_translation()
        {
            // arrange
            var sample = "fiskpinnar mums";

            // act
            var result = BinaryTranslator.TranslateToBinary(sample);

            // assert
            result.Should().Be("011001100110100101110011011010110111000001101001011011100110111001100001011100100010000001101101011101010110110101110011");
        }
    }
}