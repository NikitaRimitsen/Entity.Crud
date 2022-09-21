using Entity.Crud;

using (ApplicationContext db = new ApplicationContext("Data Source=helloapp.db"))
{
    var users = db.Users.ToList();
    Console.WriteLine("Пользователи:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id}.Nimi:{user.Name} Aasta:{user.Age} Sugu:{user.Gender} Linn:{user.Linn}");
    }
}