using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Pause()
        {
            Console.ReadLine();
        }


        #region Task 1
        static void Task1()
        {
            
            Console.Clear();
            Console.WriteLine("1. Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("Safroshkin R.A.\n");
            Console.WriteLine("Введите три числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"{a} Наибольшее число");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"{b} Наибольшее число");
            }
            else if (a==b && a==c)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine($"{c} Наименьшее число");
            }
        }
        #endregion
        #region Task 2
        static void Task2()
        {
            
            Console.Clear();
            Console.WriteLine("2. Написать метод подсчета количества цифр числа.");
            Console.WriteLine("Safroshkin R.A.\n");
            /*Вариант 1 (для халтурщиков)
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine($"В числе {str} количество цифр - {len}");
            */

            //Вариант 2 (как задумывалось в задании(или около того))
            Console.Write("Введите число для подсчета количества его символов: ");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            int i = 0;
            while(b>0)
            {
                b = b / 10;
                i++;
            }
            Console.WriteLine($"В числе {a} количество цифр - {i}");
        }
        #endregion
        #region Task 3
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("Safroshkin R.A.\n");
            Console.WriteLine("Эта приложение будет считать сумму нечетных положительных чисел");
            Console.WriteLine("Для окончания посдчета введите `0` ");
            int num;
            int count = 0;
            do
            {
                Console.Write("Введите число: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 != 0) 
                {
                    count = count + num;
                }
            }
            while (num != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел - {count}");
        }
        #endregion
        #region Task 4
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Реализовать метод проверки логина и пароля. \nНа вход метода подается логин и пароль. " +
                "На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). " +
                "\nИспользуя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. " +
                "\nС помощью цикла do while ограничить ввод пароля тремя попытками.\n");
            Console.WriteLine("Safroshkin R.A.\n");
            Console.WriteLine("Добро пожаловать, Пользователь!");
            Console.WriteLine("Для входа в личный кабинет введите логин и пароль.");
            int i = 0;
            string log;
            string pas;
            do
            {
                Console.Write("Введите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pas = Console.ReadLine();
                if (log == "root" && pas == "GeekBrains")
                {
                    Console.WriteLine("Добро пожаловать в Личный кабинет");
                    break;
                }
                 else
                {
                    Console.WriteLine("Неверный логин или пароль, повторите попытку!");
                    i++;
                    if (i == 3)
                    {
                        Console.WriteLine("Колличество попыток входа исчерапно, повторите попытку через час!");
                        break;
                    }
                }

            }
            while (i != 3);

            

        }

        #endregion
        #region Tast 5

        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, " +
                "нужно ли человеку похудеть, набрать вес или всё в норме.\nб) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.\n");
            Console.WriteLine("Safroshkin R.A.\n");
            Console.WriteLine("Введите ваш рост в метрах (прим. 1,75)");
            string height = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();

            float N_height = float.Parse(height);
            float N_weight = float.Parse(weight);

            float Mi = N_weight / (N_height * N_height);
            Console.WriteLine($"Индекс массы вашего тела {Mi}");

            if (Mi <= 18.4)
            {
                Console.WriteLine("У вас низкий вес");
                int i = 0;
                float Mi2;
                do
                {
                    Mi2 = N_weight / (N_height * N_height);
                    N_weight++;

                    i++;
                }
                while (Mi2 <= 18.4);
                Console.WriteLine($"До нормального веса вам нужно набрать {i} киллограмм(ов)");
            }
           
            else if (Mi >= 18.5 && Mi <= 24.9)
            {
                Console.WriteLine("Ваш вес в норме");
            }
            
            else if (Mi >= 25 && Mi <= 30.0)
            {
                Console.WriteLine("У вас легкая стадия ожирения");
                int i = 0;
                float Mi2;
                do
                {
                    Mi2 = N_weight / (N_height * N_height);
                    N_weight--;

                    i++;
                }
                while (Mi2 >= 25);

                Console.WriteLine($"До нормального веса вам нужно сбросить {i} киллограмм(ов)");
            }
            
            else
            {
                Console.WriteLine("У вас тяжелая стадия ожирения");
                int i = 0;
                float Mi2;
                do
                {
                    Mi2 = N_weight / (N_height * N_height);
                    N_weight--;

                    i++;
                }
                while (Mi2 >= 25) ;
                Console.WriteLine($"До нормального веса вам нужно сбросить {i} киллограмм(ов)");
            }


        }

        #endregion
        #region Task 6

        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. " +
                "\n«Хорошим» называется число, которое делится на сумму своих цифр. \nРеализовать подсчёт времени выполнения программы, используя структуру DateTime.\n");
            Console.WriteLine("Safroshkin R.A.\n");

            Console.WriteLine("Программа уже работает, ожидайте\n");
            int Gnum = 0;
            int min = 1;
            int max = 1000000000;
            int temp;
            int container;
            DateTime start = DateTime.Now;

            for (int num = min; num <= max; num++)
            {
                temp = 0;
                container = num;
                while (container != 0)
                {
                    temp += container % 10;
                    container /= 10;
                }
                if (num % temp == 0)
                {
                    Gnum++;
                }

                

            }
            Console.WriteLine($"Время выполнения приложения: {DateTime.Now - start}");
            Console.WriteLine($"Колличество хороших чисел в диапазоне от 1 до 1000000 - {Gnum} ");




        }

        #endregion
        #region Task 7
        static void Task7a(int a, int b)
        {
            if (a<=b)
            {
                Console.WriteLine(a);
                Task7a(a + 1, b);
            }

        }
        static int Task7b(int a, int b, int res)
        {
            if (a == b + 1)
                return res;
            else
            {
                res += a;
                a++;
                return Task7b(a, b, res);
            }
           
        }


        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 - 1");
            Console.WriteLine("Task 2 - 2");
            Console.WriteLine("Task 3 - 3");
            Console.WriteLine("Task 4 - 4");
            Console.WriteLine("Task 5 - 5");
            Console.WriteLine("Task 6 - 6");
            Console.WriteLine("Task 7 - 7");
            Console.WriteLine("Завершение работы программы - 0");

            int tn = 0;
            do
            {
                Console.Write("Введите номер задачи: ");
                tn = int.Parse(Console.ReadLine());

                switch (tn)
                {
                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Console.Clear();

                        Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).  " +
                            "\nб*Разработать рекурсивный метод, который считает сумму чисел от a до b.");
                        Console.Write("Safroshkin R.A. ");

                        Console.Write("Веедите число - начало диапазона: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Веедите число - конец диапазона: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Вывод чисел: ");
                        Task7a(a,b);
                        Console.WriteLine("Сумма чисел диапазона: ");
                        Console.WriteLine(Task7b(a, b, 0));

                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }
            while (tn != 0);

            Pause();
        }
    }
}
