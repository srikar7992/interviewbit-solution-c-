using System;
using System.IO;
using System.Collections.Generic;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        int count = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < count; i++){
            isPerfectNumber(Convert.ToInt32(Console.ReadLine()));
        }
    }
    public static void isPerfectNumber(int num){
        int total = 1;
        for(int i = 2; i * i <= num; i++){
            if(num % i == 0){
                if(i * i != num){
                    total += i + num / i;
                }
                else{
                    total += i;
                }
            }
        }
        if(total == num && num != 1){
            Console.WriteLine("YES");
        }
        else{
            Console.WriteLine("NO");
        }
    }
}
