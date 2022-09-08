// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Заполнение массива
void FillingTheArray(int[] arr)
    {
        for(int i=0; i<arr.Length; i++)
            arr[i]= Convert.ToInt32(Console.ReadLine());
    }

//  Подсчет чисел больше нуля
int PositiveNumbers(int[] arr)
    {
        int S = 0;
        for(int i=0; i<arr.Length; i++)
            if (arr[i]>0)
                S++;
        return S;
    }

// Тело программы
Console.Write("Сколько чисел желаете ввести - ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int[M];
Console.WriteLine("Введите числа - ");
FillingTheArray(array);

// Проверка ввода чисел
// Console.WriteLine("[{0}]",string.Join(",",array));

Console.WriteLine("Количество чисел больше 0 - " + PositiveNumbers(array));
