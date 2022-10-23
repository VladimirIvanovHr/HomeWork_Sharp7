 void Zadacha47()
        // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        {
        Random random = new Random();
        int rows = 3;
        int columns = 4;
        
        double[,] numbers = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = random.NextDouble() * 20 - 10;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(Math.Round(numbers[i, j], 1) + "\t");
            }
            Console.WriteLine();
        }
        }

        void Zadacha50()
        //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
        // и возвращает значение этого элемента или же указание, что такого элемента нет.

        {
        Random random = new Random();
        int rows = 3;
        int columns = 4;
               
        int [,] numbers = new int[rows, columns];

        FillArray(numbers);
        PrintArray(numbers);
        Search(numbers); 
        
            
            void FillArray (int[,] num)
            {
            for (int i = 0; i < rows; i++)
            {
                Random random = new Random();
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(-10, 10);
                }
            }
            }
            void PrintArray (int[,] num)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            void Search (int[,] num)
            {
                Console.WriteLine ("Введите 1-й индекс элемента");
                int index1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ("Введите 2-й индекс элемента");
                int index2 = Convert.ToInt32(Console.ReadLine());

                if (index1 < rows & index2  < columns )
                {
                   int i= index1;
                   int j= index2;
                   Console.Write(numbers[i, j]);
                }

                else  Console.WriteLine ("Такого элемента нет");
            }
        }
        void Zadacha52()
        //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

        {
        Random random = new Random();
        int rows = 3;
        int columns = 4;
               
        int [,] numbers = new int[rows, columns];

        FillArray(numbers);
        PrintArray(numbers);
        Mean(numbers);
        
        
            
            void FillArray (int[,] num)
            {
            for (int i = 0; i < rows; i++)
            {
                Random random = new Random();
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                }
            }
            }
            void PrintArray (int[,] num)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            void Mean (int[,] num)
            {
                for (int j= 0; j < columns; j++)
                {
                    double sum = 0;
                    double mean = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        sum = sum + numbers[i,j];
                    }
                    mean = sum/rows;
                    Console.Write($"Среднее арифметическое {j}-го столбца: {Math.Round(mean, 1)}");
                    Console.WriteLine();
                }
            }
        }

Zadacha52();
    
  