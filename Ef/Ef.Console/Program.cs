using System;
using System.Collections.Generic;
using System.Linq;
using Ef.Database;
using Ef.Database.Entities;


namespace Ef.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Repo<Car> repo = new Repo<Car>();
            try
            {
                var newCar = new Car
                {
                    CurrentPerson = new Person
                    {
                        Address = new Address
                        {
                            Building = new Building
                            {
                                Number = 5,
                                Street = new Street
                                {
                                    City = new City
                                    {
                                        Name = "Szczecin"
                                    },
                                    Name = "Wojska Polskiego"
                                }
                            }
                        }
                    },
                    Model = new Model
                    {
                        Brand = new Brand
                        {
                            Name = "Ford"
                        },
                    },
                    Owners = null
                };
                Repository.Add<Car>(newCar);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }


            try
            {
                var city = new City { Name = "Kraków" };

                var street = new Street { Name = "Warszawska", City = city };

                var building = new Building { Number = 1, Street = street };

                var address = new Address { Building = building, FlatNumber = 11 };

                var person = new Person { FirstName = "Kacper", LastName = "Ledwoń", Age = 20, Address = address };

                var brand = new Brand { Name = "Nissan" };

                var model = new Model { Brand = brand, Name = "Note" };

                var car = new Car { CurrentPerson = person, Model = model, Owners = new List<Person>() };
                car.Owners.Append(person);
                Repository.Add<Car>(car);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }

            try
            {
                var city = new City { Name = "Warszawa" };

                var street = new Street { Name = "Krakowska", City = city };

                var building = new Building { Number = 5, Street = street };

                var address = new Address { Building = building, FlatNumber = 52 };

                var person = new Person { FirstName = "Karol", LastName = "Nowak", Age = 25, Address = address };

                var brand = new Brand { Name = "Ford" };

                var model = new Model { Brand = brand, Name = "Mustang" };

                var car = new Car { CurrentPerson = person, Model = model, Owners = new List<Person>() };
                car.CurrentPerson = person;

                var newCity = new City { Name = "Wrocław" };

                var newStreet = new Street { Name = "Poznańska", City = newCity };

                var newBuilding = new Building { Number = 42, Street = newStreet };

                var newAddress = new Address { Building = newBuilding, FlatNumber = 24 };

                var newPerson = new Person { FirstName = "Łukasz", LastName = "Kowalski", Age = 22, Address = newAddress };

                Repository.Add<Person>(newPerson);
                repo.Add(car);
                repo.Save();
                System.Console.WriteLine($"{ car.Id }");

                car.CurrentPerson = newPerson;
                repo.Update(car);
                repo.Save();
                System.Console.WriteLine($"{ car.Id }");

                repo.Delete(car.Id);
                repo.Save();
                System.Console.WriteLine($"{ car.Id }");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }

        }
    }
}
