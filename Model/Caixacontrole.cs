using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webappcaixapizzaria.Model
{
    [Table("Caixacontrole")]
    public class Caixacontrole
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Datahoraabertura")]
        public DateTime Datahoraabertura { get; set; }

        [Column("Idfuncionario")]
        public int Idfuncionario { get; set; }

        [Column("Valorfundocaixa")]
        public double Valorfundocaixa { get; set; }

        [Column("Datahorafechamento")]
        public DateTime Datahorafechamento { get; set; }

        [Column("Valorfinalcaixa")]
        public double Valorfinalcaixa { get; set; }

        [Column("Flagcaixafechado")]
        public int Flagcaixafechado { get; set; }

    }
}
