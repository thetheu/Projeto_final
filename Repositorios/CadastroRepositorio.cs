using System;
using System.Collections.Generic;
using System.IO;
using Projeto_final.Models;

namespace Projeto_final.Repositorios
{
    public class CadastroRepositorio
    {

        public List<Cadastro> listaDeClientes = new List<Cadastro>();
        private const string PATH = "Database/Cadastros.csv";
        public void RegistrarUsuario(Cadastro cadastro){

            if (!File.Exists(PATH))
            {   
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                cadastro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.DataNascimento}");
            sw.Close();
        }

        
        public List<Cadastro> Listar()
        {
            string[] cadastro = File.ReadAllLines(PATH);

            foreach (var item in cadastro)
            {
                if (item != null)
                {
                    string [] dados = item.Split(";");
                    Cadastro cadastre = new Cadastro();

                    cadastre.Id = int.Parse(dados[0]);
                    cadastre.Nome = dados[1];
                    cadastre.Email = dados[2];
                    cadastre.Senha = dados[3];
                    cadastre.DataNascimento = DateTime.Parse(dados[4]);

                    listaDeClientes.Add(cadastre);
                    
                    continue;
                }
            }
            return listaDeClientes;
        }

        public Cadastro ObterPor (string email)
        {
            foreach (var item in Listar())
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
    }
}