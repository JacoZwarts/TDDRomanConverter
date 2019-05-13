using System;
using Xunit;

namespace RomanConverter.Tests
{
    public class RomanConverterTest
    {
        [Fact]
        public void ConvertI()
        {
            Assert.Equal(1, new RomanConverter().ConvertConvertRomanToNumericNumber("I"));
        }

        [Fact]
        public void ConvertII()
        {
            Assert.Equal(2, new RomanConverter().ConvertConvertRomanToNumericNumber("II"));
        }

        [Fact]
        public void ConvertIII()
        {
            Assert.Equal(3, new RomanConverter().ConvertConvertRomanToNumericNumber("III"));
        }

        [Fact]
        public void ConvertIV()
        {
            Assert.Equal(4, new RomanConverter().ConvertConvertRomanToNumericNumber("IV"));
        }

        [Fact]
        public void ConvertV()
        {
            Assert.Equal(5, new RomanConverter().ConvertConvertRomanToNumericNumber("V"));
        }

        [Fact]
        public void ConvertVI()
        {
            Assert.Equal(6, new RomanConverter().ConvertConvertRomanToNumericNumber("VI"));
        }

        [Fact]
        public void ConvertVII()
        {
            Assert.Equal(7, new RomanConverter().ConvertConvertRomanToNumericNumber("VII"));
        }
        [Fact]
        public void ConvertVIII()
        {
            Assert.Equal(8, new RomanConverter().ConvertConvertRomanToNumericNumber("VIII"));
        }

        [Fact]
        public void ConvertIX()
        {
            Assert.Equal(9, new RomanConverter().ConvertConvertRomanToNumericNumber("IX"));
        }
        [Fact]
        public void ConvertX()
        {
            Assert.Equal(10, new RomanConverter().ConvertConvertRomanToNumericNumber("X"));
        }

        [Fact]
        public void ConvertL()
        {
            Assert.Equal(50, new RomanConverter().ConvertConvertRomanToNumericNumber("L"));
        }

        [Fact]
        public void ConvertC()
        {
            Assert.Equal(100, new RomanConverter().ConvertConvertRomanToNumericNumber("C"));
        }

        [Fact]
        public void ConvertD()
        {
            Assert.Equal(500, new RomanConverter().ConvertConvertRomanToNumericNumber("D"));
        }

        [Fact]
        public void ConvertM()
        {
            Assert.Equal(1000, new RomanConverter().ConvertConvertRomanToNumericNumber("M"));
        }

        [Fact]
        public void ConvertXXXVI()
        {
            Assert.Equal(36, new RomanConverter().ConvertConvertRomanToNumericNumber("XXXVI"));
        }

        [Fact]
        public void ConvertMMXII()
        {
            Assert.Equal(2012, new RomanConverter().ConvertConvertRomanToNumericNumber("MMXII"));
        }

        [Fact]
        public void ConvertInvalidRomanValue()
        {
            Exception ex = Assert.Throws<Exception>(() => new RomanConverter().ConvertConvertRomanToNumericNumber("A"));
            Assert.Contains("Invalid roman character", ex.Message);
        }


    }
}