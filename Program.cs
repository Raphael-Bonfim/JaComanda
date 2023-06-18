using System.Drawing;

namespace JaComanda;

class Program
{
    static void Main(string[] args)
    {
        Iniciar();
    }

    static void Cabecalho()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("==========     JÁ COMANDA      ===========");
        Console.WriteLine("------------------------------------------");
    }
    static void Iniciar()
    {
        Console.Clear();

        Cabecalho();

        Thread.Sleep(1500);

        Console.WriteLine("");
        Console.WriteLine("               Bem vindo!");
        Console.WriteLine("");

        Thread.Sleep(1000);
        Console.WriteLine(" Pressione qualquer tecla para continuar...");


        Console.ReadKey();
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Cabecalho();

        Console.WriteLine("");
        Console.WriteLine("           O que deseja fazer?");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(" 1 - Criar nova comanda");
        Console.WriteLine(" 2 - Consultar comandas");
        Console.WriteLine(" 0 - Sair");

        short opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: CriarComanda(); break;
            case 2: ConsultarComanda(); break;
        }
    }

    static void ConsultarComanda()
    {
        throw new NotImplementedException();
    }

    static void CriarComanda()
    {
        Console.Clear();

        Random numComanda = new Random();
        string comandaNumerada = "Comanda: " + numComanda.Next(0,20);
        string numGarcom = "Número Garçom: ";
        string numMesa = "Número Mesa: ";
        string horario = "Horario: ";
        string qtPessoas = "Quantidade de pessoas: ";
        string entrada = "Entrada: ";
        string pratoPrincipal = "Prato Principal: ";

        string comanda = "";

        for (int i = 0; i < 7; i++)
        {
            switch (i)
            {
                case 0:                  
                    comanda += comandaNumerada;
                    comanda += Environment.NewLine;
                    break;
                case 1:
                    Console.WriteLine(numGarcom);
                    PreencherComanda(numGarcom);
                    break;

                case 2:
                    Console.WriteLine(numMesa);
                    PreencherComanda(numMesa);
                    break;
                case 3:
                    Console.WriteLine(horario);
                    PreencherComanda(horario);
                    break;
                case 4:
                    Console.WriteLine(qtPessoas);
                    PreencherComanda(qtPessoas);
                    break;
                case 5:
                    Console.WriteLine(entrada);
                    PreencherComanda(entrada);
                    break;
                case 6:
                    Console.WriteLine(pratoPrincipal);
                    PreencherComanda(pratoPrincipal);
                    break;                            
            }

        }

        SalvarComanda(comanda);

        void PreencherComanda(string valor)
        {
            do
            {
                comanda += valor += Console.ReadLine();
                comanda += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }

    static void SalvarComanda(string comanda)
    {
        Console.Clear();
        Console.WriteLine(comanda);

        var path = "C:\\Curso";

        //using (var arquivo = new StreamWriter(path))
        //{
        //    arquivo.Write(comanda);
        //}

        Console.WriteLine($"Comanda criada com sucesso!");
        Console.ReadKey();
        Menu();

    }
}
