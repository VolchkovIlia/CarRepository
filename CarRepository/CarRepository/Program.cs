using CarRepositoryMDK;


CarRepository repository = new CarRepository();

// Добавление автомобилей
repository.Insert(new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2018, Color = "Silver" });
repository.Insert(new Car { Id = 2, Make = "Honda", Model = "Accord", Year = 2017, Color = "White" });
repository.Insert(new Car { Id = 3, Make = "Nissan", Model = "Altima", Year = 2016, Color = "Black" });

// Получение всех автомобилей
List<Car> allCars = repository.GetAll();
Console.WriteLine("Все машины:");
foreach (Car car in allCars)
{
  Console.WriteLine($"Id: {car.Id}, Make: {car.Make}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}");
}

// Получение автомобиля по ID
Car carById = repository.GetById(2);
Console.WriteLine("Автомобиль под  Id 2:");
Console.WriteLine($"Make: {carById.Make}, Model: {carById.Model}, Year: {carById.Year}, Color: {carById.Color}");

// Обновление автомобиля
Car updatedCar = new Car { Make = "Honda", Model = "Civic", Year = 2019, Color = "Red" };
repository.Update(2, updatedCar);
Car carAfterUpdate = repository.GetById(2);
Console.WriteLine("Обновить автомобиль по Id 2:");
Console.WriteLine($"Make: {carAfterUpdate.Make}, Model: {carAfterUpdate.Model}, Year: {carAfterUpdate.Year}, Color: {carAfterUpdate.Color}");

// Удаление автомобиля
Console.WriteLine("Удвляем автомобиль под Id 1.....");
repository.Delete(1);
Console.WriteLine("Спсиок авто после удаления Id 1:");
foreach (Car car in allCars)
{
  Console.WriteLine($"Id: {car.Id}, Make: {car.Make}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}");
}
