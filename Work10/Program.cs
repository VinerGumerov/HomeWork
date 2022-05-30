//Задача 1: 
//Задайте массив строк. Напишите программу.
//Cчитает кол-во слов в массиве, начинающихся на гласную букву.

string[] name =  { "qwe", "wer", "ert", "rty", "tyu"};
int CountVowel(string[] words)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i][0] == vowels) count++;
    }
    return count;
}
Console.WriteLine(CountVowel(name));



