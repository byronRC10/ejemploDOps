using System;
using Xunit;

namespace TestProjectX
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaString()
        {
            string esperado = "Cuarenta y uno";
            string actual = "Cuarenta";

            Assert.Equal(esperado,actual);
        }

        [Fact]
        public void PruebaNumeros()
        {
            int esperado = 42;
            int actual = 6 * 7;

            Assert.Equal(esperado, actual);
        }
    }
}
