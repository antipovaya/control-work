// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string [] CreatArray (){

    int size = new Random().Next(3, 8);
    string [] newArray = new string [size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите строку");
        string username = Console.ReadLine()!;
        newArray [i] = username;
    }
  
    Console.WriteLine();
    return newArray;

}


void PrintArray (string [] arrayToShow){

    Console.Write("[");
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        if (i == arrayToShow.Length - 1){
            Console.Write(arrayToShow[i] + "]");
        }
        else
        Console.Write(arrayToShow[i] + ", ");
    }
    
}

int CheckArray(string [] firstArray)
{
    int count = 0;
    string element = String.Empty;

    for (int i = 0; i < firstArray.Length; i++)
    {
        element = firstArray[i];
        if (element.Length <= 3)
        {
            count++;
        } 
    }
    return count;
}


string [] SecondCreatArray (string [] firstArray, int count)
{
    string [] secondArray = new string [count];
    int i = 0;
   
        for (int j = 0; j < firstArray.Length; j++)
            {
                if (firstArray[j].Length <= 3)
                {
                    secondArray[i] = firstArray[j];
                    i++;
                }
            }

    return secondArray;

}

// void EvenNumber (int [] arrayCreat){

//     int count = 0;
//     for (int i = 0; i < arrayCreat.Length; i++){
//         if (arrayCreat[i] % 2 == 0){
//             count++;
//         }
//     }

//     Console.Write($"-> {count}");
// }


string [] array = CreatArray();

Console.WriteLine ("Ваш массив: ");
PrintArray(array);
int sum = CheckArray(array);
Console.WriteLine ();
Console.WriteLine($"Количество элементов в массиве длиной <  или = 3: {sum}");
string [] newArray = SecondCreatArray(array, sum);
Console.WriteLine ("Ваш массив c элементами длиной <  или = 3: ");

PrintArray(newArray);
if (sum ==0) Console.Write("]");
