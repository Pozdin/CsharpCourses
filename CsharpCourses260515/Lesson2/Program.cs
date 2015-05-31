using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление и инициализация переменных.
            int ColumnsCount = 0;
            int RowsCount = 0;
            Random rand = new Random();

            string ColumnsString = "Введите число столбцов двумерного массива: ";
            // Вызов метода для отображения информации и ввода данных пользователем.
            InputData(ColumnsString, out ColumnsCount);

            string RowsString = "Введите число строк двумерного массива: ";
            // Вызов метода для отображения информации и ввода данных пользователем.
            InputData(RowsString, out RowsCount);

            // Объявляем и инициализируем массив.
            int[,] TwoDimensionArray = new int[RowsCount, ColumnsCount];
            Console.WriteLine();

            // Заполняем массив и печатаем его.
            for (int i = 0; i < TwoDimensionArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimensionArray.GetLength(1); j++)
                {
                    TwoDimensionArray[i, j] = rand.Next(1, 101);
                    Console.Write(TwoDimensionArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ввод числа строк/столбцов массива пользователем.
        /// </summary>
        /// <param name="s"> Строка с инфоромацией для пользователя. </param>
        /// <param name="count"> Число строк или столбцов массива. </param>
        static void InputData(string s, out int count)
        {
            // Выводим информацию на экран.
            Console.WriteLine(s);
            // Повторяем цикл бесконечно.
            while(true)
            {
                // Если ввели число больше 0, выходим из метода в Main.
                if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                {
                    return;
                }
                // Можно не указывать else, т.к. этот код в любом случае выполнится, если мы не покинем метод ранее.
                Console.WriteLine(s);
            }
        }
    }
}