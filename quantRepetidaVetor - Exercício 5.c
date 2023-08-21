//Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
//se encontra no vetor. Apresente também todos elementos do vetor.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main() {
    int vetor[5], num, quant=0;
	for (int i = 0; i < 5; i++) {
		printf("Digite o valor: ");
    	scanf("%d", &vetor[i]);
	}
	printf("Digite um valor a ser verificado: ");
	scanf("%d", &num);
	for (int i = 0; i < 5; i++) {
		if(num==vetor[i]){
			quant++;
		}
		printf("| %d |",vetor[i]);
	}
	printf("\nA quantidade de vezes que %d apareceu no vetor foi: %d", num, quant);
    return 0;
}