//Uma matriz quadrada, de tamanho variado; mostre os resultados das operações de soma; os resultados devem ser referentes à soma de cada linha, à soma de cada coluna e à soma de cada diagonal;
int qnt_linhas = 3, qnt_colunas = 3, soma_linha = 0, soma_coluna, soma_diagonal_principal, soma_diagonal_sevundaria;
int cont_parar = 0;

int[,] matriz = new int[qnt_linhas, qnt_colunas];
int[] resultado_soma_linhas = new int[qnt_linhas];
int[] resultado_soma_colunas = new int[qnt_colunas];
int[] resultado_soma_diagonais = new int[2];

//Geração da matriz
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(0, 10);
    }
}

//Impressão da matriz
Console.WriteLine("Matriz: ");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
}

//Geração das operações com as linhas
for (int linha = 0; linha < qnt_linhas; linha++)
{

    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        soma_linha += matriz[linha, coluna];
    }
    resultado_soma_linhas[linha] = soma_linha;
    soma_linha = 0;
}

//Impressão das operações com as linhas
Console.WriteLine("\n\nSoma das linhas:");
for (int indice = 0; indice < qnt_linhas; indice++)
{
    Console.WriteLine($"{indice + 1}ª linha = {resultado_soma_linhas[indice]}");
}

//Geração das operações com as colunas
for (int linha = 0; linha < qnt_linhas; linha++)
{

    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        soma_linha += matriz[linha, coluna];
    }
    resultado_soma_linhas[linha] = soma_linha;
    soma_linha = 0;
}

//Impressão das operações com as colunas

Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();