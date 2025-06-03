//Maior Idade
/*
int idade;
Console.WriteLine("Informe sua idade!");

idade = Convert.ToInt32(
    Console.ReadLine());


if(idade >=18)
{
    Console.WriteLine($"Sua idade é {idade}, você é maior de idade");
}

else
{
    Console.WriteLine($"Sua idade é {idade}, você nâo completou a maioridade"); 
}
*/



//Salario Comum
/*
//Salário mínimo ou salário comum
const decimal salarioMinimo = 1518m;
decimal salarioPessoa;

Console.WriteLine("Informe o seu salário:");

salarioPessoa =decimal.Parse(Console.ReadLine());

if (salarioMinimo == salarioPessoa)
{
    Console.WriteLine("Seu salário é minímo");
}
else
{
    Console.WriteLine("Seu salário é comum");
}
*/


float num1 = 0f;
float num2 = 0f;
string operacacaoMatematica;
string opcao;

while (true)
{


    Console.WriteLine("informe a operação matematica: \n" +
        "+ ou - ou * ou /");
    operacacaoMatematica = Console.ReadLine();

    Console.WriteLine("informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("informe o segundo valor");
    num2 = float.Parse(Console.ReadLine());
    #region Estrutura IF
    /*
    if (operacacaoMatematica == "+")
    {
        //Adição
        Console.WriteLine($"Soma: {(num1 + num2):F2}");
    }

    else if (operacacaoMatematica == "*")
    {
        //Multiplicação
        Console.WriteLine($"Multiplicação {(num1 * num2):F2}");
    }

    else if (operacacaoMatematica == "-")
    {
        //Subtração
        Console.WriteLine($"Subtração {(num1 - num2):F2}");
    }

    else if (operacacaoMatematica == "/")
    {
        //Divisão
        Console.WriteLine($"Divisão {(num1 / num2):F2}");
    }

    else
    {
        Console.WriteLine("Operação invalida")
    }
    */
    #endregion

    switch (operacacaoMatematica)
    {
        case "+":
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;

        case "-":
            Console.WriteLine($"Subtração: {(num1 - num2):F2}");
            break;

        case "*":
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
            break;

        case "/":
            Console.WriteLine($"Divisão: {(num1 / num2):F2}");
            break;

        default:
            Console.WriteLine("Informe uma opção válida");
            break;
    }
    Console.WriteLine("Deseja continuar s/n"); 
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        break;
    }
    else {  Console.Clear(); }
}
