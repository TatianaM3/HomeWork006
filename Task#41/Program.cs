// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Введите количество проверяемых чисел: ");
int m = int.Parse(Console.ReadLine());

int[] arr = new int[m];
int count = 0;
int num = 1;

for (int i = 0; i < m; ++i){
    Console.WriteLine("Введите число: ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0){
        count++;
    }
    num++;
}

Console.WriteLine($"Кол-во элементов больше нуля: {count}");