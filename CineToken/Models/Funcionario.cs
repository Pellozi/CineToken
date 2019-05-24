using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CineToken.Models
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, string cargo, string login, string senha, string apelido)
        {
            FuncionarioId = Guid.NewGuid();
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
            Login = login;
            Senha = senha;
            Apelido = string.IsNullOrEmpty(apelido) ? nome : apelido;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Apelido { get; set; }
    }
}