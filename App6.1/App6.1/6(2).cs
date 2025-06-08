using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        string w = "информатика";

        string WordNumOne = string.Concat(w.Substring(w.IndexOf('ф'), 1),
                                     w.Substring(w.IndexOf('и'), 1),
                                     w.Substring(w.IndexOf('р'), 1),
                                     w.Substring(w.IndexOf('м'), 1),
                                     w.Substring(w.IndexOf('а'), 1));

        Console.WriteLine(WordNumOne);

        string k = "информатика";

        string WordNumTwo = string.Concat(k.Substring(k.IndexOf('к'), 1),
                                     k.Substring(k.IndexOf('о'), 1),
                                     k.Substring(k.IndexOf('р'), 1),
                                     k.Substring(k.IndexOf('м'), 1),
                                     k.Substring(k.IndexOf('а'), 1));

        Console.WriteLine(WordNumTwo);
    }
}
