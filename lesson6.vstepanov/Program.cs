using System;
using System.Linq;
using System.Security.Cryptography;

namespace lesson6.vstepanov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            Task13();
        }

        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int minValue = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minValue)
                {
                    minValue = a[i];
                }
            }

            Console.WriteLine(minValue);

            Console.ReadLine();


        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 245, 400, 700, 5, 12, 13, 2, 1, 9, 15, 19, 850 };

            int maxValue1 = a[0]; //задаем первую переменную и приравниваем её в первому значению в массиве

            for (int i = 1; i < a.Length; i++) //начиная со второго значения перебираем массив до тех пор. пока не найдем макс значение
            {
                if (a[i] > maxValue1)
                {
                    maxValue1 = a[i];
                }
            }

            int maxValue2 = a[0]; // задаем вторую переменную максимум которой будем искать

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] > maxValue2) //аналогично перебираем
                {
                    if (a[i] == maxValue1) //если значение равно макс1 пропускаем, иначе присваиваем новое значение. Т.о. исключаем макс1
                        continue;
                    maxValue2 = a[i];
                }
            }

            Console.WriteLine(maxValue1);
            Console.WriteLine(maxValue2);


            Console.ReadLine(); 
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int sumMassive = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                sumMassive = sumMassive + a[i];
            }

            Console.WriteLine($"Сумма массива равна {sumMassive}");

            Console.ReadLine();

            //int sumMassive = a.Sum();
            //Console.WriteLine(sumMassive);
            //Console.ReadLine();

        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int n = 100;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)//возможно решить 2-ся путями. 1- через прибавление единицы в цикле. 2. через вычитание 1 из i в цикле, i растет само, так как есть инкремент
            {
                a[i] = i+1; 
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            int n = 10;

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int r = rnd.Next(1, n);//случайное число от 1 до ...

                if (i < n) // использовал условия для проверки, но по факту усложнил, так как крайнее значение n не берется. Можно было отказаться от него, так как крайнее значение и так возьмется через инкремент 
                {
                    a[i] = r;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine();

        }

        public static void Task5v2()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            int n = 10;

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int r = rnd.Next(1, n);//случайное число от 1 до ...
                    a[i] = r;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine();

        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] {15, 5, 13, 2, 1, 9, 15, 19, 6 };

            //с сортировкой массива и дальнейшим сравнением соседних элементов

            //сортировка
            //int temp;
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < a.Length; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            temp = a[i];
            //            a[i] = a[j];
            //            a[j] = temp;
            //        }
            //    }
            //}

            ////вывод
            //Console.WriteLine("Вывод отсортированного массива");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //Console.ReadLine();

            ////поиск одинаковых чисел
            //Console.WriteLine("Поиск одинаковых чисел");
            //int temp2 = 0;
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    if (a[i] == a[i + 1] && a[i] != temp2)
            //    {
            //        temp2 = a[i];
            //        Console.WriteLine(a[i] + "Одинаковые числа");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Одинаковых чисел нет");
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //цикл в цикле

            bool result = false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            //int j = 0; //вариант с чтением массива с конца и записью данных в начало. При этом инткремент второго массива в рамках цикла

            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    b[j] = a[i];
            //    Console.Write($"{b[j]} ");
            //    j++;
            //}
            //Console.ReadLine();

            for (int i = 0; i < a.Length; i++) //вариант чтения с начала и записью в конец
            {
                b[a.Length - i - 1] = a[i];
            }

        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            ////Console.WriteLine("Вывод развернутого массива (при помощи цикла for):");

            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    //Console.Write($"{a[i]} ");
            //    int t = a[i];
            //    a[] = t;

            //}

            //Console.ReadLine();

            //второй вариант. Решение через одновременное переставление крайних значение массива

            //for (int i = 0; i < a.Length / 2; i++)
            //{
            //    int t = a[i];
            //    a[i] = a[a.Length-1-i];
            //    a[a.Length-1-i] = t;
            //}

        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] 
            { 
                { 11, 22, 31 }, 
                { 4, 53, 6 }, 
                { 7, 81, 90 } 
            };

            int Sum = 0;

            int columns = m.GetUpperBound(0)+1;
            int rows = m.Length / columns;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Sum += m[i, j];
                }

            }

            Console.WriteLine(Sum);

            Console.ReadLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Sum = Sum + m[i, j];
            //    }
            //}

            //Console.WriteLine($"Сумма массива равна: {Sum}");

            //Console.ReadLine();

        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
            //объявление массива и его размерности
            int p = 10;
            int n = 100;
            int [,] Mass = new int[p,p];

            //заполнение массива
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Random rnd = new Random();
                    int r = rnd.Next(1, n);//случайное число от 1 до ...
                    Mass[i, j] = r;
                }
            }

            //вывод верхней строки
            Console.WriteLine("Получили массив");
            for (int i = 0; i < p; i++)
            {
                Console.Write($"\t{i}");
            }

            Console.WriteLine();

            //вывод масссива

            for (int i = 0; i < p; i++)
            {
                Console.Write($"{i}");
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"\t{Mass[i,j]}");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] 
            { 
                { 11, 22, 31 }, 
                { 4, 53, 6 }, 
                { 7, 81, 90 } 
            };
            int[] n = new int[m.Length];

            int columns = m.GetUpperBound(0) + 1;
            int rows = m.Length / columns;

            int k = 0; //вводим счетчик с целью продвижения по одномерному массиву
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    n [k]= m[i, j];
                    k++;
                }

            }

            //for (int i = 0; i < 3; i++)//не ясно как находить размерность массива по осям и объявлять их в виде условия. Пишу руками в теле условия
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        n[i * 3 + j] = m[i, j];
            //    }
            //}

            ////вывод массива
            //Console.WriteLine("Одномерный массив");
            //for (int i = 0; i < 3; i++)//не ясно как находить размерность массива по осям и объявлять их в виде условия
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{n[i*3+j]}\t");
            //    }
            //}

            //Console.ReadLine();
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            //int ostatok = 4 % 2; //будет равен нулю

            //объявление массива
            int p = 10; //размерность массива
            int n = 99; //максимальное случайное число

            int[,] Mass = new int[p, p];

            //заполнение массива случайными значениями
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Random rnd = new Random();
                    int r = rnd.Next(1, n);//случайное число от 1 до ...
                    Mass[i, j] = r;
                }
            }

            //поиск четных чисел
            int count = 0;
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    if (Mass[i,j]%2==0)
                    {
                        count++;
                    }
                }
            }

            //вывод массива

            Console.WriteLine("Получили такой массив");

            for (int i = 0; i < p; i++)
            {
                Console.Write($"{i}");
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"\t{Mass[i, j]}");
                }
                Console.WriteLine();
            }

            //вывод кол-ва четных чисел

            Console.WriteLine();
            Console.WriteLine($"Всего четных чисел: {count}");
        }

        /// <summary>Скопировать одномерный массив в массиво размерностью 4*4</summary>
        /// 
        public static void Task13()
        {
            int size = 4;
            int[] m = new int[] { 11, 22, 31, 4, 53, 6, 7, 81, 90, 11, 22, 31, 4, 53, 12, 7};
            int[,] n = new int [size, size];

            int k = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    n[i, j] = m[k];
                    k++;
                }
            }

        }
    }
}
