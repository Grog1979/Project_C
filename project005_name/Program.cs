Console.Write("ВВЕДИТЕ ИМЯ ПОЛЬЗОВАТЕЛЯ: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hello Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
