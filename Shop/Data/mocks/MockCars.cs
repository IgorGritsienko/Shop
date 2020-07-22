using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoreCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "https://www.tesla.com/content/dam/tesla-site/sx-redesign/img/socialcard/MS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category =  _categoreCars.AllCategories.First()
                    },
                    new Car               
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий автомобиль",
                        longDesc = "Автомобиль, подходящий для повседневной жизнедеятельности",
                        img = "https://www.winnerauto.ua/uploads/gallery_photo/photo/0170/91.jpg",
                        price = 10000,
                        isFavourite = true,
                        available = true,
                        Category =  _categoreCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Стильный",
                        longDesc = "Дорогой и престижный автомобиль",
                        img = "https://lh3.googleusercontent.com/proxy/w8ZM3ehtiCPOkJJcFu0cZm5yyynUtyjU9V8XF92yar7NPlMkF3i3kdWtozbwnsE4VzHR6DU4qzV56Z_VWmEWeRRppQFCVYfTRb8x",
                        price = 62000,
                        isFavourite = true,
                        available = true,
                        Category =  _categoreCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes S class",
                        shortDesc = "Солидный",
                        longDesc = "Дорогой и солидный вариант для тех, кто хочет максимальный комфорт во время поездок",
                        img = "https://img.drive.ru/i/0/58f4dd89ec05c4eb3400001f.jpg",
                        price = 65000,
                        isFavourite = false,
                        available = false,
                        Category =  _categoreCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Тихий и экономный",
                        longDesc = "Подходит для низкого трафика на дорогах и средних расстояний",
                        img = "https://wieck-nissanao-production.s3.amazonaws.com/photos/fc630cacf71a2b3c8dcba81501f7ead122443bf0/preview-928x522.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category =  _categoreCars.AllCategories.First()
                    }
                };
            }
        }


        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}