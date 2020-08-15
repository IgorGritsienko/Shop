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
        private readonly ICarsCategory _categoryCars = new MockCategory();
        

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
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
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
                        Category =  _categoryCars.AllCategories.Last()
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
                        Category =  _categoryCars.AllCategories.Last()
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
                        Category =  _categoryCars.AllCategories.Last()
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
                        Category =  _categoryCars.AllCategories.First()
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