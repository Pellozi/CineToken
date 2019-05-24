using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CineToken.Models
{
    public class Filme
    {
        public Filme(string nome)
        {
            FilmeId = Guid.NewGuid();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FilmeId { get; set; }
        public List<Horario> Horarios { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public List<Promocao> Promocoes { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}