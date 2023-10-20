/*Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
vetor.*/
#include<stdio.h>
int main() {
    int vetor[100], n = 0, maior;
    printf("Qual será a quantidade de números lidos? ");
    scanf("%d", &n);

    if (n <= 0 || n > 100) {
        printf("Quantidade inválida. O valor deve estar entre 1 e 100.\n");
        return 0;
    }

    for (int i = 0; i < n; i++) {
        printf("Digite um número inteiro: ");
        scanf("%d", &vetor[i]);
        if(maior<vetor[i] || i==0)
        	maior=vetor[i];
    }
	printf("Vetor: ");
	for (int i = 0; i < n; i++) {
        printf("| %d |",vetor[i]);
    }
    printf("\nO maior dos elementos do vetor é: %d\n", maior);
    

    return 0;
}