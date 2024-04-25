//Uma matriz quadrada, de tamanho variado; mostre os resultados das operações de soma; os resultados devem ser referentes à soma de cada linha, à soma de cada coluna e à soma de cada diagonal;
int qnt_linhas = 3, qnt_colunas = 3, soma_linha = 0, soma_coluna = 0;
int resultado_soma_diagonal = 0, soma_diagonal = 0, escolha_opcaoSoma;
bool encerrar_programa = false;

int[,] matriz = new int[qnt_linhas, qnt_colunas];
int[] resultado_soma_linhas = new int[qnt_linhas];
int[] resultado_soma_colunas = new int[qnt_colunas];
int[] valores_diagonal_secundaria = new int[qnt_colunas];

//Funções
void GeraçãoMatriz(int[,] matrizGerada)
{
    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizGerada[linha, coluna] = new Random().Next(0, 10);
        }
    }
}

void ImprimirMatriz(int[,] matrizImpressa)
{
    Console.WriteLine("Matriz: ");
    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            Console.Write(matrizImpressa[linha, coluna] + " ");
        }
    }
}

void SomarLinhas(int total_linhas)
{
    for (int linha = 0; linha < total_linhas; linha++)
    {

        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            soma_linha += matriz[linha, coluna];
        }
        resultado_soma_linhas[linha] = soma_linha;
        soma_linha = 0;
    }
}

void ImprimirSomaDeVetores(int[] vetorResultado, int total_tipoIndice)
{
    for (int indice = 0; indice < total_tipoIndice; indice++)
    {
        Console.WriteLine($"{indice + 1}ª linha = {vetorResultado[indice]}");
    }
}

void SomarColunas(int total_colunas)
{
    for (int coluna = 0; coluna < total_colunas; coluna++)
    {

        for (int linha = 0; linha < qnt_linhas; linha++)
        {
            soma_coluna += matriz[linha, coluna];
        }
        resultado_soma_colunas[coluna] = soma_coluna;
        soma_coluna = 0;
    }
}

void SomarDiagonal(int tipo_diagonal)
{
    switch (tipo_diagonal)
    {
        case 1:
            for (int linha = 0; linha < qnt_linhas; linha++)
            {

                for (int coluna = 0; coluna < qnt_colunas; coluna++)
                {
                    if (linha == coluna)
                    {
                        soma_diagonal += matriz[linha, coluna];
                    }
                }
            }
            resultado_soma_diagonal = soma_diagonal;
            break;

         case 2:
            soma_diagonal = 0;
            //Solução da Ana
            for (int linha = qnt_linhas - 1; linha > -1; linha--)
            {
                for (int coluna = qnt_colunas - 1; coluna > -1; coluna--)
                {
                    if (linha + coluna == qnt_linhas - 1)
                        soma_diagonal += matriz[linha, coluna];
                }
            }
            resultado_soma_diagonal = soma_diagonal;
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

void OpcaoEscolhida(int escolha)
{
    switch (escolha)
    {
        case 1:
            //Soma das Linhas
            SomarLinhas(qnt_linhas);

            //Impressão - soma das linhas
            Pular2Linhas();
            Console.WriteLine("Soma das linhas:");
            ImprimirSomaDeVetores(resultado_soma_linhas, qnt_linhas);
            break;

        case 2:
            //Soma das Colunas
            SomarColunas(qnt_colunas);

            //Impressão - soma das colunas
            Pular2Linhas();
            Console.WriteLine("Soma das colunas:");
            ImprimirSomaDeVetores(resultado_soma_colunas, qnt_colunas);
            break;

        case 3:
            //Operações das Diagonais
            //Operação da Diagonal Principal
            SomarDiagonal(1);
            Pular2Linhas();
            //Impressão - soma da diagonal principal
            Console.WriteLine($"Diagonal Principal = {resultado_soma_diagonal}");

            //Operação da Diagonal Secundária
            SomarDiagonal(2);

            //Impressão - soma da diagonal secundária
            Console.WriteLine($"Diagonal Secundária = {resultado_soma_diagonal}");
            break;

        case 4:
            Pular2Linhas();
            Console.WriteLine("Pressione ENTER para encerrar...");
            Console.ReadKey();
            encerrar_programa = true;
            break;

        default:
            Pular2Linhas();
            Console.WriteLine("Opção Inválida!");
            break;
    }
}

void Pular2Linhas()
{
    Console.WriteLine();
    Console.WriteLine();
}
void Menu()
{
    Console.WriteLine("Insira o número da opção escolhida: ");
    Console.WriteLine("1 - Soma dos números de cada linha");
    Console.WriteLine("2 - Soma dos números de cada coluna");
    Console.WriteLine("3 - Soma dos números de cada diagonal");
    Console.WriteLine("4 - Encerrar o programa");
    Console.Write("Sua resposta: ");
    escolha_opcaoSoma = int.Parse(Console.ReadLine());
    OpcaoEscolhida(escolha_opcaoSoma);

}

//Geração da Matriz
GeraçãoMatriz(matriz);
do
{
    //Impressão da Matriz
    ImprimirMatriz(matriz);
    Pular2Linhas();
    Menu();
    Pular2Linhas();
    if (escolha_opcaoSoma != 4)
    {
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
    }
} while (encerrar_programa != true);