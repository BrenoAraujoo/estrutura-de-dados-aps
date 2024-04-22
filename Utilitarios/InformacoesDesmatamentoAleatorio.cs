using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Utilitarios
{
    internal class InformacoesDesmatamentoAleatorio
    {

        public static List<InformacoesDesmatamento> GerarLista(int quantidade)
        {
            List<InformacoesDesmatamento> lista = new List<InformacoesDesmatamento>();
            Random random = new Random();

            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            for (int i = 0; i < quantidade; i++)
            {
                InformacoesDesmatamento info = new InformacoesDesmatamento();
                info.Data = $"{random.Next(1, 29):00}/{random.Next(1, 13):00}/{random.Next(2010, 2025)}";
                double areaDesmatadaDouble = random.NextDouble() * (30.00 - 0.1) + 0.1;
                info.AreaDesmatada = double.Parse(areaDesmatadaDouble.ToString("0.##"), CultureInfo.InvariantCulture);
                info.UF = estados[random.Next(estados.Length)];
                info.Municipio = $"Municipio{random.Next(1, 11)}";
                lista.Add(info);
            }

            return lista;
        }
    }
}
