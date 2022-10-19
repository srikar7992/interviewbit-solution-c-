using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        var input = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++){
            Console.WriteLine($"{input} * {i} = {input * i}");
        }
    }
}
