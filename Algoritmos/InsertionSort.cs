using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Algoritmos
{
    public class InsertionSort : IOrdenacao
    {
        public Resultado Ordenar(List<InformacoesDesmatamento> lista)
        {
            long trocas = 0;
            InformacoesDesmatamento aux;
            int j;
            for (int i = 1; i < lista.Count; i++)
            {
                aux = lista[i];
                j = i - 1;
                while (j >= 0 && lista[j].AreaDesmatada > aux.AreaDesmatada)
                {
                    lista[j + 1] = lista[j];
                    j--;
                    trocas++;
                }
                lista[j + 1] = aux;
                trocas++;
            }

            return new Resultado
            {
                Trocas = trocas,
                Lista = lista
            };
        }
    }
}
