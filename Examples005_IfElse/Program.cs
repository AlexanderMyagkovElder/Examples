Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "александр")
{
    Console.WriteLine("Ура, это Санечек!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}