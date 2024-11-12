using BenchmarkDotNet.Attributes;

namespace Lesson9;

public class Benchmark
{
    [Benchmark]
    public void MicrosoftSort()
    {
        int[] array = { 5, 3, 8, 4, 2, 1, 9, 7, 6 };

        Array.Sort(array);
    }

    [Benchmark]
    public void CustomBubleSort()
    {
        int[] array = { 5, 3, 8, 4, 2, 1, 9, 7, 6 };
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}