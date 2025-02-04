// namespace _KB
// {
//     class Lesson
//     {
//         private string a;
//         private int b;

//         public void Test()
//         {
//             Console.WriteLine("Введите своё имя:");
//             a = Console.ReadLine() ?? "Гость"; 
//             Console.WriteLine($"Привет, {a}!");
//             // Console.WriteLine("Привет, " + a + "!");

//             Console.WriteLine("Введите свой год рождения:");
//             string? input = Console.ReadLine();
//             if (int.TryParse(input, out b))
//             {
//                 Console.WriteLine($"Ваш год рождения: {b}");
//             }
//             else
//             {
//                 Console.WriteLine("Введено некорректное значение года рождения.");
//             }
//         }
//     }
// }
