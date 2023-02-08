// Тип 1. Методы, которые не принимают аргументы и не возвращают. Начинаются с Void

void Method1()
{
    Console.WriteLine("Автор - Марина");
}
// Method1();

// Тип 2 Метод принимает аргументы, но не возвращает
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Какой-то текст");

//Тип 3. Метод не принимает аргументы, но возвращает

 int Method3()
 {
    return DateTime.Now.Year;
 }
 int Year = Method3();
//  System.Console.WriteLine(Year);

// Тип 4. Принимает аргументы и возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "abc");
System.Console.WriteLine(res);