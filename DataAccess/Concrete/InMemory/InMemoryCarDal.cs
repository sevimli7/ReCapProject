using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2017, DailyPrice = 409000, Description = "MERCEDES C 200" },
                new Car{Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2016, DailyPrice = 129500, Description = "FIAT EGEA" },
                new Car{Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2016, DailyPrice = 145500, Description = "RENAULT FLUENCE" },
                new Car{Id = 4, BrandId = 4, ColorId = 2, ModelYear = 2013, DailyPrice = 161500, Description = "VOLKSWAGEN GOLF" },
                new Car{Id = 5, BrandId = 5, ColorId = 2, ModelYear = 2015, DailyPrice = 473500, Description = "VOLVO XC 60" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetALL()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür. 
            return _cars.Where(c => c.BrandId == c.BrandId).ToList();
        }


        public void Update(Car car)
        {//gönderdiğim ürün ıd sine sahip listedeki ürünü bul demek. 
            Car carToUpdate = _cars.First(c => car.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
