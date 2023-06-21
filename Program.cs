//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 


string FindElements(string [] array) 
{
    string result = ""; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result += array[i] + " ";
    }
    return result;
}

string [] ChangeStringToArray(string newstring)
{
    return newstring.Split(' ', StringSplitOptions.RemoveEmptyEntries);  
}

void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

string [] FirstArray = {"hello", "22", "great", "hey"};
string elements = FindElements(FirstArray);
string [] resultArray = ChangeStringToArray(elements);
System.Console.Write($"Elements of array with length <= 3: ");
PrintArray(resultArray);








