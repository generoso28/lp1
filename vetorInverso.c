//Leia um vetor de caracteres (limite 100) utilizando a função gets(). Utilize a função strlen (Você deve incluir a
//biblioteca string.h) para obter a quantidade de elementos do vetor de caracteres. Escreva o vetor lido em
//ordem inversa.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    char vetor[100], inverso[100];
    int tamanho;
	printf("Digite um vetor de caracteres: ");
	gets(vetor);
	tamanho = strlen(vetor);
	for (int i = 1; i<=tamanho; i++) {
		inverso[i]=vetor[tamanho-i];
	}
	inverso[tamanho+1]='\0';
	printf("Vetor inverso: ");
	for (int i = 1; i <= tamanho; i++) {
		printf("%c", inverso[i]);
	}
    return 0;
}