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
        string fullName = "Борисенко Никита Александрович";
        byte age = 20;
        string email = "toc044toc@gmail.com";
        int programmingscores = 40;
        int mathscores = 70;
        int physicsscores = 69;
        double a =  programmingscores +  mathscores +  physicsscores; //сумма баллов
        int b = (int)a / 3; // средний балл
        double c =  a / 3; // среднее арифметическое
        string cFormated = c.ToString("#.#"); // ограничение чисел после запятой
        string pattern = "Ф.И.О.: {0} \nВозраст: {1} \nЭл.Почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} \nСумма баллов: {6} \nСредний балл: {7} \nСреднее арифметическое баллов: {8}";
        Console.WriteLine(pattern,
            fullName,
            age,
            email,
            programmingscores,
            mathscores,
            physicsscores,
             a,
             b,
             cFormated);
        ReadKey();
    }
}