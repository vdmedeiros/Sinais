using Sinais;
using System;
using Xunit;

namespace Test
{
    public class Exercicio1Test
    {
        [Fact]
        public void sinais_balanceados_ok()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("{{[[(())]]}}"));
        }
        
        [Fact]
        public void sinais_balanceados_nok()
        {
            var sinais = new BalanceaSinal();
            Assert.True(sinais.SinaisBalanceados("{[[[(())]]}}"));
        }
    }
}
