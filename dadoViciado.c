//Tentando descobrir se um dado era viciado, um dono de cassino honesto o lançou N vezes. Dados os n
//resultados dos lançamentos que devem ser armazenados em um vetor, determinar o número de ocorrências
//de cada face.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    int vetor[50], num, quant[6]={0,0,0,0,0,0};
    printf("Digite quantas vezes o dado será lançado: ");
    scanf("%d", &num);
	for (int i = 0; i < num; i++) {
		printf("Digite o número sorteado no dado: ");
		scanf("%d", &vetor[i]);
		switch (vetor[i]){
			case 1:
				quant[0]++;
			break;
			case 2:
				quant[1]++;
			break;
			case 3:
				quant[2]++;
			break;
			case 4:
				quant[3]++;
			break;
			case 5:
				quant[4]++;
			break;
			case 6:
				quant[5]++;
			break;
			default:
				printf("Valor inválido. Entre um número entre 1 e 6.\n");
				i--;
			break;
		}
				
	}
	printf("\nNúmeros 1 sorteados: %d", quant[0]);
	printf("\nNúmeros 2 sorteados: %d", quant[1]);
	printf("\nNúmeros 3 sorteados: %d", quant[2]);
	printf("\nNúmeros 4 sorteados: %d", quant[3]);
	printf("\nNúmeros 5 sorteados: %d", quant[4]);
	printf("\nNúmeros 6 sorteados: %d", quant[5]);
    return 0;
}
