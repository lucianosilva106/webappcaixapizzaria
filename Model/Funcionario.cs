using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webappcaixapizzaria.Model
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Fun_nome")]
        public string Fun_nome { get; set; }

        [Column("Fun_chapeira")]
        public string Fun_chapeira { get; set; }

        [Column("Fun_login")]
        public string Fun_login { get; set; }

        [Column("Fun_senha")]
        public string Fun_senha { get; set; }

    }
}
