using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CineToken.Models
{
    public class Horario
    {
        public Horario(DateTime dateTime, DateTime horarioFilme)
        {
            HorarioId = Guid.NewGuid();
            HorarioFilme = dateTime;
            HorarioFilme = horarioFilme;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HorarioId { get; set; }
        public DateTime HorarioFilme { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}