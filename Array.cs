namespace _KB;

class Array
{

// string[] numbers = new string[5];

//  int[] numbers = { 10, 20, 30, 40, 50 };
// Индекс:  |  0  |  1  |  2  |  3  |  4  |
// Значение:|  10 |  20 |  30 |  40 |  50 |


int[] numbers = { 10, 20, 30, 40, 50 };
 

    public void Arr()
    {
       Console.WriteLine(numbers);
       int firstNumber = numbers[0];
       int lengthArray = numbers.Length;
       numbers[3] = 10;
       Console.WriteLine(firstNumber);
       Console.WriteLine(lengthArray);
       Console.WriteLine(string.Join(", ", numbers));
}
}
