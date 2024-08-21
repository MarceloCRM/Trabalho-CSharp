using Trabalho_CSharp.uteis;

int opcao = 0;
float numero1 = 0;
float numero2 = 0;
do
{
    Console.WriteLine("Escolha uma opção!");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Subtrair");
    Console.WriteLine("3) Dividir");
    Console.WriteLine("4) Multiplicar");
    Console.WriteLine("5) Fatorial");
    Console.WriteLine("0) Fechar calculadora");
    
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Fim do programa.");
            break;
        case 1:
            LerDoisNumeros();
            Console.WriteLine($"O resultado da soma de {numero1} com {numero2} é {Calculadora.Somar(numero1, numero2)}");
            break;
        case 2:
            LerDoisNumeros();
            Console.WriteLine($"O resultado da subtração de {numero1} menos {numero2} é {Calculadora.Subtrair(numero1, numero2)}");
            break;
        case 3:
            LerDoisNumeros();
            Console.WriteLine($"O resultado da divisão de {numero1} por {numero2} é {Calculadora.Dividir(numero1, numero2)}");
            break;
        case 4:
            LerDoisNumeros();
            Console.WriteLine($"O resultado da multiplicação de {numero1} por {numero2} é {Calculadora.Multiplicar(numero1, numero2)}");
            break;
        case 5:
            Console.WriteLine("Insira um valor inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine($"O fatorial de {numeroInteiro} é {Calculadora.Fatorial(numeroInteiro)}");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
} while (opcao != 0);

void LerDoisNumeros()
{
    Console.WriteLine("Insira o 1º número: ");
    numero1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o 2º número: ");
    numero2 = float.Parse(Console.ReadLine());
}
