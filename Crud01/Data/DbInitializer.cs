using Crud01.Models;

namespace Crud01.Data
{
    public static class DbInitializer
    {
          public static void Initialize(ContactContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any())
            {
                return;

            }

            var contacts = new Contact[] { new Contact { FirstName = "Dio",LastName="Burando",Email="dio@info.com",Phone="0123456789" } };
            foreach (var c in contacts) { context.Contacts.Add(c); }
            context.SaveChanges();  
        }  
    }
}
