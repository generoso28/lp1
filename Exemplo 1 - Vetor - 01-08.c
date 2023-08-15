#include <stdio.h>
#include "biblioteca.h"

int main(){
	int vet[100], n;
	printf("Quantidade de elementos do vetor: ");
	scanf("%d", &n);
	printf("Digite os elementos do vetor: ");
	leiaVetor(vet,n);
	escrevaVetor(vet, n);
	contaImpar(vet, n);
	
	return 0;
}