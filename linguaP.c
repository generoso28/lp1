#include <stdio.h>
#include <string.h>

int main() {
    char texto[1000], texto2[1000];
    int tamanho;
    printf("Digite o texto: ");
    fgets(texto, sizeof(texto), stdin);

    tamanho = strlen(texto);
    int j = 0;
    for (int i = 0; i < tamanho; i++) {
        if (texto[i] != 'p') {
            texto2[j] = texto[i];
            j++;
        }
    }
    texto2[j] = '\0';

    tamanho = strlen(texto2);
    for (int i = 0; i < tamanho; i++) {
        printf("%c", texto2[i]);
    }

    return 0;
}