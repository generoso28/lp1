using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

class Program
{
    struct DataNascimento
    {
        public int mes;
        public int ano;
    }
    struct Gados
    {
        public int codigo;
        public decimal leite;
        public decimal alimento;
        public char abate;
        public DataNascimento nascimento;
    }
    static void MostraDados(List<Gados> lista, int i)
    {
        Console.WriteLine("\n\t*** Dados do Gado ***");
        Console.WriteLine($"Código da cabeça de gado: {lista[i].codigo}");
        Console.WriteLine($"Litros de leite produzido por semana: {lista[i].leite}");
        Console.WriteLine($"Quantidade de alimento ingerido por semana (kg): {lista[i].alimento}");
        Console.WriteLine($"Mês de nascimento: {lista[i].nascimento.mes}");
        Console.WriteLine($"Ano de nascimento: {lista[i].nascimento.ano}");
        Console.WriteLine($"Abate: {lista[i].abate}");
    }
    static Gados InserirDados(Gados novoGado)
    {
        Console.Write("Litros de leite produzido por semana:");
        novoGado.leite = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Quantidade de alimento ingerida por semana (kg):");
        novoGado.alimento = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ano de nascimento:");
        novoGado.nascimento.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mês de nascimento:");
        novoGado.nascimento.mes = Convert.ToInt32(Console.ReadLine());
        novoGado.abate = VerificarAbate(novoGado);
        return novoGado;
    }
    static char VerificarAbate(Gados novoGado)
    {
        if ((DateTime.Now.Year - novoGado.nascimento.ano + (DateTime.Now.Month - novoGado.nascimento.mes) / 12.0) > 5 || novoGado.leite < 40)
        {
            return Convert.ToChar("S");

        }
        else
        {
            return Convert.ToChar("N");
        }
    }
    static bool VerificarCodigo(List<Gados> lista, int codigo)
    {
        foreach (Gados gado in lista)
        {
            if (gado.codigo == codigo)
            {
                return true;
            }
        }
        return false;
    }
    static void AddGado(List<Gados> lista)
    {
        Gados novoGado = new Gados();
        Console.Write("Código da cabeça de gado:");
        novoGado.codigo = Convert.ToInt32(Console.ReadLine());
        if (VerificarCodigo(lista, novoGado.codigo))
        {
            Console.WriteLine("Código já em uso. Não é possível adicionar o gado.");
            ListarCodigo(lista, novoGado.codigo);
            return;
        }
        else
        { 
            lista.Add(InserirDados(novoGado));
        }
    }
    static void AlterarGado(List<Gados> lista, int codigoBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].codigo == codigoBusca)
            {
                ListarCodigo(lista, codigoBusca);
                flag = true;
                Gados novoGado = new Gados();
                novoGado.codigo = lista[i].codigo;
                Console.WriteLine("\n\t*** Dados a serem alterados ***");
                lista[i] = InserirDados(novoGado);
            }
        }
        if (!flag)
            Console.Write("Gado não encontrado.");
    }
    static void AbaterGado(List<Gados> lista, int codigoBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = qtd - 1; i >= 0; i--)
        {
            if (lista[i].codigo == codigoBusca)
            {
                flag = true;
                ListarCodigo(lista, codigoBusca);
                if (lista[i].abate == Convert.ToChar("S"))
                {
                    Console.Write("\nTem certeza que deseja abater o Gado? 0 - não / 1 - sim: ");
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
                else
                {
                    Console.WriteLine("Gado não está pronto para o abate!");
                }
            }
        }
        if (!flag)
            Console.Write("Gado não encontrado.");
    }
    static void ListarGados(List<Gados> lista)
    {
        decimal leiteTotal = 0;
        decimal alimentoTotal = 0;
        int qtd = lista.Count();
        int count = 0;
        for (int i = 0; i < qtd; i++)
        {
            MostraDados(lista, i);
            leiteTotal += lista[i].leite;
            alimentoTotal += lista[i].alimento;
            count++;
        }
        if (count > 1)
        {
            Console.WriteLine("\n\t*** Produção semanal ***");
            Console.WriteLine($"Total de leite produzido: {leiteTotal}");
            Console.WriteLine($"Total de alimento consumido: {alimentoTotal}");
        }
    }
    static void ListarCodigo(List<Gados> lista, int codigoBusca)
    {
        int count = 0;
        decimal leiteTotal = 0;
        decimal alimentoTotal = 0;
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].codigo == codigoBusca)
            {
                MostraDados(lista, i);
                leiteTotal += lista[i].leite;
                alimentoTotal += lista[i].alimento;
            }
            count++;
        }
        if (count > 1)
        {
            Console.WriteLine("\n\t*** Produção semanal ***");
            Console.WriteLine($"Total de leite produzido: {leiteTotal}");
            Console.WriteLine($"Total de alimento consumido: {alimentoTotal}");
        }
    }
    static void FiltrarAbate(List<Gados> lista)
    {
        int count = 0;
        decimal leiteTotal = 0;
        decimal alimentoTotal = 0;
        int qtd = lista.Count();
        bool abate;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].abate == Convert.ToChar("S"))
            {
                MostraDados(lista, i);
                leiteTotal += lista[i].leite;
                alimentoTotal += lista[i].alimento;
            }
            count++;
        }
        if (count > 1)
        {
            Console.WriteLine("\n\t*** Produção semanal ***");
            Console.WriteLine($"Total de leite produzido: {leiteTotal}");
            Console.WriteLine($"Total de alimento consumido: {alimentoTotal}");
        }
    }
    static void SalvarDados(List<Gados> lista, string nomeArquivo)
    {

        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (Gados Gado in lista)
            {
                writer.WriteLine($"{Gado.codigo};{Gado.leite};{Gado.alimento};{Gado.abate};{Gado.nascimento.mes};{Gado.nascimento.ano}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }
    static void carregarDados(List<Gados> lista, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                Gados Gado = new Gados
                {
                    codigo = Convert.ToInt32(campos[0]),
                    leite = Convert.ToDecimal(campos[1]),
                    alimento = Convert.ToDecimal(campos[2]),
                    abate = Convert.ToChar(campos[3]),
                };
                DataNascimento nascimento = new DataNascimento
                {
                    mes = Convert.ToInt32(campos[4]),
                    ano = Convert.ToInt32(campos[5])
                };
                Gado.nascimento = nascimento;
                lista.Add(Gado);
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
        Console.WriteLine("*** Sistema de cadastro de Gados ***");
        Console.WriteLine("1-Adicionar cabeça de gado");
        Console.WriteLine("2-Listar");
        Console.WriteLine("3-Filtrar por código");
        Console.WriteLine("4-Filtrar abate");
        Console.WriteLine("5-Alterar");
        Console.WriteLine("6-Abater gado");
        Console.WriteLine("0-Sair");
        Console.Write("Entre com uma opção: ");
        int op;
        try
        {
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Por favor, entre com uma opção válida");
            op = 0;
            return op;
        }
    }
    static void Main()
    {
        List<Gados> lista = new List<Gados>();
        int op;
        carregarDados(lista, "dados.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    AddGado(lista);
                    break;
                case 2:
                    ListarGados(lista);
                    break;
                case 3:
                    Console.Write("Digite um código a ser listado: ");
                    int codigoBusca = Convert.ToInt32(Console.ReadLine());
                    ListarCodigo(lista, codigoBusca);
                    break;
                case 4:
                    FiltrarAbate(lista);
                    break;
                case 5:
                    Console.Write("Digite o código do gado a ser alterado: ");
                    codigoBusca = Convert.ToInt32(Console.ReadLine());
                    AlterarGado(lista, codigoBusca);
                    break;
                case 6:
                    Console.Write("Digite o código do gado a ser abatido: ");
                    codigoBusca = Convert.ToInt32(Console.ReadLine());
                    AbaterGado(lista, codigoBusca);
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