using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webappcaixapizzaria.Model
{
    [Table("Caixalancamento")]
    public class Caixalancamento
    {

        [Column("Id")]
        public int Id { get; set; }

        [Column("Idcaixacontrole")]
        public int Idcaixacontrole { get; set; }

        [Column("Datahora")]
        public DateTime Datahora { get; set; }

        [Column("Tipolancamento")]
        public string Tipolancamento { get; set; }

        [Column("Valor")]
        public double Valor { get; set; }

        [Column("Idformapagamento")]
        public int Idformapagamento { get; set; }

        [Column("Observacao")]
        public string Observacao { get; set; }
    }
}
