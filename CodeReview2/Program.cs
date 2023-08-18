
//public static void Main(string[] args)
//{

//}

//public static int ServClasseD()
//{
//    //TaxaServ + Hosp
//    return 10 + 200;
//}

//public static int ServClasseC()
//{
//    //TaxaServ + Hosp + Cafe + Almoço
//    return 10 + 350 + 30 + 70;
//}


//public static int ServClasseB()
//{
//    //TaxaServ + Hosp + Cafe + Almoço + Janta
//    return 10 + 350 + 30 + 70 + 80;
//}

//public static int ServClasseA()
//{
//    //TaxaServ + Hosp + Cafe + Almoço + Janta + VIP
//    return 10 + 350 + 30 + 70 + 80 + 500;
//}
//}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Melhoria: Exemplo de uso
        Console.WriteLine("Custo Classe D: " + ServClasseD());
        Console.WriteLine("Custo Classe C: " + ServClasseC());
        Console.WriteLine("Custo Classe B: " + ServClasseB());
        Console.WriteLine("Custo Classe A: " + ServClasseA());

        // Aguarda a entrada do usuário antes de encerrar
        //Dessa forma,mantém o terminal aberto após a execução da aplicação para visualizar os resultados.
        Console.ReadLine();
    }

    // Melhoria: Extrair constantes para evitar repetição de valores
    private const int TaxaServ = 10;
    private const int Hosp = 350;
    private const int Cafe = 30;
    private const int Almoco = 70;
    private const int Janta = 80;
    private const int VIP = 500;

    public static int ServClasseD()
    {
        // Melhoria: Usar as constantes definidas para calcular o custo
        return TaxaServ + Hosp;
    }

    public static int ServClasseC()
    {
        return TaxaServ + Hosp + Cafe + Almoco;
    }

    public static int ServClasseB()
    {
        return TaxaServ + Hosp + Cafe + Almoco + Janta;
    }

    public static int ServClasseA()
    {
        return TaxaServ + Hosp + Cafe + Almoco + Janta + VIP;
    }
}
//Principais melhorias aplicadas:

//Adicionei exemplos de uso no método Main para ilustrar como os métodos de cálculo podem ser utilizados.
//Defini constantes para os valores repetidos, melhorando a legibilidade e aplicando o princípio DRY (Don't Repeat Yourself).
//Substituí os valores repetidos nos métodos pelos nomes das constantes correspondentes.
//O código agora está mais limpo, mais legível e segue o princípio DRY, evitando repetições desnecessárias de código.