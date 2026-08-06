// Write a program that prints all even numbers between 1 and 100, including them if it is the case.
// Input
// In this extremely simple problem there is no input.
// Output
// Print all even numbers between 1 and 100, including them, one by row.

using System; 
class Ex1059 {
    static void Main(string[] args) { 
      for(int i = 1; i <= 100; i++)
      {
        if(i % 2 == 0)
          {
            Console.WriteLine(i);
          }
      }
    }
}