using System;
using System.IO;
class Program
{
    struct Eletrodomesticos
    {
        public string nome;
        public double potencia;
        public double tempoMedio;
        
    }

    static void AddEletrodomestico(List<Eletrodomesticos> lista)
    {
        Eletrodomesticos novoEletrodomestico = new Eletrodomesticos();
        Console.Write("Nome do eletrodomestico:");
        novoEletrodomestico.nome = Console.ReadLine();
        Console.Write("Potencia do eletrodomestico (kW/h):");
        novoEletrodomestico.potencia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Tempo médio de uso do eletrodoméstico (horas):");
        novoEletrodomestico.tempoMedio = Convert.ToDouble(Console.ReadLine());
        lista.Add(novoEletrodomestico);
    }
    static void AlterarEletrodomestico(List<Eletrodomesticos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Eletrodomesticos novoEletrodomestico = new Eletrodomesticos();
                Console.Write("Nome do eletrodomestico:");
                novoEletrodomestico.nome = Console.ReadLine();
                Console.Write("Potencia do eletrodomestico (kW/h):");
                novoEletrodomestico.potencia = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tempo médio de uso do eletrodoméstico (horas):");
                novoEletrodomestico.tempoMedio = Convert.ToDouble(Console.ReadLine());
                lista[i] = novoEletrodomestico;
            }

        }
        if (!flag)
            Console.Write("Eletrodomestico não encontrada.");
    }
    static void RemoverEletrodomestico(List<Eletrodomesticos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        bool flag = false;
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Equals(nomeBusca.ToUpper()))
            {
                flag = true;
                Console.WriteLine("\n\t*** Dados do eletrodomestico ***");
                Console.WriteLine($"Nome: {lista[i].nome}");
                Console.WriteLine($"Potência: {lista[i].potencia}");
                Console.WriteLine($"Tempo médio de uso: {lista[i].tempoMedio} horas");
                Console.Write("\nTem certeza que deseja remover o eletrodoméstico? 0 - não / 1 - sim: ");
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
            Console.Write("Eletrodoméstico não encontrada.");
    }
    static void ListarEletrodomesticos(List<Eletrodomesticos> lista)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            Double consumoMedio = lista[i].potencia * lista[i].tempoMedio;
            Console.WriteLine("\n\t*** Dados do eletrodoméstico ***");
            Console.WriteLine($"Nome: {lista[i].nome}");
            Console.WriteLine($"Potência: {lista[i].potencia} kW/h");
            Console.WriteLine($"Tempo médio: {lista[i].tempoMedio} horas");
            Console.WriteLine($"Consumo diário: {Math.Round(consumoMedio, 2)} kW");
            Console.WriteLine($"Consumo mensal: {Math.Round(consumoMedio * 30, 2)} kW");
        }
    }
    static void CalcularValor(List<Eletrodomesticos> lista, double valor)
    {
        int qtd = lista.Count();
        double somaConsumoCasa = 0;
        for (int i = 0; i < qtd; i++)
        {
            somaConsumoCasa = somaConsumoCasa + lista[i].potencia * lista[i].tempoMedio;
            Double consumoMedio = lista[i].potencia * lista[i].tempoMedio;
            Console.WriteLine("\n\t*** Dados do eletrodoméstico ***");
            Console.WriteLine($"Nome: {lista[i].nome}");
            Console.WriteLine($"Potência: {lista[i].potencia} kW/h");
            Console.WriteLine($"Tempo médio: {lista[i].tempoMedio} horas");
            Console.WriteLine($"Consumo diário (kW): {Math.Round(consumoMedio, 2)} kW");
            Console.WriteLine($"Consumo diário (R$): R${Math.Round(consumoMedio* valor, 2)}");
            Console.WriteLine($"Consumo mensal (kW): {Math.Round(consumoMedio * 30, 2)} kW");
            Console.WriteLine($"Consumo mensal (R$): R${Math.Round(consumoMedio * 30 * valor, 2)}");
        }
        Console.WriteLine("\n\t*** Consumo total da casa ***");
        Console.WriteLine($"Consumo diário da casa: {Math.Round(somaConsumoCasa, 2)} kW");
        Console.WriteLine($"Consumo diário da casa: {Math.Round(somaConsumoCasa * valor, 2).ToString("C")}");
        Console.WriteLine($"Consumo mensal da casa: {Math.Round(somaConsumoCasa * 30, 2)} kW");
        Console.WriteLine($"Consumo mensal da casa: {Math.Round(somaConsumoCasa * 30 * valor, 2).ToString("C")}");
    }
    static void ListarNome(List<Eletrodomesticos> lista, string nomeBusca)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].nome.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Double consumoMedio = lista[i].potencia * lista[i].tempoMedio;
                Console.WriteLine("\n\t*** Dados do eletrodomestico ***");
                Console.WriteLine($"Nome: {lista[i].nome}");
                Console.WriteLine($"Potência: {lista[i].potencia} kW/h");
                Console.WriteLine($"Tempo médio: {lista[i].tempoMedio} horas");
                Console.WriteLine($"Consumo diário: {Math.Round(consumoMedio, 2)} kW");
                Console.WriteLine($"Consumo mensal: {Math.Round(consumoMedio * 30, 2)} kW");
            }
        }
    }
    static void FiltrarPotencia(List<Eletrodomesticos> lista, double potenciaMinima)
    {
        int qtd = lista.Count();
        for (int i = 0; i < qtd; i++)
        {
            if (lista[i].potencia>=potenciaMinima)
            {
                Double consumoMedio = lista[i].potencia * lista[i].tempoMedio;
                Console.WriteLine("\n\t*** Dados do eletrodomestico ***");
                Console.WriteLine($"Nome: {lista[i].nome}");
                Console.WriteLine($"Potência: {lista[i].potencia} kW/h");
                Console.WriteLine($"Tempo médio: {lista[i].tempoMedio} horas");
                Console.WriteLine($"Consumo diário: {Math.Round(consumoMedio, 2)} kW");
                Console.WriteLine($"Consumo mensal: {Math.Round(consumoMedio * 30, 2)} kW");
            }
        }
    }
    static void SalvarDados(List<Eletrodomesticos> eletrodomestico, string nomeArquivo)
    {

        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (Eletrodomesticos eletro in eletrodomestico)
            {
                writer.WriteLine($"{eletro.nome};{eletro.potencia};{eletro.tempoMedio}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");


    }

    static void carregarDados(List<Eletrodomesticos> Eletrodomesticos, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                Eletrodomesticos eletrodomestico = new Eletrodomesticos
                {
                    nome = campos[0],
                    potencia = double.Parse(campos[1]),
                    tempoMedio = double.Parse(campos[2]),
                };
                Eletrodomesticos.Add(eletrodomestico);
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
        Console.WriteLine("*** Sistema de verificação de consumo de eletrodomésticos ***");
        Console.WriteLine("1-Adicionar eletrodoméstico");
        Console.WriteLine("2-Listar");
        Console.WriteLine("3-Listar por nome");
        Console.WriteLine("4-Filtrar por consumo");
        Console.WriteLine("5-Calcular gasto em R$");
        Console.WriteLine("6-Alterar");
        Console.WriteLine("7-Remover");
        Console.WriteLine("0-Sair");
        Console.Write("Entre com uma opção: ");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<Eletrodomesticos> listadeEletrodomesticos = new List<Eletrodomesticos>();
        int op;
        carregarDados(listadeEletrodomesticos, "dados.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    AddEletrodomestico(listadeEletrodomesticos);
                    break;
                case 2:
                    ListarEletrodomesticos(listadeEletrodomesticos);
                    break;
                case 3:
                    Console.Write("Digite um nome a ser listado: ");
                    string nomeBusca = Console.ReadLine();
                    ListarNome(listadeEletrodomesticos, nomeBusca);
                    break;
                case 4:
                    Console.Write("Digite a potência mínima para o filtro: ");
                    double potenciaFiltro = Convert.ToDouble(Console.ReadLine());
                    FiltrarPotencia(listadeEletrodomesticos, potenciaFiltro);
                    break;
                case 5:
                    Console.Write("Digite o valor do kW em R$: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    CalcularValor(listadeEletrodomesticos, valor);
                    break;
                case 6:
                    Console.Write("Digite o nome do eletrodomestico a ser alterada: ");
                    nomeBusca = Console.ReadLine();
                    AlterarEletrodomestico(listadeEletrodomesticos, nomeBusca);
                    break;
                case 7:
                    Console.Write("Digite o nome do eletrodoméstico a ser removido: ");
                    nomeBusca = Console.ReadLine();
                    RemoverEletrodomestico(listadeEletrodomesticos, nomeBusca);
                    break;
                case 0:
                    Console.WriteLine("Saindo");
                    SalvarDados(listadeEletrodomesticos, "dados.txt");
                    break;
            }
            Console.ReadKey();// pausa
            Console.Clear(); // limpa
        } while (op != 0);// fim while


        Console.ReadLine();//pause antes de fechar
    }

}// fim do programa