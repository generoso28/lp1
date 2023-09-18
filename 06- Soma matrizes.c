#include "matrizLib.h"

int main() {
    int n1, m1, n2, m2, matriz1[100][100], matriz2[100][100], soma[100][100];
	
	printf("Digite o número de linhas da matriz 1: ");
    scanf("%d", &n1);
    printf("Digite o número de colunas da matriz 1: ");
    scanf("%d", &m1);
	
    printf("Digite o número de linhas da matriz 2: ");
    scanf("%d", &n2);
    printf("Digite o número de colunas da matriz 2: ");
    scanf("%d", &m2);
	
	geraMatriz(matriz1,n1,m1);
	getch();
	geraMatriz(matriz2,n2,m2);

	printMatriz(matriz1,n1,m1);
	printMatriz(matriz2,n2,m2);

	if(n1==n2 && m1==m2){
		for (int i = 0; i < n1; i++) {
	        for (int j = 0; j < m1; j++) {
	           soma[i][j]=matriz1[i][j]+matriz2[i][j]; 
	        }
	        printf("\n");
	    }
	    printf("Matriz soma:\n");
	    printMatriz(soma,n1,m1);
	}else{
		printf("\nImpossível calcular a soma. As matrizes não são da mesma ordem.");
	}
    
    
    return 0;
}