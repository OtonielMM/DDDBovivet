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
    public class EnderecoTest
    {
        [TestMethod]
        public void ErroSeVazio()
        {
            var endereco = new Endereco("Rua 1", "Cavalieri", "Marilia", "São Paulo",21);
            Assert.IsTrue(endereco.Valid);
        }

    }
}
