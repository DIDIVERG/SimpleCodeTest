// See https://aka.ms/new-console-template for more information

using System.Collections;
using SimpleCode;

Console.WriteLine("Hello, World!");

var A = new []
{
    "unlock.microvirus.md","visitwar.com.md","visitwar.de","fruonline.co.uk","australia.open.com",
    "credit.card.us"
};

var  B = new []{"microvirus.md","visitwar.de","piratebay.co.uk","list.stolen.credit.card.us"};

Hashtable hashtable = new Hashtable();
hashtable.Add("a", "b");
Console.WriteLine($"{hashtable["a"]}");
Solution.solution(A, B);
Console.WriteLine();
Console.Read();