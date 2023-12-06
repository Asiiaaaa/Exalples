Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.WriteLine("Ура, это же Masha");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}