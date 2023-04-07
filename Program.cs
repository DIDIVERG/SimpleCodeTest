// See https://aka.ms/new-console-template for more information
using SimpleCode;

var A = new []
{
    "unlock.microvirus.md","visitwar.com.md","visitwar.de","fruonline.co.uk","australia.open.com",
    "credit.card.us"
};

var  B = new []{"microvirus.md","visitwar.de","piratebay.co.uk","list.stolen.credit.card.us"};
foreach (var item in Solution.solution(A,B))
{
    Console.WriteLine(item);
}