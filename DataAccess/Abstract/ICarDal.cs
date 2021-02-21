using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetALL();                 //ürünleri listeledik
        void Add(Car car);                  //ürün ekledik
        void Update(Car car);               //ürün güncelledik
        void Delete(Car car);               //ürün sildik

        List<Car> GetAllByBrandId(int BrandId); //ürünleri BrandId göre filtrele
    }
}
