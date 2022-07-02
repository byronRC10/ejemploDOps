using System;
using Xunit;

namespace TestProjectX
{
    public class UnitTest1
    {
        [Fact]
        public void ThisTestShouldPass()
        {
            Assert.False(false,"This should pass");
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
