var palavra = "flamengo";

var charNome = palavra.ToArray();
var total = charNome.Count() - 1;

var charReverse = new char[total + 1];

for (int i = total; i >= 0; i--)
{
    charReverse[total - i] = charNome[i];
}

string response = new string(charReverse);
Console.WriteLine(response);