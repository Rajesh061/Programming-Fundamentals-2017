﻿using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        while (true)
        {
            string x = Console.ReadLine();
            if (x == "end")
            {
                break;
            }
            List<string> curentRow = x.Split().ToList();

            string key = curentRow[0];
            string value = curentRow[2];

            dic[key] = value;
        }
        string change = Console.ReadLine();
        Dictionary<string, string> nullChangedDict = new Dictionary<string, string>();

        foreach (KeyValuePair<string, string> key in dic)
        {
            if (key.Value == "null")
            {
                nullChangedDict[key.Key] = change;
            }
        }
        Dictionary<string, string> dicOrderByLenghtValue = dic.OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);

        foreach (KeyValuePair<string, string> key in dicOrderByLenghtValue)
        {
            if (key.Value != "null")
            {
                Console.WriteLine("{0} <-> {1}", key.Key, key.Value);
            }
        }
        foreach (KeyValuePair<string, string> key in nullChangedDict)
        {
            Console.WriteLine("{0} <-> {1}", key.Key, change);
        }
    }
}