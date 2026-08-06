//  beecrowd | 1064
// Positives and Average
// Adapted by Neilor Tonin, URI Brazil
// Timelimit: 1
// Read 6 values that can be floating point numbers. After, print how many of them were positive. In the next line, print the average of all positive values typed, with one digit after the decimal point.
// Input
// The input consist in 6 numbers that can be integer or floating point values. At least one number will be positive.
// Output
// The first output value is the amount of positive numbers. The next line should show the average of the positive values ​typed.

using System; 

class Ex1064 {

    static void Main(string[] args) { 
        float[] array = new float[6];
        int count = 0;
        float average = 0;
        for(int i = 0; i < 6; i++)
    {
      array[i] = float.Parse(Console.ReadLine());

      if(array[i] > 0)
      {
        average += array[i];
        count++;
      }
    }

    average = average / count;

    Console.WriteLine(count + " valores positivos");
    Console.WriteLine($"{average:F1}");

    }

}