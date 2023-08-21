#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <time.h>

int main() {
    float nota[5], maior, menor, soma;
	for (int i = 0; i<5; i++) {
		printf("Digite a nota do jurado %d: ", i);
		scanf("%f", &nota[i]);
		if(nota[i]>=5 && nota[i]<=10){
			if(i==0){
			maior=nota[i];
			menor=nota[i];
			}else if(nota[i]>maior){
			maior=nota[i];
			}else if(nota[i]<menor){
			menor=nota[i];
			}
			 soma=soma+nota[i];
		}else{
			printf("Entrada inválida!");
			i--;
		}	
	}
	printf("%.1f", soma);
	printf("\n%.1f", menor);
	printf("\n%.1f", maior);
	soma=(soma-maior-menor)/3;
	printf("\n%.1f", soma);
}