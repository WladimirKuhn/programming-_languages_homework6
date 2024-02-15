// Задача 1

char [,] chars ={

    {'h', 'e', 'l', 'l'},
    {'o', ',', 'w', 'o'},
    {'r', 'l', 'd', '!'}
};

string GetStringFromArray (char[,] chars)
{
    string result = string.Empty;
    for(int i = 0; i < chars.GetLength(0); i++)
    {
        for(int j = 0; j < chars.GetLength(1); j++)
        {
            result = result + chars[i,j];
        }
    }
    return result;
}

string receviedString = GetStringFromArray(chars);

Console.WriteLine($"Полученная строчка {receviedString}"); 

// Задача 2

string str = "HeLlO, WoRlD";
Console.WriteLine(str);
str = str.ToLower();
Console.WriteLine(str);

// Задача 3

string customString = "шабаш";


bool CheckForPolyndrome (string str)
{
    for(int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
    {
        if(str[i] != str[j])
        {
            return false;
        }
    }
    return true;
}

if (CheckForPolyndrome(customString) == true)
{
    Console.WriteLine($"Слово {customString} является полиндромом");
}
else 
{
    Console.WriteLine($"Слово {customString} не является полиндромом");
}

