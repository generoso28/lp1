/*Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo usuário
e o limite do vetor é 100) e passe o mesmo como parâmetro para uma função que retorne a soma de seus
elementos.*/
#include <stdio.h>

int somaVetor(int vetor[], int n) {
    int soma = 0;
    for (int i = 0; i < n; i++)
        soma = soma + vetor[i];
    return soma;
}

int main() {
    int vetor[100], n = 0;
    printf("Qual será a quantidade de números lidos? ");
    scanf("%d", &n);

    if (n <= 0 || n > 100) {
        printf("Quantidade inválida. O valor deve estar entre 1 e 100.\n");
        return 0;
    }

    for (int i = 0; i < n; i++) {
        printf("Digite um número inteiro: ");
        scanf("%d", &vetor[i]);
    }

    int resultado = somaVetor(vetor, n);
    printf("A soma dos elementos do vetor é: %d\n", resultado);

    return 0;
}