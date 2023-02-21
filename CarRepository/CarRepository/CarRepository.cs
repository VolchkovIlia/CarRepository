using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepositoryMDK
{
    public class CarRepository
    {
        private List<Car> cars = new List<Car>();

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        public void Insert(Car car)
        {
            cars.Add(car);
        }

        public void Delete(int id)
        {
            Car car = GetById(id);
            if (car != null)
            {
                cars.Remove(car);
            }
        }

        public void Update(int id, Car car)
        {
            Car existingCar = GetById(id);
            if (existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Color = car.Color;
            }
        }

        public List<Car> Find(Predicate<Car> predicate)
        {
            return cars.FindAll(predicate);
        }
    }
}
