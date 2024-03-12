using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        int programmingscores = 40;
        int mathscores = 70;
        int physicsscores = 69;
        double a =  programmingscores +  mathscores +  physicsscores; //сумма баллов
        int b = (int)a / 3; // средний балл
        double c =  a / 3; // среднее арифметическое
        string cFormated = c.ToString("#.#"); // ограничение чисел после запятой
        string pattern = "Сумма баллов: {0} \nсредний балл: {1} \nсреднее арифметическое баллов: {2}";
        Console.WriteLine(pattern,
             a,
             b,
             cFormated);
        ReadKey();
    }
}