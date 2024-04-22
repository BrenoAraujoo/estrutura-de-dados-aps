using System.Globalization;
using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Utilitarios
{
    public class LerArquivoInfoDesmatamento
    {
        public static List<InformacoesDesmatamento> Ler(string arquivo)
        {
            var list = new List<InformacoesDesmatamento>();
            string path = "";

            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var directory = new DirectoryInfo(currentDirectory);

            while (directory != null && !directory.Name.Equals("Aps-Estrutura-De-Dados", StringComparison.OrdinalIgnoreCase))
            {
                directory = directory.Parent;
            }


            if (directory != null)
                path = $"{directory.FullName}\\{arquivo}";
            try
            {
                using (StreamReader reader = new(path))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(';');
                        var info = new InformacoesDesmatamento
                        {
                            Data = values[0],
                            AreaDesmatada = double.Parse(values[1], CultureInfo.InvariantCulture),
                            UF = values[2],
                            Municipio = values[3],
                        };

                        list.Add(info);
                    };
                }
                return list;
            }
            catch
            {
                MessageBox.Show("Não foi possivel efetuar a leitura dos arquivos!");
                return null;
            }
        }
    }
}
