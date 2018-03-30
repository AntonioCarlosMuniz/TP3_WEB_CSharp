using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP3_WEB_CSharp.Models;

namespace TP3_WEB_CSharp.Lista
{
    public class BancoPessoa
    {
        private static List<PessoaModel> ListaPessoas = new List<PessoaModel>();

        public void adicionarPessoa(PessoaModel p)
        {
            PessoaModel pessoa = new PessoaModel()
            {
                Id = ListaPessoas.Count() + 1,
                Nome = p.Nome,
                Sobrenome = p.Sobrenome,
                DataNascimento = p.DataNascimento
            };

            ListaPessoas.Add(pessoa);
        }

        public List<PessoaModel> getListaPessoas() 
        {
            return ListaPessoas;
        }

        public PessoaModel BuscarPessoa(int id)
        {
            PessoaModel pessoa = new PessoaModel();

            foreach (var p in ListaPessoas)
            {
                if (p.Id == id) 
                {
                    pessoa.Id = p.Id;
                    pessoa.Nome = p.Nome;
                    pessoa.Sobrenome = p.Sobrenome;
                    pessoa.DataNascimento = p.DataNascimento;
                }
            }

            return pessoa;
        }

        public void AtualizarPessoa(PessoaModel pessoa)
        {
            foreach (var p in ListaPessoas)
            {
                if (p.Id == pessoa.Id)
                {
                    p.Nome = pessoa.Nome;
                    p.Sobrenome = pessoa.Sobrenome;
                    p.DataNascimento = pessoa.DataNascimento;
                    break;
                }
            }
        }

        public void RemoverPessoa(PessoaModel pessoa)
        {
            int posicaoEncontrada = ListaPessoas.FindIndex(x => x.Id == pessoa.Id);
            ListaPessoas.Remove(ListaPessoas[posicaoEncontrada]);
        }


    }
}