using StudentSystemEf.Data;
using StudentSystemEf.Models;

using (var context = new AppDbContext())
{
    DbInitializer.Seed(context);
}