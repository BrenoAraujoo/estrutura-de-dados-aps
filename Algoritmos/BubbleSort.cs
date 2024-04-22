using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Algoritmos
{
    public class BubbleSort : IOrdenacao
    {
        public Resultado Ordenar(List<InformacoesDesmatamento> lista)
        {
            long trocas = 0;

            InformacoesDesmatamento aux;
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].AreaDesmatada > lista[j].AreaDesmatada)
                    {
                        aux = lista[j];
                        lista[j] = lista[i];
                        lista[i] = aux;
                        trocas++;
                    }
                }
            }

            return new Resultado
            {
                Trocas = trocas,
                Lista = lista
            };
        }
    }
}
