using Entity.Crud;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Users.ToList();
    Console.WriteLine("Kasutajate loend:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.Nimi:{u.Name} Aasta:{u.Age} Sugu:{u.Gender} Linn:{u.Linn}");
    }
}
