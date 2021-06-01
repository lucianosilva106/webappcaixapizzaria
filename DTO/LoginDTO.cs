using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webappcaixapizzaria.DTO
{
    public class LoginDTO
    {
        public string Log_email { get; set; }

        public string Log_senha { get; set; }

    }
}
