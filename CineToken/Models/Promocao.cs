using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CineToken.Models
{
    public class Promocao
    {
        public Promocao(string nome, double desconto, string descricao)
        {
            PromocaoId = Guid.NewGuid();
            Nome = nome;
            Desconto = desconto;
            DataCriacao = DateTime.Now;
            Descricao = descricao;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PromocaoId { get; set; }
        public string Nome { get; set; }
        public string Token { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
        public bool PadraoVenda { get; set; }
    }
}