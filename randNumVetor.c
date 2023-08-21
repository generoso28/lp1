//Escreve um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
//usuário digita um número e seu programa em C deve acusar se o número digitado está no vetor ou não. Se
//estiver, diga a posição que está.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    int vetor[50], num;
    srand(time(NULL));
	for (int i = 0; i < 50; i++) {
		vetor[i]=rand();
	}
	printf("Digite um valor a ser verificado: ");
	scanf("%d", &num);
	for (int i = 0; i < 10; i++) {
		if(num==vetor[i]){
			printf("O valor %d está na posição %d do vetor.", num, vetor[i]);
		}
	}
	printf("Valores sorteados: ");
	for (int i = 0; i < 10; i++) {
		printf("| %d |", vetor[i]);
	}
    return 0;
}