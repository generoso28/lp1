//Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
//mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    int vetor1[5], vetor2[5], vetor3[5], num;
    srand(time(NULL));
	for (int i = 0; i < 5; i++) {
		vetor1[i]=rand();
		vetor2[i]=rand();
		vetor3[i]=vetor1[i]*vetor2[i];
	}
	printf("\nVetor 1 sorteado: ");
	for (int i = 0; i < 5; i++) {
		printf("| %d |", vetor1[i]);
	}
	printf("\nVetor 2 sorteado: ");
	for (int i = 0; i < 5; i++) {
		printf("| %d |", vetor2[i]);
	}
	printf("\nVetor 3 resultante: ");
	for (int i = 0; i < 5; i++) {
		printf("| %d |", vetor3[i]);
	}
    return 0;
}