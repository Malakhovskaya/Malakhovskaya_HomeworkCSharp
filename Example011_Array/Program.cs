void FillArray(int[] collection) //вводим оператор невозвратного метода void массива из целых чисел 
{
    int length = collection.Length; //длина массива
    int index = 0; //индексу присваивается значение 0(ноль)
    while (index < length) //пока индекс меньше длины массива
    {
        collection[index] = new Random().Next(1, 10); // обращаемся к аргументу на позиции [индекс] , присваиваем рандомные значения от 1 до 9
        index++;
    }
}
void PrintArray(int[] col) //вводим оператор void печать массива col
{
    int count = col.Length; //количество элементов
    int progress = 0; // текущая позиция
    while (progress < count) //пока текущая позиция меньше длины массива
    {
        Console.WriteLine(col[progress]);
        progress++;
    }
}
int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов, по умолчанию это "нули"

FillArray(array); //метод FillArray заполняет наш массив числами
PrintArray(array);//метод PrintArray печатает наш массив 

