using Entity.Crud;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

/*using (ApplicationContext db = new ApplicationContext())
{
    // пересоздадим базу данных
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    // добавляем начальные данные
    Company microsoft = new Company { Name = "Microsoft", Linn="Germany" };
    Company google = new Company { Name = "Google", Linn = "Italia" };
    db.Companies.AddRange(microsoft, google);

    User tom = new User { Name = "Tom", Company = microsoft };
    User bob = new User { Name = "Bob", Company = google };
    User alice = new User { Name = "Alice", Company = microsoft };
    User kate = new User { Name = "Kate", Company = google };
    db.Users.AddRange(tom, bob, alice, kate);

    db.SaveChanges();

    // получаем пользователей
    var users = db.Users
        .Include(u => u.Company)  // подгружаем данные по компаниям
        .ToList();
    foreach (var user in users)
        Console.WriteLine($"Nimi:{user.Name} - Company: {user.Company?.Name} - Company Country:{user.Company?.Linn}");
}*/

// добавление данных

using (ApplicationContext db = new ApplicationContext())
{
    User? user = db.Users.FirstOrDefault();
    // получаем первый объект User
    if (user != null)
    {
        user.Password = "dsfvbggg";
        db.SaveChanges();
    }

    // получаем объект UserProfile для пользователя с логином "login2"
    UserProfile? profile = db.UserProfiles.FirstOrDefault(p => p.User.Login == "login2");
    if (profile != null)
    {
        profile.Name = "Alice II";
        db.SaveChanges();
    }
}
