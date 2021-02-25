using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.Concrete;
using DataAccess.Abstract.IEframework;
using DataAccess.Concrete.Eframework;
using System;

namespace ConsoleIU
{
   public class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarServiceManager(new CarDal());

            foreach (var car in carService.GetAll().Data)
            {
                Console.WriteLine("CarId= "+car.Id);
                Console.WriteLine("Brand ıd= " + car.BrandId);
                Console.WriteLine("CarDaily price= "+ car.DailyPrice);
                Console.WriteLine("Car description= " + car.Description);
                Console.WriteLine("Car category ıd= " + car.CategoryId);
                Console.WriteLine("CarId color ıd= " + car.ColorId);
                Console.WriteLine("Car model year= " + car.ModelYear);
            }



        }
    }
}
