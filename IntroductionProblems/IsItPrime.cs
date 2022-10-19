 /*
     *  Problem Description:
            Given an integer A as input, you have to tell whether it is a prime number or not.
            A prime number is a natural number greater than 1 which is divisible only by 1 and itself.

        Problem Constraints:
            1 <= A <= 106

        Input Format:
            First and only line of the input contains a single integer A.

        Output Format:
            Print YES if A is a prime, else print NO.

        Example Input:
            Input 1: 3 
            Input 2: 4 

        Example Output:
            Output 1: YES 
            Output 2: NO 

        Example Explanation:
            Explanation 1: 3 is a prime number as it is only divisible by 1 and 3.
            Explanation 2: 4 is not a prime number as it is divisible by 2.
*/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        bool breakLoop = false;
        int count = 0;
        //Console.WriteLine("Enter number you want to Check: ");
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i = 2; i <= Math.Floor(Math.Sqrt(input)) ; i++){
            if(!breakLoop){
                if(input % i == 0){
                    count++;
                    break;
                }
            }
        }
        if(count == 0){
            Console.WriteLine("YES");
        }
        else{
            Console.WriteLine("NO");
        }
    }
}
