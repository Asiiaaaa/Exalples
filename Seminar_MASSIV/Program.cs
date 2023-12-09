// Классическое решение
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23;
//int c2 = 133;
//int a3 = 10;
//int b3 = 8;
//int c3 = 62;

//int max= a1;
//if (b1>max) max = b1;
//if (c1>max) max = c1;
//if (a2>max) max = a2;
//if (b2>max) max = b2;
//if (c2>max) max = c2;
//if (a3>max) max = a3;
//if (b3>max) max = b3;
//if (c3>max) max = c3;

//Console.WriteLine(max);

//Решение с использованием функции


//int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//    if (arg2>result) result = arg2;
//   if (arg3>result) result = arg3;
//    return result;
//}
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 2345;
//int c2 = 133;
//int a3 = 10;
//int b3 = 8;
//int c3 = 62;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max (max1, max2, max3);

//int max = Max (Max(a1, b1, c1),Max(a2, b2, c2), Max(a3, b3, c3) );

//Console.WriteLine(max);

//Решение с использование массива
//int[]array ={1,2,3,4,5,6,17};
//array[0] = 12;
//Console.WriteLine(array[0]);

//Задача: Имеется массив array из n элементов, найти элемент массива равный find
int [] array = {1,2,3,4,5,62,7,8,9,6,256};
int n = array.Length;
int find = 6;
int index = 0;
while (index<n)
{
    if (array[index]== find)
    {
        Console.Write (index);
        break;
    }
    index++;
}

