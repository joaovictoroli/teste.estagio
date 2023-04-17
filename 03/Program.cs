using _03;

var FaturamentoMensal = new List<Faturamento>();


for (int i = 0; i < 30; i++)
{
    var newFaturamento = new Faturamento()
    {
        Dia = i + 1,
        ValorFaturamento = GetRandomNumber()
    };
    FaturamentoMensal.Add(newFaturamento);
}

double maiorFaturamento = 0;
double menorFaturamento = 100;
double soma = 0;

foreach (var item in FaturamentoMensal)
{
    if (item.ValorFaturamento > maiorFaturamento)
    {
        maiorFaturamento = item.ValorFaturamento;
    }
    if (item.ValorFaturamento < menorFaturamento)
    {
        menorFaturamento = item.ValorFaturamento;
    }

    soma = soma + item.ValorFaturamento;
}

var media = soma / 30;


// media retirar os dias com 0 de faturamento
var list0 = FaturamentoMensal.Where(x => x.ValorFaturamento == 0);
int totalDias = 30;
if (list0.Count() > 0)
{
    totalDias = totalDias - list0.Count();
}

media = soma / totalDias;
Console.WriteLine("A média de faturamento diario nesse mes analisado foi de: " + Math.Round(media, 2));

//maior e menor valor

Console.WriteLine("O maior valor de faturamento foi de " + maiorFaturamento + " , no dia: " + FaturamentoMensal.FirstOrDefault(x => x.ValorFaturamento == maiorFaturamento).Dia);
Console.WriteLine("O menor valor de faturamento foi de " + menorFaturamento + " , no dia: " + FaturamentoMensal.FirstOrDefault(x => x.ValorFaturamento == menorFaturamento).Dia);
// func
double GetRandomNumber()
{
    double minimum = 0;
    double maximum = 100;
    Random random = new Random();
    var result = random.NextDouble() * (maximum - minimum) + minimum;
    return Math.Round(result, 2);
}