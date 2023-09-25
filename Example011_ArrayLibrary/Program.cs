void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если элемента нет, счеткик будет показывать *-1* то есть Такой элемент НЕ НАЙДЕН !
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4; // Принудительная 4 с индексом [4], чтобы показать только первое вхождение.
array[6] = 4; // Принудительная 4 с индексом [6], чтобы показать только первое вхождение.

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); 
Console.WriteLine(pos);