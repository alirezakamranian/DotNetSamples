
using DateTimeOffset.DataAccess;
using Microsoft.EntityFrameworkCore;

var contextOptions = new DbContextOptionsBuilder<DataContext>()
    .UseNpgsql("Host=nanaga-parbat.liara.cloud:32930;Username=root;Password=tt3gk25cYJqdty6kKFAqAOfA;Database=DateTimeOffset;Include Error Detail=true")
    .Options;

//using (var db = new DataContext(contextOptions))
//{
//    db.Orders.Add(new()
//    {
//        Title = "sw",
//        Date = System.DateTimeOffset.UtcNow
//    });

//    db.SaveChanges();
//}


Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);
Console.ReadKey();