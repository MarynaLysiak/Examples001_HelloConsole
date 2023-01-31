Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это же МАРИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}