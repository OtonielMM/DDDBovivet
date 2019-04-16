using System;
using DDDBovivet.Domain.Reproducao.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Tests.ValueObjects
{
    [TestClass]
    public class NomeTest
    {
        [TestMethod]
        public void DeveRetornarErroQuandoNomeVazioOuNulo()
        {
            var nome = new Nome("", "asd");
            Assert.IsTrue(nome.Valid);
        }
    }
}
