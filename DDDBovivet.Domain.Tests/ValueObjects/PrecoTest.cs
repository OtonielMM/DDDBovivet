using DDDBovivet.Domain.Reproducao.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Tests.ValueObjects
{
    [TestClass]
    public class PrecoTest
    {
        [TestMethod]
        public void PassarValor()
        {
            var valor = new Preco("R$", "120");
            Assert.IsTrue(valor.Valid);

        }
    }
}
