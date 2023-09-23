Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "сережа") // ToLower помогает распознать имя с заглавной или с маленькой
{
    Console.WriteLine("Ура, это СЕРЕЖА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
