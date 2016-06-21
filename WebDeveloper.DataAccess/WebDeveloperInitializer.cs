using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="Jose", LastName="Perez", DateCreation=DateTime.Now },
                new Client {Name="Juan", LastName="Perez" ,DateCreation=DateTime.Now},
                new Client {Name="Juanelo", LastName="Perez",DateCreation=DateTime.Now },
                new Client {Name="Alan", LastName="Perez",DateCreation=DateTime.Now },
                new Client {Name="Pedro", LastName="Perez",DateCreation=DateTime.Now },
            };

            var products = new List<Product>
            {
                new Product {NameProduct="Usb", Description="Marca Kingston 4GB", Price=40,Stock=15 },
                new Product {NameProduct="Mouse", Description="Marca Cybertel", Price=20,Stock=10 },
                new Product {NameProduct="Cooler", Description="Marca iDock", Price=60,Stock=25 },
                new Product {NameProduct="Laptop", Description="Marca Toshiba i5", Price=2800,Stock=5 },
                new Product {NameProduct="Impresora", Description="Marca Expon Stylus TX115", Price=200,Stock=4 }
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
