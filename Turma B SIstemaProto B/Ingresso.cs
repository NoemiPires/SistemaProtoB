using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaProtoB
{
    public class Ingresso
    {
        public Int16 Id { get; set; }

        [Required]
        public Decimal Valor { get; set; }

        public DateTime Data { get; set; }

        [MaxLength(45)]
        public String? Pessoa { get; set; }
        public Boolean Cancelado { get; set; }

        public override string ToString()
        {
            return Id + ":" + Pessoa + "|" + Cancelado;
        }
    }

}
