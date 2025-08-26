using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAsenjo.Classes
{
    internal class PessoaBLL
    {
        private PessoaDAL pessoaDAL = new PessoaDAL();

        public void Inserir(Pessoa pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new Exception("O campo Nome é obrigatório.");

            if (!Validacoes.ValidarTelefone(pessoa.Telefone))
                throw new Exception("Telefone inválido. Use o formato (xx) xxxxx-xxxx.");

            if (!Validacoes.ValidarEmail(pessoa.Email))
                throw new Exception("E-mail inválido.");

            if (!Validacoes.ValidarCEP(pessoa.CEP))
                throw new Exception("CEP inválido. Use o formato 00000-000.");

            pessoaDAL.Inserir(pessoa);
        }

        public List<Pessoa> Listar()
        {
            return pessoaDAL.Listar();
        }

        public void Atualizar(Pessoa pessoa)
        {
            if (pessoa.Id <= 0)
                throw new Exception("ID inválido para atualização.");

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new Exception("O campo Nome é obrigatório.");

            if (!Validacoes.ValidarTelefone(pessoa.Telefone))
                throw new Exception("Telefone inválido.");

            if (!Validacoes.ValidarEmail(pessoa.Email))
                throw new Exception("E-mail inválido.");

            if (!Validacoes.ValidarCEP(pessoa.CEP))
                throw new Exception("CEP inválido.");

            pessoaDAL.Atualizar(pessoa);
        }

        public void Deletar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para exclusão.");

            pessoaDAL.Deletar(id);
        }
    }
}
