﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadanieTablicaTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length - 1;

            string[][] tab = new string[liczbaWierszy][];

            for (int i = 1; i <= liczbaWierszy; i++)
                tab[i - 1] = wiersze[i].Split(';');

            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(String.Join(" ", tab[i]));

            Console.ReadKey();
        }
    }
}
