// Имеется одномерный массив array, требуется найти индекса find
int[] array = { 1, 2, 17, 6, 12, 14, 15, 17 };

int n = array.Length;
int find = 17;

int index = 0;

while (index < n)
{

    if(array[index] == find) // если число под данным индексом совпало (равно) find (заданному числу)
    {
        Console.WriteLine(index);
        break; //вводим данный оператор для поиска первого совпавшего числа, без него в ответе было бы несколько (при наличии одинаковых чисел в дано)
    }
        index++;
}
