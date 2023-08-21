//Leia um vetor DNA de caracteres para receber as letras A, T, C e G que representam as bases do DNA. Este
//vetor será responsável por representar uma fita de um gene de limite de 50 bases. Gere o vetor complementar
//ao vetor DNA e o apresente (Lembrando as bases complementares A=T C=G).
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    char vetor[51], complementar[51];
    int tamanho;
	printf("Digite as bases do DNA: ");
	gets(vetor);
	tamanho = strlen(vetor);
	for (int i = 0; i<tamanho; i++) {
		vetor[i]=toupper(vetor[i]);
		switch (vetor[i]){
			case 'A':
				complementar[i]='T';
			break;
			case 'T':
				complementar[i]='A';
			break;
			case 'C':
				complementar[i]='G';
			break;
			case 'G':
				complementar[i]='C';
			break;
			default:
				printf("POSICAO %d INVALIDA\n", i);
		}
		
	}
	complementar[tamanho]='\0';
	printf("Vetor complementar: ");
	for (int i = 0; i < tamanho; i++) {
		printf("%c", complementar[i]);
	}
    return 0;
}