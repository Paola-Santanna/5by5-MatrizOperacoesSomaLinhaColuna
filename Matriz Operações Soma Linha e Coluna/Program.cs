//Uma matriz quadrada, de tamanho variado; mostre os resultados das operações de soma; os resultados devem ser referentes à soma de cada linha, à soma de cada coluna e à soma de cada diagonal;
int qnt_linhas = 3, qnt_colunas = 3;

int[,] matriz = new int[qnt_linhas, qnt_colunas];

//Geração da matriz
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(0,10);
    }
}

//Impressão da matriz
Console.WriteLine("Matriz: ");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz[linha,coluna] + " ");
    }
}

//Geração das operações com as linhas
//Impressão das operações com as colunas
//Geração das operações com as diagoais
//Impressão das operações com as diagonais

Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();