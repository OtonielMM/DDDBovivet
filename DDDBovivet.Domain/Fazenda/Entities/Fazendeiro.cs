using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Fazenda.Entities
{
    public class Fazendeiro
    {

        public Fazendeiro(string nome, string sobrenome, string cnpj, string email)
        {
            Nome1 = nome;
            Sobrenome = sobrenome;
            Cnpj = cnpj;
            Email = email;


            if (string.IsNullOrEmpty(Nome1) || string.IsNullOrEmpty(sobrenome) ||
                string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(email))
                throw new Exception("Nome1, sobrenome, email e CNPJ não devem ser nulos ou vazios");

        }

        public String Nome1 { get; private set; }
        public String Sobrenome { get; private set; }
        public String Cnpj { get; private set; }
        public String Email { get; private set; }
        public String Endereco { get; private set; }
        public bool Active { get; set; }
        public List<Atividades> Atividades { get; set; }
    }
}
