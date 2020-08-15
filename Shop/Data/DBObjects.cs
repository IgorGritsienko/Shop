using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)    // вызывается каждый раз при старте программы добавляет объекты в бд (из startup.cs)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий автомобиль",
                        longDesc = "Автомобиль, подходящий для повседневной жизнедеятельности",
                        img = "/img/Ford.jpg",
                        price = 10000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Стильный",
                        longDesc = "Дорогой и престижный автомобиль",
                        img = "/img/bmw.jpg",
                        price = 62000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes S class",
                        shortDesc = "Солидный",
                        longDesc = "Дорогой и солидный вариант для тех, кто хочет максимальный комфорт во время поездок",
                        img = "/img/mercedes.jpg",
                        price = 65000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Тихий и экономный",
                        longDesc = "Подходит для низкого трафика на дорогах и средних расстояний",
                        img = "/img/nissan.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                        new Category { categoryName = "Электромобили", description = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", description = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
