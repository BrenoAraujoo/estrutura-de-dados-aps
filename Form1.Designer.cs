using Aps_Estrutura_De_Dados.Algoritmos;

namespace Aps_Estrutura_De_Dados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titulo = new Label();
            comboBoxAlgoritmo = new ComboBox();
            label1 = new Label();
            richTextBoxDesordenado = new RichTextBox();
            richTextBoxOrdenado = new RichTextBox();
            btnLerArquivo = new Button();
            btnOrdenar = new Button();
            btnGerarAleatorio = new Button();
            btnLimpar = new Button();
            label3 = new Label();
            labelAlgoritmoUtilizado = new Label();
            labelTempoExec = new Label();
            labelTrocas = new Label();
            labelDadosDesordenados = new Label();
            labelDadosOrdenados = new Label();
            comboBoxArquivo = new ComboBox();
            labelEscolherOuLer = new Label();
            comboBoxAleatorio = new ComboBox();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(267, 32);
            Titulo.TabIndex = 2;
            Titulo.Text = "Análise de Algoritmos";
            // 
            // comboBoxAlgoritmo
            // 
            comboBoxAlgoritmo.FormattingEnabled = true;
            comboBoxAlgoritmo.Items.AddRange(new object[] { "Bubble Sort", "Insertion Sort", "Heap Sort", "Quick Sort" });
            comboBoxAlgoritmo.Location = new Point(360, 55);
            comboBoxAlgoritmo.Name = "comboBoxAlgoritmo";
            comboBoxAlgoritmo.Size = new Size(333, 23);
            comboBoxAlgoritmo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 26);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 4;
            label1.Text = "Escolha o método de ordenação";
            // 
            // richTextBoxDesordenado
            // 
            richTextBoxDesordenado.Location = new Point(12, 206);
            richTextBoxDesordenado.Name = "richTextBoxDesordenado";
            richTextBoxDesordenado.Size = new Size(510, 251);
            richTextBoxDesordenado.TabIndex = 5;
            richTextBoxDesordenado.Text = "";
            richTextBoxDesordenado.TextChanged += richTextBox1_TextChanged_1;
            // 
            // richTextBoxOrdenado
            // 
            richTextBoxOrdenado.Location = new Point(545, 206);
            richTextBoxOrdenado.Name = "richTextBoxOrdenado";
            richTextBoxOrdenado.Size = new Size(515, 251);
            richTextBoxOrdenado.TabIndex = 6;
            richTextBoxOrdenado.Text = "";
            // 
            // btnLerArquivo
            // 
            btnLerArquivo.Location = new Point(11, 148);
            btnLerArquivo.Name = "btnLerArquivo";
            btnLerArquivo.Size = new Size(148, 23);
            btnLerArquivo.TabIndex = 9;
            btnLerArquivo.Text = "Ler arquivo";
            btnLerArquivo.UseVisualStyleBackColor = true;
            btnLerArquivo.Click += btnLerArquivo_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.ForeColor = SystemColors.MenuHighlight;
            btnOrdenar.Location = new Point(374, 472);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(148, 23);
            btnOrdenar.TabIndex = 10;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnGerarAleatorio
            // 
            btnGerarAleatorio.Location = new Point(545, 148);
            btnGerarAleatorio.Name = "btnGerarAleatorio";
            btnGerarAleatorio.Size = new Size(148, 23);
            btnGerarAleatorio.TabIndex = 11;
            btnGerarAleatorio.Text = "Gerar Aleatório";
            btnGerarAleatorio.UseVisualStyleBackColor = true;
            btnGerarAleatorio.Click += btnGerarAleatorio_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = Color.IndianRed;
            btnLimpar.Location = new Point(545, 472);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(148, 23);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 505);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 14;
            label3.Text = "Resultado";
            // 
            // labelAlgoritmoUtilizado
            // 
            labelAlgoritmoUtilizado.AutoSize = true;
            labelAlgoritmoUtilizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlgoritmoUtilizado.Location = new Point(12, 554);
            labelAlgoritmoUtilizado.Name = "labelAlgoritmoUtilizado";
            labelAlgoritmoUtilizado.Size = new Size(146, 21);
            labelAlgoritmoUtilizado.TabIndex = 15;
            labelAlgoritmoUtilizado.Text = "Algoritmo utilizado:";
            // 
            // labelTempoExec
            // 
            labelTempoExec.AutoSize = true;
            labelTempoExec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTempoExec.Location = new Point(12, 592);
            labelTempoExec.Name = "labelTempoExec";
            labelTempoExec.Size = new Size(151, 21);
            labelTempoExec.TabIndex = 16;
            labelTempoExec.Text = "Tempo de execução: ";
            // 
            // labelTrocas
            // 
            labelTrocas.AutoSize = true;
            labelTrocas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTrocas.Location = new Point(12, 625);
            labelTrocas.Name = "labelTrocas";
            labelTrocas.Size = new Size(217, 21);
            labelTrocas.TabIndex = 17;
            labelTrocas.Text = "Interações realizadas (trocas): ";
            // 
            // labelDadosDesordenados
            // 
            labelDadosDesordenados.AutoSize = true;
            labelDadosDesordenados.Location = new Point(405, 185);
            labelDadosDesordenados.Name = "labelDadosDesordenados";
            labelDadosDesordenados.Size = new Size(118, 15);
            labelDadosDesordenados.TabIndex = 18;
            labelDadosDesordenados.Text = "Dados Desordenados";
            // 
            // labelDadosOrdenados
            // 
            labelDadosOrdenados.AutoSize = true;
            labelDadosOrdenados.Location = new Point(943, 188);
            labelDadosOrdenados.Name = "labelDadosOrdenados";
            labelDadosOrdenados.Size = new Size(101, 15);
            labelDadosOrdenados.TabIndex = 19;
            labelDadosOrdenados.Text = "Dados Ordenados";
            // 
            // comboBoxArquivo
            // 
            comboBoxArquivo.FormattingEnabled = true;
            comboBoxArquivo.Items.AddRange(new object[] { "390.272.csv", "200.000.csv", "100.000.csv", "50.000.csv" });
            comboBoxArquivo.Location = new Point(165, 149);
            comboBoxArquivo.Name = "comboBoxArquivo";
            comboBoxArquivo.Size = new Size(333, 23);
            comboBoxArquivo.TabIndex = 20;
            // 
            // labelEscolherOuLer
            // 
            labelEscolherOuLer.AutoSize = true;
            labelEscolherOuLer.Location = new Point(405, 115);
            labelEscolherOuLer.Name = "labelEscolherOuLer";
            labelEscolherOuLer.Size = new Size(281, 15);
            labelEscolherOuLer.TabIndex = 21;
            labelEscolherOuLer.Text = "Escolha o arquivo ou gere uma quantidade aleatória";
            // 
            // comboBoxAleatorio
            // 
            comboBoxAleatorio.FormattingEnabled = true;
            comboBoxAleatorio.Items.AddRange(new object[] { "50.000", "100.000", "200.000", "400.000" });
            comboBoxAleatorio.Location = new Point(711, 148);
            comboBoxAleatorio.Name = "comboBoxAleatorio";
            comboBoxAleatorio.Size = new Size(333, 23);
            comboBoxAleatorio.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1095, 690);
            Controls.Add(comboBoxAleatorio);
            Controls.Add(labelEscolherOuLer);
            Controls.Add(comboBoxArquivo);
            Controls.Add(labelDadosOrdenados);
            Controls.Add(labelDadosDesordenados);
            Controls.Add(labelTrocas);
            Controls.Add(labelTempoExec);
            Controls.Add(labelAlgoritmoUtilizado);
            Controls.Add(label3);
            Controls.Add(btnLimpar);
            Controls.Add(btnGerarAleatorio);
            Controls.Add(btnOrdenar);
            Controls.Add(btnLerArquivo);
            Controls.Add(richTextBoxOrdenado);
            Controls.Add(richTextBoxDesordenado);
            Controls.Add(label1);
            Controls.Add(comboBoxAlgoritmo);
            Controls.Add(Titulo);
            Name = "Form1";
            Text = "Análise de Algoritmos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Titulo;
        private ComboBox comboBoxAlgoritmo;
        private Label label1;
        private RichTextBox richTextBoxDesordenado;
        private RichTextBox richTextBoxOrdenado;
        private Button btnLerArquivo;
        private Button btnOrdenar;
        private Button btnGerarAleatorio;
        private Button btnLimpar;
        private Label label3;
        private Label labelAlgoritmoUtilizado;
        private Label labelTempoExec;
        private Label labelTrocas;
        private Label labelDadosDesordenados;
        private Label labelDadosOrdenados;
        private ComboBox comboBoxArquivo;
        private Label labelEscolherOuLer;
        private ComboBox comboBoxAleatorio;
    }
}