using Aps_Estrutura_De_Dados.Algoritmos;
using Aps_Estrutura_De_Dados.Dominio;
using Aps_Estrutura_De_Dados.Utilitarios;
using System.Diagnostics;
using System.Text;

namespace Aps_Estrutura_De_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            var arquivoSelecionado = comboBoxArquivo.SelectedItem;

            if (arquivoSelecionado == null)
            {
                MessageBox.Show("Selecione um lista antes de efetuar a leitura!", "Arquivo não selecionado");
                return;
            }

            var arquivo = LerArquivoInfoDesmatamento.Ler(arquivoSelecionado.ToString());
            var sb = new StringBuilder();

            foreach (var item in arquivo)
            {
                sb.Append($"Data: {item.Data} Area desmatada(m²): {item.AreaDesmatada} Municipio: {item.Municipio} UF: {item.UF}");
                sb.AppendLine();
            }
            richTextBoxDesordenado.AppendText(sb.ToString());

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxDesordenado.Text = null;
            richTextBoxOrdenado.Text = null;

            comboBoxArquivo.SelectedItem = null;
            comboBoxAlgoritmo.SelectedItem = null;
            comboBoxAleatorio.SelectedItem = null;

            labelAlgoritmoUtilizado.Text = "Algoritmo utilizado:";
            labelTempoExec.Text = "Tempo de execução:";
            labelTrocas.Text = "Interações realizadas (trocas):";


        }

        private void btnGerarAleatorio_Click(object sender, EventArgs e)
        {
            var quantidadeSelecionada = comboBoxAleatorio.SelectedItem;
            if (quantidadeSelecionada == null)
            {
                MessageBox.Show("Selecione uma quantidade antes de gerar");
                return;
            }

            var gerarInt = int.TryParse(quantidadeSelecionada.ToString().Replace(".", ""), out int quantidadeInt);

            if (gerarInt)
            {
                var listaAleatoria = InformacoesDesmatamentoAleatorio.GerarLista(quantidadeInt);
                var sb = new StringBuilder();

                foreach (var item in listaAleatoria)
                {
                    sb.Append($"Data: {item.Data} Area desmatada(m²): {item.AreaDesmatada} Municipio: {item.Municipio} UF: {item.UF}");
                    sb.AppendLine();
                }
                richTextBoxDesordenado.AppendText(sb.ToString());
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            var arquivoSelecionado = comboBoxArquivo.SelectedItem;
            var quantidadeSelecionada = comboBoxAleatorio.SelectedItem;
            var algoritmoSelecionado = comboBoxAlgoritmo.SelectedItem;

            if (arquivoSelecionado == null && quantidadeSelecionada == null)
            {
                MessageBox.Show("Selecione um lista ou uma quantidade antes de efetuar a leitura!", "Arquivo não selecionado");
                return;
            }

            if (algoritmoSelecionado == null)
            {
                MessageBox.Show("Selecione um método de ordenção!", "Algoritmo não selecionado");
                return;
            }

            List<InformacoesDesmatamento> lista = new();

            if (arquivoSelecionado != null && quantidadeSelecionada == null)
            {
                lista = LerArquivoInfoDesmatamento.Ler(arquivoSelecionado.ToString());

            }
            else
            {
                var gerarInt = int.TryParse(quantidadeSelecionada.ToString().Replace(".", ""), out int quantidadeInt);

                if (gerarInt)
                {
                    var listaAleatoria = InformacoesDesmatamentoAleatorio.GerarLista(quantidadeInt);
                    lista = listaAleatoria;
                }
            }

            Resultado resultado = new();

            #region Tempo
            Stopwatch stopwatch = new Stopwatch();

            #endregion
            switch (algoritmoSelecionado)
            {
                case "Bubble Sort":
                    BubbleSort bubbleSort = new();
                    stopwatch.Start();
                    resultado = bubbleSort.Ordenar(lista);
                    stopwatch.Stop();
                    break;
                case "Heap Sort":
                    HeapSort heapSort = new();
                    stopwatch.Start();
                    resultado = heapSort.Ordenar(lista);
                    stopwatch.Stop();
                    break;
                case "Quick Sort":
                    QuickSort quick = new();
                    stopwatch.Start();
                    resultado = quick.Ordenar(lista);
                    stopwatch.Stop();
                    break;
                case "Insertion Sort":
                    InsertionSort inserionSort = new();
                    stopwatch.Start();
                    resultado = inserionSort.Ordenar(lista);
                    stopwatch.Stop();
                    break;
                default:
                    MessageBox.Show("Não foi efetuada ordenação");
                    break;
            }



            var sb = new StringBuilder();

            foreach (var item in resultado.Lista)
            {
                sb.Append($"Data: {item.Data} Area desmatada(m²): {item.AreaDesmatada} Municipio: {item.Municipio} UF: {item.UF}");
                sb.AppendLine();
            }
            richTextBoxOrdenado.AppendText(sb.ToString());
            labelAlgoritmoUtilizado.Text += " " + algoritmoSelecionado;
            labelTrocas.Text += " " + resultado.Trocas;
            labelTempoExec.Text += " " + stopwatch.ElapsedMilliseconds + "ms";
        }
    }
}