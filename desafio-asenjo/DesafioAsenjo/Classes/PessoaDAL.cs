using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAsenjo.Classes
{
    internal class PessoaDAL
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Pessoas.accdb";

        public void Inserir(Pessoa pessoa)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sql = @"INSERT INTO Pessoa 
                               (Nome, Telefone, Email, CEP, Estado, Cidade, Bairro, Rua, Numero, Complemento) 
                               VALUES (@Nome, @Telefone, @Email, @CEP, @Estado, @Cidade, @Bairro, @Rua, @Numero, @Complemento)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                cmd.Parameters.AddWithValue("@CEP", pessoa.CEP);
                cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                cmd.Parameters.AddWithValue("@Rua", pessoa.Rua);
                cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
                cmd.Parameters.AddWithValue("@Complemento", pessoa.Complemento);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Pessoa> Listar()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sql = "SELECT * FROM Pessoa";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pessoas.Add(new Pessoa
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = dr["Nome"].ToString(),
                        Telefone = dr["Telefone"].ToString(),
                        Email = dr["Email"].ToString(),
                        CEP = dr["CEP"].ToString(),
                        Estado = dr["Estado"].ToString(),
                        Cidade = dr["Cidade"].ToString(),
                        Bairro = dr["Bairro"].ToString(),
                        Rua = dr["Rua"].ToString(),
                        Numero = dr["Numero"].ToString(),
                        Complemento = dr["Complemento"].ToString()
                    });
                }
            }
            return pessoas;
        }

        public void Atualizar(Pessoa pessoa)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sql = @"UPDATE Pessoa SET 
                               Nome=@Nome, Telefone=@Telefone, Email=@Email, CEP=@CEP, 
                               Estado=@Estado, Cidade=@Cidade, Bairro=@Bairro, Rua=@Rua, 
                               Numero=@Numero, Complemento=@Complemento 
                               WHERE Id=@Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                cmd.Parameters.AddWithValue("@CEP", pessoa.CEP);
                cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                cmd.Parameters.AddWithValue("@Rua", pessoa.Rua);
                cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
                cmd.Parameters.AddWithValue("@Complemento", pessoa.Complemento);
                cmd.Parameters.AddWithValue("@Id", pessoa.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Pessoa ObterPorId(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sql = "SELECT * FROM Pessoa WHERE Id=@Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Pessoa
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = dr["Nome"].ToString(),
                        Telefone = dr["Telefone"].ToString(),
                        Email = dr["Email"].ToString(),
                        CEP = dr["CEP"].ToString(),
                        Estado = dr["Estado"].ToString(),
                        Cidade = dr["Cidade"].ToString(),
                        Bairro = dr["Bairro"].ToString(),
                        Rua = dr["Rua"].ToString(),
                        Numero = dr["Numero"].ToString(),
                        Complemento = dr["Complemento"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }
  
        public void Deletar(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sql = "DELETE FROM Pessoa WHERE Id=@Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
