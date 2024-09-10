using Microsoft.EntityFrameworkCore;
using mvc4.Models;
namespace mvc4.Data;

public class CustomerDbContext:DbContext{
    // string s1="server=Localhost;database=CustomerDb;integrated security=true;trustservercertificate=true;";
    string s1="Server=tcp:my-az-server1.database.windows.net,1433;Initial Catalog=customer;Persist Security Info=False;User ID=satish;Password=630261Ee@2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer(s1);
    }
    public DbSet<Customer> Customers { get; set;}
}