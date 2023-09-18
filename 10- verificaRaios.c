#include <stdio.h>
#include <stdlib.h>
#include "matrizLib.h"
int main(){
	int mapa[300][1000], i, j, quantRaios, x, y, locaisIguais=0;
	for(i=0;i<300;i++)
		for(j=0;j<1000;j++)
			mapa[i][j]=0;
	printMatriz(mapa,10,10);
	printf("Digite quantos raios caíram: ");
	scanf("%d", &quantRaios);
	for (i=1; i<=quantRaios; i++){
		printf("Coordenadas do raio %d: ",i);
		scanf("%d%d", &x,&y);
		mapa[x][y]++;
	}
	printMatriz(mapa,10,10);
}