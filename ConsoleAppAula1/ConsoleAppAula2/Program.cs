//Se o aluno tiver mais que 3 faltas 
//Rodo

//Se a nota do Aluno for menor que 60 
//Rodo

/*
string repeticao;
int nota;
int faltas;

 while (true)
{ 

Console.WriteLine("Insira sua nota:");
nota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira sua faltas:");
faltas = Convert.ToInt32(Console.ReadLine());

if (nota >= 60 || faltas <=3)
{
    Console.WriteLine("Você está aprovado");
}
else
{
    Console.WriteLine("Você vai repetir o ano");
}
    Console.WriteLine("Deseja continuar s/n");
    repeticao = Console.ReadLine();

    if (repeticao != "s")
    {
        break;
    }
    else { Console.Clear(); }
}
*/

#region Estrutura de Repeticao
//FOR 
/*
int contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada:");
tabuada = Convert.ToInt32(Console.ReadLine());

for(contador =0; contador <10;  contador++)
{
    Console.WriteLine($"{tabuada} X{contador} = {(tabuada * contador)}");
}

*/




//While
/*
int contador = 0;

while(contador<10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do
{
    Console.WriteLine(contador);
    contador++;
} while (contador < 10);
*/


//Foreach
/*
string[] nomes = {"Abacaxi", "Maçã", "Banana"};

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

Console.ReadKey();
*/

/*
string[] cores = {"Vermelho", "Red","Hot", "赤" };


foreach (string i in cores)
{
    Console.WriteLine(i);
}

Console.ReadKey();
*/

/*
int idadeAluno;
bool MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return true;
    }
    else
    {
        return false;

    }
}

void MaiorDeIdade2(int idade)
{ if(idade>=18)
    {
        Console.WriteLine("Aluno maior de idade");
    }

else { Console.WriteLine("Aluno menor de idade"); }

}

MaiorDeIdade2(15);




Console.WriteLine("Informe sua idade:");
idadeAluno= Convert.ToInt32(Console.ReadLine());
if(MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de idade");
}

else { Console.WriteLine("Aluno menor de idade"); }
*/

//Função para somar do tipo Void


using System.Reflection.Metadata.Ecma335;

void Soma(int num1, int num2)
{
    Console.WriteLine($"Soma dos valores: {num1 + num2}");
}

Soma(10, 20);






//Função que retorne a multiplicação Resultado Int

int Multi (int num1, int num2)
{
    return (num1 * num2);
}
int resultado = Multi(10, 20);
Console.WriteLine($"O resultado da multiplicação é {resultado}");




#endregion