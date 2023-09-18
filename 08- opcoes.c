#include <stdio.h>

void printMatriz(float m[][100],int linhas,int cols){
	int i,j;
	for(i=0;i<linhas;i++){
		for(j=0;j<cols;j++)
		   printf("%.2f |",m[i][j]);
	  printf("\n");	   
	}// fim for i
	printf("\n");
} //  fim print

void geraMatriz(float m[][100],int linhas,int cols){
	int i,j;
	srand(time(NULL));
	for(i=0;i<linhas;i++)
		for(j=0;j<cols;j++)
		   m[i][j]=rand()%50;
}

void somarMatrizes(float matriz1[][100], float matriz2[][100], float resultado[][100], int N, int m) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < m; j++) {
            resultado[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
}

void subtrairMatrizes(float matriz1[][100], float matriz2[][100], float resultado[][100], int N, int m) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < m; j++) {
            resultado[i][j] = matriz1[i][j] - matriz2[i][j];
        }
    }
}

void adicionarConstante(float matriz[][100], int n, int m, float constante) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            matriz[i][j] += constante;
        }
    }
}

int main() {
    int n, m;
    float matriz1[100][100], matriz2[100][100], resultado[100][100];
    char opcao;
    float constante;

    // Solicitar o número de linhas e colunas das matrizes
    printf("Digite o número de linhas das matrizes: ");
    scanf("%d", &n);
    printf("Digite o número de colunas das matrizes: ");
    scanf("%d", &m);
	geraMatriz(matriz1,n,m);
	getch();
	geraMatriz(matriz2,n,m);
	printf("Matriz 1: \n");
	printMatriz(matriz1, n, m);
	printf("Matriz 2: \n");
    printMatriz(matriz2, n, m);
	while(1){
    printf("\nEscolha uma operação:\n");
    printf("(a) Somar as duas matrizes\n");
    printf("(b) Subtrair a primeira matriz da segunda\n");
    printf("(c) Adicionar uma constante às duas matrizes\n");
    printf("(d) Imprimir as matrizes\n");
    printf("(e) Sair\n");
    scanf(" %c", &opcao);
		switch (opcao) {
        case 'a':
            somarMatrizes(matriz1, matriz2, resultado, n, m);
            printf("Resultado da soma:\n");
            printMatriz(resultado, n, m);
            break;
        case 'b':
            subtrairMatrizes(matriz1, matriz2, resultado, n, m);
            printf("Resultado da subtração:\n");
            printMatriz(resultado, n, m);
            break;
        case 'c':
            printf("Digite a constante a ser adicionada às matrizes: ");
            scanf("%f", &constante);
            adicionarConstante(matriz1, n, m, constante);
            adicionarConstante(matriz2, n, m, constante);
            printf("Constante adicionada às matrizes.\n");
            printMatriz(matriz1, n, m);
            printMatriz(matriz2, n, m);
            break;
        case 'd':
            printf("Matriz 1:\n");
            printMatriz(matriz1, n, m);
            printf("Matriz 2:\n");
            printMatriz(matriz2, n, m);
            break;
        case 'e':
            printf("Encerrando o programa.\n");
            return 0;
        default:
            printf("Opção inválida.\n");
    }
	}
    

    return 0;
}