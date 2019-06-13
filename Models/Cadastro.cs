using System;

namespace Projeto_final.Models
{
    public class Cadastro
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Administrador {get;set;}
        public DateTime DataNascimento {get;set;}
    }
}