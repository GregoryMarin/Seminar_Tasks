
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Random(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = new Random().Next(0, 2);
	}
}

void PrintArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
}

int[] array = new int[8];
Random(array);
PrintArray(array);

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     // Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// int[] arr = CreateArray(8);
// PrintArray(arr);




// int[] CreateArray(int size)
//             {
//                 int[] array = new int[size];
//                 Random rnd = new Random();
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     array[i] = rnd.Next(0, 2);
//                 }
//                 return array;
//             }

//             void PrintArray(int[] arr)
//             {
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     Console.Write($"{arr[i]} ");
//                 }
//             }
//             int[] arr1 = CreateArray(8);
//             PrintArray(arr1);