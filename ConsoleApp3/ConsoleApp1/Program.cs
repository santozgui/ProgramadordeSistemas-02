
//declarando uma matriz 3 linhas por 2 colunas
int[,] matriz = new int[3, 2]
// [,] = representa 2 dimensoes que é separada por virgula, sendo um pra direita e uma pra esquerda
//new int = cria nova matriz

{
    { 1, 2 } ,
    { 3, 4 } ,
    { 5, 6 }
};

// identificando qual o conteudo da linha
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j] + " ");
        }
    Console.WriteLine();
}