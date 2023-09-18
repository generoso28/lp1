#include "matrizLib.h"

int main() {
    int n, m, matriz[100][100];

    printf("Digite o número de linhas: ");
    scanf("%d", &n);
    printf("Digite o número de colunas: ");
    scanf("%d", &m);
	
	geraMatriz(matriz,n,m);

	printMatriz(matriz,n,m);

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (i==j) {
                printf("|%d|",matriz[i][j]);
            }
            else{
            	printf("|  |");
			}
        }
        printf("\n");
    }
    
    return 0;
}