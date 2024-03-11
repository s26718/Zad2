namespace Zad2;

class Program
{
    static void Main(string[] args)
    {
        int average = CalculateAverage(new int[5] { 0, 4, 6, 8, 10 });
        int max = CalculateMax(new int[5] { 0, 4, 6, 8, 10 });
        Console.WriteLine(average);
        Console.WriteLine(max);
    }

    

    static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[u] > max)
            {
                max = numbers[f];
            }
        }

        return max;
    }

}