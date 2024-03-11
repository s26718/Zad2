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

    static int CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum / numbers.Length;
    }

    static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

}