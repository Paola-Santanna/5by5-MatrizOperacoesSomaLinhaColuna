//Uma matriz quadrada, de tamanho variado; mostre os resultados das operações de soma; os resultados devem ser referentes à soma de cada linha, à soma de cada coluna e à soma de cada diagonal;
int qnt_linhas = 3, qnt_colunas = 3, soma_linha = 0, soma_coluna = 0, soma_diagonal_principal = 0;
int resultado_soma_diagonal_principal, soma_diagonal_secundaria = 0, resultado_soma_diagonal_secundaria = 0, valor_diagonal;
bool parar = false;

int[,] matriz = new int[qnt_linhas, qnt_colunas];
int[] resultado_soma_linhas = new int[qnt_linhas];
int[] resultado_soma_colunas = new int[qnt_colunas];
int[] valores_diagonal_secundaria = new int[qnt_colunas];

//Matriz
//Geração
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(0, 10);
    }
}

//Impressão
Console.WriteLine("Matriz: ");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
}

//Linhas
//Operação
for (int linha = 0; linha < qnt_linhas; linha++)
{

    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        soma_linha += matriz[linha, coluna];
    }
    resultado_soma_linhas[linha] = soma_linha;
    soma_linha = 0;
}

//Impressão
Console.WriteLine("\n\nSoma das linhas:");
for (int indice = 0; indice < qnt_linhas; indice++)
{
    Console.WriteLine($"{indice + 1}ª linha = {resultado_soma_linhas[indice]}");
}

//Colunas
//Operação
for (int coluna = 0; coluna < qnt_colunas; coluna++)
{

    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        soma_coluna += matriz[linha, coluna];
    }
    resultado_soma_colunas[coluna] = soma_coluna;
    soma_coluna = 0;
}

//Impressão
Console.WriteLine("\n\nSoma das colunas:");
for (int indice = 0; indice < qnt_linhas; indice++)
{
    Console.WriteLine($"{indice + 1}ª coluna = {resultado_soma_colunas[indice]}");
}

//Diagonais
//Diagonal Principal
//Operação
for (int linha = 0; linha < qnt_linhas; linha++)
{

    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        if (linha == coluna)
        {
            soma_diagonal_principal += matriz[linha, coluna];
        }
    }
}
resultado_soma_diagonal_principal = soma_diagonal_principal;

//Impressão
Console.WriteLine("\n\nSoma das diagonais:");
Console.WriteLine($"Diagonal Principal = {resultado_soma_diagonal_principal}");

//Diagonal Secundária
//Operação
//for (int linha = 0; linha < qnt_linhas; linha++)
//{
//    do
//    {
//        for (int coluna = qnt_colunas; coluna >= 0; coluna--)
//        {
//            if (linha != coluna && coluna > linha)
//            {
//                valores_diagonal_secundaria[linha] = matriz[linha, coluna];
//                parar = true;
//            }
//        }
//    } while (parar !=true);
//    resultado_soma_diagonal_secundaria += soma_diagonal_secundaria;
//}

//Solução da Ana Bordin
for (int i = qnt_linhas - 1; i > -1; i--)
{
    for (int j = qnt_colunas - 1; j > -1; j--)
    {
        if (i + j == qnt_linhas - 1)
            soma_diagonal_secundaria += matriz[i, j];
    }
}
resultado_soma_diagonal_secundaria = soma_diagonal_secundaria;


//Impressão
Console.WriteLine($"Diagonal Secundária = {resultado_soma_diagonal_secundaria}");


Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();