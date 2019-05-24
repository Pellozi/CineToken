using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CineToken.Models
{
    public class Venda
    {
        public Venda(Funcionario funcionario)
        {
            VendaId = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            Funcionario = funcionario;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VendaId { get; set; }
        public DateTime DataCriacao { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<Filme> Filmes { get; set; }
        public double Valor { get; set; }
    }
}