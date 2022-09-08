// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Заполнение массива
void FillingTheArray(int[,] arr, int n)
    {
        if(n<2)
            arr[0,n] = Convert.ToInt32(Console.ReadLine());
        else
            arr[1,n-2] = Convert.ToInt32(Console.ReadLine());
        return;
    }

// Определяем точку пересечения
void Point(int[,] arr)
    {
        float x;
        float y;
        if(arr[0,0]==arr[1,0])
            {
                Console.WriteLine("Прямые паралельны");
                return;
            }
        x=(arr[0,1]-arr[1,1]);
        y=(arr[1,0]-arr[0,0]);
        x=x/y;
        y=arr[0,0]*x+arr[0,1];
        Console.WriteLine("Координаты точки (" + x + ": " + y + ")");
        return;
    }

// Программа
int[,] array = new int[2,2];
Console.WriteLine("Введите значения для первой прямой (k1 и b1)");
FillingTheArray(array,0);
FillingTheArray(array,1);
Console.WriteLine("Введите значения для второй прямой (k2 и b2)");
FillingTheArray(array,2);
FillingTheArray(array,3);
Point(array);