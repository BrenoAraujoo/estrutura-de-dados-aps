using Aps_Estrutura_De_Dados.Dominio;

namespace Aps_Estrutura_De_Dados.Algoritmos
{
    public class HeapSort : IOrdenacao
    {
        public Resultado Ordenar(List<InformacoesDesmatamento> lista)
        {

            int trocas = 0;
            //Heap Sort
            int n = lista.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                aplicarHeap(lista, n, i, trocas);
            }

            for (int j = n - 1; j > 0; j--)
            {
                InformacoesDesmatamento aux = lista[0];
                lista[0] = lista[j];
                lista[j] = aux;
                trocas++;

                aplicarHeap(lista, j, 0, trocas);
            }
            return new Resultado

            {

                Lista = lista,
                Trocas = trocas
            };
        }

        private static void aplicarHeap(List<InformacoesDesmatamento> lista, int n, int i, int trocas)
        {
            int raiz = i;
            int esquerda = 2 * i + 1;
            int direita = 2 * i + 2;


            if (esquerda < n && lista[esquerda].AreaDesmatada > lista[raiz].AreaDesmatada)
            {
                raiz = esquerda;
            }
            if (direita < n && lista[direita].AreaDesmatada > lista[raiz].AreaDesmatada)
            {
                raiz = direita;
            }

            if (raiz != i)
            {
                InformacoesDesmatamento aux = lista[i];
                lista[i] = lista[raiz];
                lista[raiz] = aux;
                trocas++;

                aplicarHeap(lista, n, raiz, trocas);
            }
        }
    }
}
