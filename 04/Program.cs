var SP = 67836.43;
var RJ = 36678.66;
var MG = 29229.88;
var ES = 27165.48;
var Outros = 19849.53;
var total = SP + RJ + MG + ES + Outros;

var restult = GetPercent(total, SP);
Console.WriteLine("Porcentagem do estado de SP: " + restult + "%");

restult = GetPercent(total, RJ);
Console.WriteLine("Porcentagem do estado de RJ: " + restult + "%");

restult = GetPercent(total, MG);
Console.WriteLine("Porcentagem do estado de MG: " + restult + "%");

restult = GetPercent(total, ES);
Console.WriteLine("Porcentagem do estado de ES: " + restult + "%");

restult = GetPercent(total, Outros);
Console.WriteLine("Porcentagem dos outros estados: " + restult + "%");

static double GetPercent(double total, double state)
{
    var percentage = (state * 100) / total;
    return Math.Round(percentage, 2);
}