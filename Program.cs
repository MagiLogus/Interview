//Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima  
// 1.Total de Homens;      
// 2.Total de Mulheres;      
// 3.Média de idade dos Homens;      
// 4.Média de idade das mulheres.

int totalHomens = 0;
int totalMulheres = 0;
double mediaIdadeHomens = 0;
double mediaIdadeMulheres = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Entrevistado Nº{i}");
    
    Console.WriteLine($"Informe a sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"Informe o seu peso atual: ");
    double peso = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"Informe o seu sexo: (M) para masculino e (F) para feminino: ");
    char sexo = char.Parse(Console.ReadLine().ToUpper());
    
    if (sexo == 'M')
    {
        totalHomens++;
        mediaIdadeHomens += idade;
    }
    else if (sexo == 'F')
    {
        totalMulheres++;
        mediaIdadeMulheres += idade;
    }
    else
    {
        Console.WriteLine($"Digite um valor válido!");
    }
    
}

double calcMediaHomens = (mediaIdadeHomens / totalHomens); 
double calcMediaMulheres = (mediaIdadeMulheres / totalMulheres);

Console.WriteLine($"O total de homens é:{totalHomens}");
Console.WriteLine($"O total de mulheres é:{totalMulheres}");
Console.WriteLine($"A média de idade dos homens é: {calcMediaHomens}");
Console.WriteLine($"A média de idade dos homens é: {calcMediaMulheres}");