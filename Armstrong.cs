using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(1);
        for(int i = 150; i <= input; i++){
            int num = i;
            int temp = num;
            int sum = 0;
            while(num > 0){
                int mod = num % 10;
                num = num / 10;
                sum += mod * mod * mod;
            }
            if(temp == sum){
                Console.WriteLine(temp);
            }
        }
        
    }
}
