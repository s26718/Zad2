namespace Zad2;

class Program
{
    static void Main(string[] args)
    {
        int average = CalculateAverage(new int[5] { 0, 4, 6, 8, 10 });
        Console.WriteLine(average);
    }

    static int CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum / numbers.Length;
    }
}