Console.Write("Введите ваше пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура, это же МАША! ");
}
else
{
Console.Write("Привет, ");
Console.Write(username);
}
