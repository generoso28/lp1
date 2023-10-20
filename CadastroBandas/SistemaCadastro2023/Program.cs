using System;
using System.IO;
class Program
{
    struct TipoBanda
    {
        public string nome;
        public string genero;
        public int integrantes;
        public int ranking;
    }

    static void addBanda(List<TipoBanda> lista)
    {
        TipoBanda novaBanda = new TipoBanda();
        Console.Write("Nome da banda:");
        novaBanda.nome = Console.ReadLine();
        Console.Write("Genero da banda:");
        novaBanda.genero = Console.ReadLine();
        Console.Write("Integrantes:");
        novaBanda.integrantes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ranking:");
        novaBanda.ranking = Convert.ToInt32(Console.ReadLine());
        lista.Add(novaBanda);
    }
    static void alterarBanda(List<TipoBanda> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                TipoBanda novaBanda = new TipoBanda();
                Console.Write("Novo nome da banda:");
                novaBanda.nome = Console.ReadLine();
                Console.Write("Novo genero da banda:");
                novaBanda.genero = Console.ReadLine();
                Console.Write("Novos integrantes:");
                novaBanda.integrantes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Novo ranking:");
                novaBanda.ranking = Convert.ToInt32(Console.ReadLine());
                lista[i] = novaBanda;
            }
            
        }
        if (!flag)
            Console.Write("Banda não encontrada.");
    }
    static void removerBanda(List<TipoBanda> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Console.WriteLine("\n\t*** Dados da banda ***");
                Console.WriteLine("Nome:" + lista[i].nome);
                Console.WriteLine("Genero:" + lista[i].genero);
                Console.WriteLine("Integrantes:" + lista[i].integrantes);
                Console.WriteLine("Ranking:" + lista[i].ranking);
                Console.Write("\nTem certeza que deseja remover a banda? 0 - não / 1 - sim");
                int rem = Convert.ToInt32(Console.ReadLine());
                if(rem==0)
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
            Console.Write("Banda não encontrada.");
    }
    static void listarBandas(List<TipoBanda> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("\n\t*** Dados da banda ***");
            Console.WriteLine("Nome:" + lista[i].nome);
            Console.WriteLine("Genero:" + lista[i].genero);
            Console.WriteLine("Integrantes:" + lista[i].integrantes);
            Console.WriteLine("Ranking:" + lista[i].ranking);
        }
    }
    static void listarRanking(List<TipoBanda> lista, int idRanking)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].ranking == idRanking)
            {
                Console.WriteLine("\n\t*** Dados da banda ***");
                Console.WriteLine("Nome:" + lista[i].nome);
                Console.WriteLine("Genero:" + lista[i].genero);
                Console.WriteLine("Integrantes:" + lista[i].integrantes);
                Console.WriteLine("Ranking:" + lista[i].ranking);
            }
        }
    }
    static void listarNome(List<TipoBanda> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados da banda ***");
                Console.WriteLine("Nome:" + lista[i].nome);
                Console.WriteLine("Genero:" + lista[i].genero);
                Console.WriteLine("Integrantes:" + lista[i].integrantes);
                Console.WriteLine("Ranking:" + lista[i].ranking);
            }
        }
    }
    static void listarGenero(List<TipoBanda> lista, string generoBusca)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].genero.ToUpper().Contains(generoBusca.ToUpper()))
            {
                Console.WriteLine("\n\t*** Dados da banda ***");
                Console.WriteLine("Nome:" + lista[i].nome);
                Console.WriteLine("Genero:" + lista[i].genero);
                Console.WriteLine("Integrantes:" + lista[i].integrantes);
                Console.WriteLine("Ranking:" + lista[i].ranking);
            }
        }
    }
    static void salvarDados(List<TipoBanda> bandas, string nomeArquivo)
    {

        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (TipoBanda banda in bandas)
            {
                writer.WriteLine($"{banda.nome},{banda.genero},{banda.integrantes},{banda.ranking}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
        
     
    }

    static void carregarDados(List<TipoBanda> bandas, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                TipoBanda banda = new TipoBanda
                {
                    nome = campos[0],
                    genero = campos[1],
                    integrantes = int.Parse(campos[2]),
                    ranking = int.Parse(campos[3])
                };
                bandas.Add(banda);
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
        Console.WriteLine("*** Sistema de Cadastros de Bandas ***");
        Console.WriteLine("1-Adicionar banda");
        Console.WriteLine("2-Listar");
        Console.WriteLine("3-Listar por ranking");
        Console.WriteLine("4-Listar por nome");
        Console.WriteLine("5-Listar por gênero");
        Console.WriteLine("6-Alterar");
        Console.WriteLine("7-Remover");
        Console.WriteLine("0-Sair");
        Console.Write("Entre com uma opção: ");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<TipoBanda> listadeBandas = new List<TipoBanda>();
        int op;
        carregarDados(listadeBandas, "dados.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    addBanda(listadeBandas);
                    break;
                case 2:
                    listarBandas(listadeBandas);
                    break;
                case 3:
                    Console.Write("Digite um valor de ranking a ser listado: ");
                    int idRanking = Convert.ToInt32(Console.ReadLine());
                    listarRanking(listadeBandas, idRanking);
                    break;
                case 4:
                    Console.Write("Digite um nome a ser listado: ");
                    string nomeBusca = Console.ReadLine();
                    listarNome(listadeBandas, nomeBusca);
                    break;
                case 5:
                    Console.Write("Digite um gênero a ser listado: ");
                    string generoBusca = Console.ReadLine();
                    listarNome(listadeBandas, generoBusca);
                    break;
                case 6:
                    Console.Write("Digite o nome da banda a ser alterada: ");
                    nomeBusca = Console.ReadLine();
                    alterarBanda(listadeBandas, nomeBusca);
                    break;
                case 7:
                    Console.Write("Digite o nome da banda a ser removida: ");
                    nomeBusca = Console.ReadLine();
                    removerBanda(listadeBandas, nomeBusca);
                    break;
                case 0: Console.WriteLine("Saindo");
                        salvarDados(listadeBandas, "dados.txt");
                    break;
            }
            Console.ReadKey();// pausa
            Console.Clear(); // limpa
        } while (op != 0);// fim while


        Console.ReadLine();//pause antes de fechar
    }

}// fim do programa