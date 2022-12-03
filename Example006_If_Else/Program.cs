Console.WriteLine("Введите ваше имя, пожалуйста");
string username = Console.ReadLine ();
if(username.ToLower() == "маша")
{
    Console.Write("Ура, это же Маша!");
}
else
{
   Console.Write("Привет, ");
   Console.Write(username);
}

