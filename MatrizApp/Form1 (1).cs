using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrizApp
{
    public partial class Form1 : Form
    {
        // =============================================
        // VARIÁVEIS DA MATRIZ
        // =============================================
        private int[,] matriz;       // A matriz em si
        private int linhas = 3;      // Número de linhas
        private int colunas = 3;     // Número de colunas

        // =============================================
        // CONSTRUTOR DO FORMULÁRIO
        // =============================================
        public Form1()
        {
            InitializeComponent();
            InicializarMatriz();
        }

        // =============================================
        // INICIALIZA A MATRIZ COM VALORES PADRÃO
        // =============================================
        private void InicializarMatriz()
        {
            matriz = new int[linhas, colunas];

            // Preenche a matriz com valores de exemplo (1 a 9)
            int valor = 1;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                }
            }
        }

        // =============================================
        // BOTÃO: GERAR VALORES ALEATÓRIOS
        // =============================================
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = random.Next(1, 100); // Números entre 1 e 99
                }
            }

            // Redesenha a matriz na tela
            panelMatriz.Invalidate();
            lblStatus.Text = "✔ Matriz gerada com valores aleatórios!";
        }

        // =============================================
        // BOTÃO: RESETAR PARA VALORES PADRÃO
        // =============================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            InicializarMatriz();
            panelMatriz.Invalidate();
            lblStatus.Text = "✔ Matriz resetada para os valores padrão.";
        }

        // =============================================
        // BOTÃO: MOSTRAR INFORMAÇÕES DA MATRIZ
        // =============================================
        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Calcula a soma de todos os elementos
            int soma = 0;
            int maior = matriz[0, 0];
            int menor = matriz[0, 0];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i, j];

                    if (matriz[i, j] > maior) maior = matriz[i, j];
                    if (matriz[i, j] < menor) menor = matriz[i, j];
                }
            }

            double media = (double)soma / (linhas * colunas);

            // Exibe as informações
            string info = $"📊 INFORMAÇÕES DA MATRIZ\n\n" +
                          $"Dimensão: {linhas} x {colunas}\n" +
                          $"Total de elementos: {linhas * colunas}\n\n" +
                          $"Soma de todos os valores: {soma}\n" +
                          $"Média dos valores: {media:F2}\n" +
                          $"Maior valor: {maior}\n" +
                          $"Menor valor: {menor}";

            MessageBox.Show(info, "Informações da Matriz",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =============================================
        // EVENTO: DESENHAR A MATRIZ NO PANEL
        // =============================================
        private void panelMatriz_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Tamanho de cada célula da matriz
            int tamanhoCelula = 80;
            int margemEsquerda = 30;
            int margemTopo = 30;

            // Cores usadas no desenho
            Color corFundo      = Color.FromArgb(230, 240, 255);  // Azul claro
            Color corBorda      = Color.FromArgb(70, 130, 180);   // Azul aço
            Color corTexto      = Color.FromArgb(30, 30, 100);    // Azul escuro
            Color corCabecalho  = Color.FromArgb(70, 130, 180);   // Azul para índices
            Color corTextoIdx   = Color.White;

            Font fonteValor    = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fonteIndice   = new Font("Segoe UI", 9, FontStyle.Regular);
            Font fonteTitulo   = new Font("Segoe UI", 12, FontStyle.Bold);

            // --- Título ---
            g.DrawString("Matriz 3 x 3", fonteTitulo, new SolidBrush(corBorda), margemEsquerda, 5);

            // --- Desenha os índices das colunas (j = 0, 1, 2) ---
            for (int j = 0; j < colunas; j++)
            {
                int x = margemEsquerda + j * tamanhoCelula;
                Rectangle retIdx = new Rectangle(x, margemTopo, tamanhoCelula, 25);
                g.FillRectangle(new SolidBrush(corCabecalho), retIdx);
                g.DrawRectangle(new Pen(Color.White, 1), retIdx);

                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString($"j={j}", fonteIndice, new SolidBrush(corTextoIdx), retIdx, sf);
            }

            // --- Desenha os índices das linhas (i = 0, 1, 2) ---
            for (int i = 0; i < linhas; i++)
            {
                int y = margemTopo + 25 + i * tamanhoCelula;
                Rectangle retIdx = new Rectangle(margemEsquerda - 30, y, 28, tamanhoCelula);
                g.FillRectangle(new SolidBrush(corCabecalho), retIdx);
                g.DrawRectangle(new Pen(Color.White, 1), retIdx);

                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString($"i={i}", fonteIndice, new SolidBrush(corTextoIdx), retIdx, sf);
            }

            // --- Desenha as células da matriz ---
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int x = margemEsquerda + j * tamanhoCelula;
                    int y = margemTopo + 25 + i * tamanhoCelula;

                    Rectangle celula = new Rectangle(x, y, tamanhoCelula, tamanhoCelula);

                    // Fundo da célula
                    g.FillRectangle(new SolidBrush(corFundo), celula);

                    // Borda da célula
                    g.DrawRectangle(new Pen(corBorda, 2), celula);

                    // Valor dentro da célula (centralizado)
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString(matriz[i, j].ToString(), fonteValor,
                        new SolidBrush(corTexto), celula, sf);

                    // Índice [i,j] no canto inferior direito da célula
                    Rectangle retSubIdx = new Rectangle(x + tamanhoCelula - 32, y + tamanhoCelula - 18, 30, 16);
                    g.DrawString($"[{i},{j}]", fonteIndice,
                        new SolidBrush(Color.Gray), retSubIdx);
                }
            }

            // Libera recursos de fonte
            fonteValor.Dispose();
            fonteIndice.Dispose();
            fonteTitulo.Dispose();
        }
    }
}
