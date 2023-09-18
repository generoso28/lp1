#include "matrizLib.h"

int main() {
    int n, m, matriz[100][100];

    printf("Digite o número de linhas: ");
    scanf("%d", &n);
    printf("Digite o número de colunas: ");
    scanf("%d", &m);

    printf("Digite os valores da matriz:\n");
    leiaMatriz(matriz, n, m);

    int menor = matriz[0][0];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (matriz[i][j] < menor) {
                menor = matriz[i][j];
            }
        }
    }
    
	for(int i=0;i<n;i++){
		for(int j=0;j<m;j++)
		   printf("%d |",matriz[i][j]);
	  printf("\n");	   
	}

    printf("O menor valor na matriz é: %d\n", menor);

    return 0;
}