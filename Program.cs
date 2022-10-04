//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.



string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
        newArray[i] = Console.ReadLine();

    return newArray;
}

string[] ShowArray(string[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            n++;
        }

    }
    string[] newArray = new string[n];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }

    }
    return newArray;
}

Console.WriteLine("Enter count of array");
int n = Convert.ToInt32(Console.ReadLine());
string[] Myarray = CreateArray(n);
string[] narray = ShowArray(Myarray);

for (int i = 0; i < narray.Length; i++)

{
    Console.Write($", {narray[i]}");
}


