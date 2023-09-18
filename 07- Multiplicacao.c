#include "matrizLib.h"

int main() {
    int n, m, matriz[100][100], valor, resultado[100][100];
	
	printf("Digite o número de linhas: ");
    scanf("%d", &n);
    printf("Digite o número de colunas: ");
    scanf("%d", &m);
	
    printf("Digite um valor: ");
    scanf("%d", &valor);
	
	geraMatriz(matriz,n,m);
	getch();

	printMatriz(matriz,n,m);

		for (int i = 0; i < n; i++) {
			for(int j = 0; j<m; j++){
				resultado[i][j]=matriz[i][j]*valor;
			}
	    }
	    printf("Matriz resultado:\n");
	    printMatriz(resultado,n,m);
    
    
    return 0;
}