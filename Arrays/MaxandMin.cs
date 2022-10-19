using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MAIN  {
    public static void Main(string[] args) {
        string[] s = Console.ReadLine().Split(' ');
        int N = Int32.Parse(s[0]);
        int max = Int32.MinValue, min = Int32.MaxValue;
        for (int i = 0; i < N; i++) {
            int num = Int32.Parse(s[i + 1]);
            max = Math.Max(max, num);
            min = Math.Min(min, num);
        }
        Console.Write(max + " " + min);
    }
}