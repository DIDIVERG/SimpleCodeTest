using System.Collections;
namespace SimpleCode;
public  class Solution
{
    public static void PushDomain(Hashtable table, string[] domains)
    {
        if (!table.Contains(domains[0]))
        {
            table.Add(domains[0], new Hashtable());
        }
        for (int i = 0; i < domains.Length; i++) 
        {
            if (table.ContainsKey(domains[i]))
            { 
                table = table[domains[i]] as Hashtable;
                continue;
            }
            if (!table.ContainsKey(domains[i]))
            {
                if (domains.Length - 1 == i)
                {
                    table?.Add(domains[i] + ".", null);
                }
                table?.Add(domains[i], new Hashtable());
            }
        }
    }

    public static bool isAllowed(Hashtable table, string[] domains)
    {
        foreach (var item in domains)
        {
            if (table.ContainsKey(item + "."))
            {
                return false;
            }
            if (table.ContainsKey(item))
            {
                table = table[item] as Hashtable;
                continue;
            }
        }
        return true;
    }
    public static int[] solution(string[] A, string[] B)
    {
        Hashtable hashtable = new Hashtable();
        foreach (var item in B)
        {
            string [] splitted = item.Split('.');
            PushDomain(hashtable, splitted.Reverse().ToArray());
        }
        List<int> result = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            string[] splitted = A[i].Split(".");
            if (isAllowed(hashtable, splitted.Reverse().ToArray()))
            {
                result.Add(i);
            }
        }
        return result.ToArray();
    }
}