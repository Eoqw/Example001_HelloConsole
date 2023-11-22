Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.Tolower() == "Марина")
{
    Console.WriteLine("Ура Это же Марина, я тебя люблю");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}