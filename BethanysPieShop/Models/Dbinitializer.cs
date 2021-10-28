using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public static class Dbinitializer
    {
        public static void seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(

                                    new Pie { Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pie!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/applepiethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 2, Name = "BlueBerry Cheese cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/Blueberrycheesecakethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 3, Name = "Cheese cake", Price = 18.95M, ShortDescription = "Plain cheese cake, plain pleasure!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/cheese-cakethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/cherrypiethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 5, Name = "Orange Pie", Price = 10.95M, ShortDescription = "Our famous apple pie!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/applepiethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 6, Name = "RedBerry cake", Price = 8.9M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/Blueberrycheesecakethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 7, Name = "Caramel cake", Price = 13.25M, ShortDescription = "Plain cheese cake, plain pleasure!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/cheese-cakethumb.jpg", IsPieOfTheWeek = false },
                                    new Pie { Id = 8, Name = "Chocolate Pie", Price = 11.5M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o cheescake, sweet roll marzipan", ImageUrl = "", ImageThumbnailUrl = "/images/cherrypiethumb.jpg", IsPieOfTheWeek = false }
                    );
                context.SaveChanges();

            }
        }
    }
}
