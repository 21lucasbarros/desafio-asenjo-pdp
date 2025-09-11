using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioAsenjo.Classes
{
    internal class Validacoes
    {
        public static bool ValidarTelefone(string telefone) =>
            Regex.IsMatch(telefone, @"^\(\d{2}\) \d{5}-\d{4}$");

        public static bool ValidarEmail(string email) =>
            Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool ValidarCEP(string cep) =>
            Regex.IsMatch(cep, @"^\d{5}-\d{3}$");
    }
}
