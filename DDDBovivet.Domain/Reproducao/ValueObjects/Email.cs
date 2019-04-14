using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.ValueObject;

namespace DDDBovivet.Domain.Reproducao.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string endEmail)
        {
            EndEmail = endEmail;

            if (String.IsNullOrEmpty(endEmail))
                AddNotification("endEmail", "endereço do e-mail vazio");

        }

        public string EndEmail { get; set; }

    }
}
