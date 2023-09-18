#include "matrizLib.h"

int main() {
    int n, m, matriz[100][100], valor, soma=0;

    printf("Digite o número de linhas: ");
    scanf("%d", &n);
    printf("Digite o número de colunas: ");
    scanf("%d", &m);
	printf("Digite o número a ser verificado: ");
    scanf("%d", &valor);
    printf("Digite os valores da matriz:\n");
    leiaMatriz(matriz, n, m);


    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (matriz[i][j] == valor) {
                soma++;
            }
        }
    }
    
	for(int i=0;i<n;i++){
		for(int j=0;j<m;j++)
		   printf("%d |",matriz[i][j]);
	  printf("\n");	   
	}

    printf("A quantidade de vezes que o valor se repete é: %d\n", soma);

    return 0;
}