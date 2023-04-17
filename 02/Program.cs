int input = 34;

var finobaci = new List<int>();
finobaci.Add(0);
finobaci.Add(1);

for (int i = 2; i >= 0; i++)
{
    int n1 = finobaci[i - 1];
    int n2 = finobaci[i - 2];
    int soma = n1 + n2;

    if (soma > input)
    {
        Console.WriteLine("Numero não está presente na finobaci");
        break;
    }
    if (soma == input)
    {
        Console.WriteLine("Numero está presente na finobaci");
        break;
    }

    finobaci.Add(soma);    
}

