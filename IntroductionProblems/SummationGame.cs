using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        int input = Convert.ToInt32(Console.ReadLine());
        int output = input * (input + 1) / 2;
        Console.WriteLine(output);
    }
}
