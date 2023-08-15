/*Dado um vetor de n números reais, crie uma função que retorne o menor elemento do vetor, apresente o
vetor.*/
#include<stdio.h>
int main() {
    int vetor[100], n = 0, menor;
    printf("Qual será a quantidade de números lidos? ");
    scanf("%d", &n);

    if (n <= 0 || n > 100) {
        printf("Quantidade inválida. O valor deve estar entre 1 e 100.\n");
        return 0;
    }

    for (int i = 0; i < n; i++) {
        printf("Digite um número inteiro: ");
        scanf("%d", &vetor[i]);
        if(menor>vetor[i] || i==0)
        	menor=vetor[i];
    }

    printf("O menor dos elementos do vetor é: %d\n", menor);

    return 0;
}