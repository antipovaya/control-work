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

    return newArray;
}


void PrintArray (string [] arrayToShow){

     Console.WriteLine ("Ваш массив: ");

    for (int i = 0; i < arrayToShow.Length; i++)
    {
        if (i == arrayToShow.Length - 1){
            Console.Write(arrayToShow[i] + ".");
        }
        else
        Console.Write(arrayToShow[i] + ", ");
    }
   
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

string [] Array = CreatArray();
PrintArray(Array);
// EvenNumber(Array);

