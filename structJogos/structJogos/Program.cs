using System;
using System.IO;
class Program
{
    struct DataEmprestimo
    {
        public DateTime Data;
        public string NomePessoa;
        public char Emprestado; //S ou N
    }
    struct Jogos
    {
        public string titulo;
        public string console;
        public int ano;
        public int ranking;
        public DataEmprestimo emprestimo;
    }

    static void AddJogo(List<Jogos> lista)
    {
        Jogos novoJogo = new Jogos();
        Console.Write("Título do jogo:");
        novoJogo.titulo = Console.ReadLine();
        Console.Write("Console do jogo:");
        novoJogo.console = Console.ReadLine();
        Console.Write("Ano de lançamento:");
        novoJogo.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ranking:");
        novoJogo.ranking = Convert.ToInt32(Console.ReadLine());
        lista.Add(novoJogo);
    }
    static void AlterarJogo(List<Jogos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Jogos novoJogo = new Jogos();
                Console.Write("Título do jogo:");
                novoJogo.titulo = Console.ReadLine();
                Console.Write("Console do jogo:");
                novoJogo.console = Console.ReadLine();
                Console.Write("Ano de lançamento:");
                novoJogo.ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ranking:");
                novoJogo.ranking = Convert.ToInt32(Console.ReadLine());
                lista[i] = novoJogo;
            }
        }
        if (!flag)
            Console.Write("Livro não encontrado.");
    }
    static void RemoverJogo(List<Jogos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = qtd-1; i >= 0; i--)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Console.WriteLine("\n\t*** Dados do jogo ***");
                Console.WriteLine($"Título do jogo: {lista[i].titulo}");
                Console.WriteLine($"Console do jogo: {lista[i].console}");
                Console.WriteLine($"Ano de lançamento: {lista[i].ano}");
                Console.WriteLine($"Ranking: {lista[i].ranking}");
                Console.Write("\nTem certeza que deseja remover o jogo? 0 - não / 1 - sim: ");
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
            Console.Write("Jogo não encontrada.");
    }
    static void ListarJogos(List<Jogos> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("\n\t*** Dados do jogo ***");
            Console.WriteLine($"Título do jogo: {lista[i].titulo}");
            Console.WriteLine($"Console do livro: {lista[i].console}");
            Console.WriteLine($"Ano de lançamento: {lista[i].ano}");
            Console.WriteLine($"Ranking: {lista[i].ranking}");
            if (lista[i].emprestimo.Emprestado.ToString().Equals("S") || lista[i].emprestimo.Emprestado.ToString().Equals("N"))
            {
                Console.WriteLine($"Emprestado: {lista[i].emprestimo.Emprestado}");
                if (lista[i].emprestimo.Emprestado.ToString().Equals("S"))
                {
                    Console.WriteLine($"Data do empréstimo: {lista[i].emprestimo.Data}");
                    Console.WriteLine($"Emprestado para: {lista[i].emprestimo.NomePessoa}");
                }
            }
        }
    }
    static void ListarNome(List<Jogos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados do jogo ***");
                Console.WriteLine($"Título do jogo: {lista[i].titulo}");
                Console.WriteLine($"Console do jogo: {lista[i].console}");
                Console.WriteLine($"Ano de lançamento: {lista[i].ano}");
                Console.WriteLine($"Ranking: {lista[i].ranking}");
                if (lista[i].emprestimo.Emprestado.ToString().Equals("S") || lista[i].emprestimo.Emprestado.ToString().Equals("N"))
                {
                    Console.WriteLine($"Emprestado: {lista[i].emprestimo.Emprestado}");
                    if (lista[i].emprestimo.Emprestado.ToString().Equals("S"))
                    {
                        Console.WriteLine($"Data do empréstimo: {lista[i].emprestimo.Data}");
                        Console.WriteLine($"Emprestado para: {lista[i].emprestimo.NomePessoa}");
                    }
                }
            }
        }
    }
    static void FiltrarConsole(List<Jogos> lista, String filtroConsole)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].console.ToUpper().Contains(filtroConsole.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados do jogo ***");
                Console.WriteLine($"Título do jogo: {lista[i].titulo}");
                Console.WriteLine($"Console do jogo: {lista[i].console}");
                Console.WriteLine($"Ano de lançamento: {lista[i].ano}");
                Console.WriteLine($"Ranking: {lista[i].ranking}");
                if (lista[i].emprestimo.Emprestado.ToString().Equals("S") || lista[i].emprestimo.Emprestado.ToString().Equals("N"))
                {
                    Console.WriteLine($"Emprestado: {lista[i].emprestimo.Emprestado}");
                    if (lista[i].emprestimo.Emprestado.ToString().Equals("S"))
                    {
                        Console.WriteLine($"Data do empréstimo: {lista[i].emprestimo.Data}");
                        Console.WriteLine($"Emprestado para: {lista[i].emprestimo.NomePessoa}");
                    }
                }
            }
        }
    }
    static void FiltrarEmprestados(List<Jogos> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].emprestimo.Emprestado.ToString().Equals("S"))
            {
                Console.WriteLine("\n\t*** Dados do jogo ***");
                Console.WriteLine($"Título do jogo: {lista[i].titulo}");
                Console.WriteLine($"Console do livro: {lista[i].console}");
                Console.WriteLine($"Ano de lançamento: {lista[i].ano}");
                Console.WriteLine($"Ranking: {lista[i].ranking}");
                Console.WriteLine($"Data do empréstimo: {lista[i].emprestimo.Data}");
                Console.WriteLine($"Emprestado para: {lista[i].emprestimo.NomePessoa}");
            }
        }
    }
    static void EmprestarJogo(List<Jogos> lista, string nomeBusca)
    {
        Jogos jogo = new Jogos();
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                jogo = lista[i];
                ListarNome(lista, jogo.titulo);
                if (jogo.emprestimo.Emprestado.ToString().Equals("S"))
                {
                    Console.WriteLine("Livro já emprestado. Realize a devolução antes de um novo empréstimo.");
                }
                else
                {
                    Console.Write("Digite o nome da pessoa para o empréstimo: ");
                    String nomePessoa = Console.ReadLine();
                    Console.Write($"Confirma o empréstimo do livro {jogo.titulo} para {nomePessoa}? S/N: ");
                    char confirmacao = Convert.ToChar(Console.ReadLine());
                    if ((confirmacao.ToString()).ToUpper() == "S")
                    {
                        jogo.titulo = lista[i].titulo;
                        jogo.console = lista[i].console;
                        jogo.ano = lista[i].ano;
                        jogo.ranking = lista[i].ranking;
                        jogo.emprestimo.Emprestado = 'S';
                        jogo.emprestimo.Data = DateTime.Now;
                        jogo.emprestimo.NomePessoa = nomePessoa;
                        Console.WriteLine($"Jogo emprestado para {jogo.emprestimo.NomePessoa} em {jogo.emprestimo.Data}");
                        lista[i] = jogo;
                    }
                } 
                break;
             }
        }
        if (!flag)
        {
            Console.WriteLine("Jogo não encontrado.");
        }
    }
    static void DevolverJogo(List<Jogos> lista, string nomeBusca)
    {
        Jogos jogo = new Jogos();
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].titulo.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                jogo = lista[i];
                ListarNome(lista, jogo.titulo);
                Console.Write("Confirma a devolução desse livro? S/N: ");
                char confirmacao = Convert.ToChar(Console.ReadLine());
                if ((confirmacao.ToString()).ToUpper() == "S")
                {
                    jogo.titulo = lista[i].titulo;
                    jogo.console = lista[i].console;
                    jogo.ano = lista[i].ano;
                    jogo.ranking = lista[i].ranking;
                    jogo.emprestimo.Emprestado = 'N';
                    jogo.emprestimo.Data = DateTime.Now;
                    jogo.emprestimo.NomePessoa = null;
                    Console.WriteLine($"Jogo devolvido em {jogo.emprestimo.Data}");
                    lista[i] = jogo;
                }
                break;
            }
        }
        if (!flag)
        {
            Console.WriteLine("Jogo não encontrado.");
        }
    }
    static void SalvarDados(List<Jogos> lista, string nomeArquivo)
    {

        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (Jogos jogo in lista)
            {
                writer.WriteLine($"{jogo.titulo};{jogo.console};{jogo.ano};{jogo.ranking};{jogo.emprestimo.Emprestado};{jogo.emprestimo.NomePessoa};{jogo.emprestimo.Data}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    static void carregarDados(List<Jogos> lista, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                Jogos jogo = new Jogos
                {
                    titulo = campos[0],
                    console = campos[1],
                    ano = Convert.ToInt32(campos[2]),
                    ranking = Convert.ToInt32(campos[3]),
                };
                DataEmprestimo emprestimo = new DataEmprestimo
                {
                    Emprestado = Convert.ToChar(campos[4]),
                    NomePessoa = campos[5],
                    Data = Convert.ToDateTime(campos[6])
                };
                jogo.emprestimo = emprestimo;
                lista.Add(jogo);
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
        Console.WriteLine("*** Sistema de cadastro de jogos ***");
        Console.WriteLine("1-Adicionar jogo");
        Console.WriteLine("2-Listar");
        Console.WriteLine("3-Filtrar por nome");
        Console.WriteLine("4-Filtrar por console");
        Console.WriteLine("5-Filtrar jogos emprestados");
        Console.WriteLine("6- Emprestar jogo");
        Console.WriteLine("7- Devolver jogo");
        Console.WriteLine("8-Alterar");
        Console.WriteLine("9-Remover");
        Console.WriteLine("0-Sair");
        Console.Write("Entre com uma opção: ");
        int op;
        try
        {
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        catch { 
            Console.WriteLine("Invalid input. Please enter a valid option.");
            op = 0;
            return op;
        }
    }
    static void Main()
    {
        List<Jogos> lista = new List<Jogos>();
        int op;
        carregarDados(lista, "dados.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    AddJogo(lista);
                    break;
                case 2:
                    ListarJogos(lista);
                    break;
                case 3:
                    Console.Write("Digite um título a ser listado: ");
                    string nomeBusca = Console.ReadLine();
                    ListarNome(lista, nomeBusca);
                    break;
                case 4:
                    Console.Write("Digite o console para o filtro: ");
                    String filtroConsole = Console.ReadLine();
                    FiltrarConsole(lista, filtroConsole);
                    break;
                case 5:
                    FiltrarEmprestados(lista);
                    break;
                case 6:
                    Console.Write("Digite o nome do jogo a ser emprestado: ");
                    nomeBusca = Console.ReadLine();
                    EmprestarJogo(lista, nomeBusca);
                break;
                case 7:
                    Console.Write("Digite o nome do jogo a ser devolvido: ");
                    nomeBusca = Console.ReadLine();
                    DevolverJogo(lista, nomeBusca);
                    break;
                case 8:
                    Console.Write("Digite o nome do jogo a ser alterado: ");
                    nomeBusca = Console.ReadLine();
                    AlterarJogo(lista, nomeBusca);
                    break;
                case 9:
                    Console.Write("Digite o nome do jogo a ser removido: ");
                    nomeBusca = Console.ReadLine();
                    RemoverJogo(lista, nomeBusca);
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