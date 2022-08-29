//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    
    int[] array = new int[8];
    Random myRandom = new Random();
    Console.Write('[');     
    for (int i = 0; i < array.Length; i++)
    
        {
            array[i] = myRandom.Next(0, 8);
           if (i>0) Console.Write(", ");
            Console.Write("{0} ", array[i]);
                        
        }
    Console.Write(']');
    Console.WriteLine();
     