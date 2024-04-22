using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Algoritmos
{
    internal class QuickSort : IOrdenacao
    {
        public Resultado Ordenar(List<InformacoesDesmatamento> lista)
        {
            long trocas = 0;
            int esquerda = 0;
            int direita = lista.Count;
            if (esquerda < direita)
            {
                int p = Particao(lista, esquerda, direita, ref trocas);
                QuickSortRecursivo(lista, esquerda, p, ref trocas);
                QuickSortRecursivo(lista, p + 1, direita, ref trocas);
            }
            return new Resultado
            {
                Trocas = trocas,
                Lista = lista
            };

        }

        private static int Particao(List<InformacoesDesmatamento> lista, int esquerda, int direita, ref long trocas)
        {
            int meio = (int)(esquerda + direita) / 2;
            double pivot = lista[meio].AreaDesmatada;
            int i = esquerda - 1;
            int j = direita;
            while (true)
            {
                do
                {
                    i++;
                } while (lista[i].AreaDesmatada < pivot);
                do
                {
                    j--;
                } while (lista[j].AreaDesmatada > pivot);
                if (i >= j)
                {
                    return j;
                }
                InformacoesDesmatamento aux = lista[i];
                lista[i] = lista[j];
                lista[j] = aux;
                trocas++;
            }
        }
        private static void QuickSortRecursivo(List<InformacoesDesmatamento> lista, int esquerda, int direita, ref long trocas)
        {
            if (esquerda < direita)
            {
                int pi = Particao(lista, esquerda, direita, ref trocas);

                QuickSortRecursivo(lista, esquerda, pi - 1, ref trocas);
                QuickSortRecursivo(lista, pi + 1, direita, ref trocas);
            }
        }
    }
}
