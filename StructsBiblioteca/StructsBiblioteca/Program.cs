using System;
using System.IO;
class Program
{
    struct Livros
    {
        public string titulo;
        public string autor;
        public int ano;
        public string prateleira;

    }

    static void AddLivro(List<Livros> lista)
    {
        Livros novoLivro = new Livros();
        Console.Write("Título do livro:");
        novoLivro.titulo = Console.ReadLine();
        Console.Write("Autor do livro:");
        novoLivro.autor = Console.ReadLine();
        Console.Write("Ano de publicação:");
        novoLivro.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Número da prateleira:");
        novoLivro.prateleira = Console.ReadLine();
        lista.Add(novoLivro);
    }
    static void AlterarLivro(List<Livros> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Livros novoLivro = new Livros();
                Console.Write("Título do livro:");
                novoLivro.titulo = Console.ReadLine();
                Console.Write("Autor do livro:");
                novoLivro.autor = Console.ReadLine();
                Console.Write("Ano de publicação:");
                novoLivro.ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Número da prateleira:");
                novoLivro.prateleira = Console.ReadLine();
                lista[i] = novoLivro;
            }

        }
        if (!flag)
            Console.Write("Livro não encontrado.");
    }
    static void RemoverLivro(List<Livros> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Console.WriteLine("\n\t*** Dados do livro ***");
                Console.WriteLine($"Título do livro: {lista[i].titulo}");
                Console.WriteLine($"Autor do livro: {lista[i].autor}");
                Console.WriteLine($"Ano de publicação: {lista[i].ano}");
                Console.WriteLine($"Número da prateleira: {lista[i].prateleira}");
                Console.Write("\nTem certeza que deseja remover o livro? 0 - não / 1 - sim: ");
                int rem = Convert.ToInt32(Console.ReadLine());
                if (rem == 0)
                {
                    Console.WriteLine("Cancelando operação");
                }
                else
                {
                    lista.RemoveAt(i);
                }
            }

        }
        if (!flag)
            Console.Write("Livro não encontrada.");
    }
    static void ListarLivros(List<Livros> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("\n\t*** Dados do livro ***");
            Console.WriteLine($"Título do livro: {lista[i].titulo}");
            Console.WriteLine($"Autor do livro: {lista[i].autor}");
            Console.WriteLine($"Ano de publicação: {lista[i].ano}");
            Console.WriteLine($"Número da prateleira: {lista[i].prateleira}");
        }
    }
    static void ListarNome(List<Livros> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados do livro ***");
                Console.WriteLine($"Título do livro: {lista[i].titulo}");
                Console.WriteLine($"Autor do livro: {lista[i].autor}");
                Console.WriteLine($"Ano de publicação: {lista[i].ano}");
                Console.WriteLine($"Número da prateleira: {lista[i].prateleira}");
            }
        }
    }
    static void FiltrarAutor(List<Livros> lista, String filtroAutor)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].autor.ToUpper().Contains(filtroAutor.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados do livro ***");
                Console.WriteLine($"Título do livro: {lista[i].titulo}");
                Console.WriteLine($"Autor do livro: {lista[i].autor}");
                Console.WriteLine($"Ano de publicação: {lista[i].ano}");
                Console.WriteLine($"Número da prateleira: {lista[i].prateleira}");
            }
        }
    }
    static void FiltrarAno(List<Livros> lista, int filtroAno)
    {
        int qtd = lista.Count();
        Console.WriteLine($"\n\t*** Livros mais novos que {filtroAno}***");
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].ano >= filtroAno)
            {
                Console.WriteLine("\n\t*** Dados do livro ***");
                Console.WriteLine($"Título do livro: {lista[i].titulo}");
                Console.WriteLine($"Autor do livro: {lista[i].autor}");
                Console.WriteLine($"Ano de publicação: {lista[i].ano}");
                Console.WriteLine($"Número da prateleira: {lista[i].prateleira}");
            }
        }
    }
    static void SalvarDados(List<Livros> lista, string nomeArquivo)
    {

        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (Livros livro in lista)
            {
                writer.WriteLine($"{livro.titulo};{livro.autor};{livro.ano};{livro.prateleira}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");


    }

    static void carregarDados(List<Livros> lista, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                Livros livro = new Livros
                {
                    titulo = campos[0],
                    autor = campos[1],
                    ano = Convert.ToInt32(campos[2]),
                    prateleira = campos[2]
                };
                lista.Add(livro);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static int menu()
    {
        Console.WriteLine("*** Sistema de cadastro de livros ***");
        Console.WriteLine("1-Adicionar livro");
        Console.WriteLine("2-Listar");
        Console.WriteLine("3-Filtrar por nome");
        Console.WriteLine("4-Filtrar por autor");
        Console.WriteLine("5-Filtrar por ano");
        Console.WriteLine("6-Alterar");
        Console.WriteLine("7-Remover");
        Console.WriteLine("0-Sair");
        Console.Write("Entre com uma opção: ");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<Livros> lista = new List<Livros>();
        int op;
        carregarDados(lista, "dados.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    AddLivro(lista);
                    break;
                case 2:
                    ListarLivros(lista);
                    break;
                case 3:
                    Console.Write("Digite um título a ser listado: ");
                    string nomeBusca = Console.ReadLine();
                    ListarNome(lista, nomeBusca);
                    break;
                case 4:
                    Console.Write("Digite o autor para o filtro: ");
                    String filtroAutor = Console.ReadLine();
                    FiltrarAutor(lista, filtroAutor);
                    break;
                case 5:
                    Console.Write("Digite o ano para o filtro: ");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    FiltrarAno(lista, ano);
                    break;
                case 6:
                    Console.Write("Digite o nome do livro a ser alterado: ");
                    nomeBusca = Console.ReadLine();
                    AlterarLivro(lista, nomeBusca);
                    break;
                case 7:
                    Console.Write("Digite o nome do livro a ser removido: ");
                    nomeBusca = Console.ReadLine();
                    RemoverLivro(lista, nomeBusca);
                    break;
                case 0:
                    Console.WriteLine("Saindo");
                    SalvarDados(lista, "dados.txt");
                    break;
            }
            Console.ReadKey();// pausa
            Console.Clear(); // limpa
        } while (op != 0);// fim while


        Console.ReadLine();//pause antes de fechar
    }

}// fim do programa