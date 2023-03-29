// See https://aka.ms/new-console-template for more information
using ISPFinal;

Console.WriteLine("ISPFinal!");
Console.WriteLine();

MultiFuntionalCar multiFuntionalCar = new MultiFuntionalCar();

multiFuntionalCar.Fly();
Console.WriteLine();

multiFuntionalCar.Drive();
Console.WriteLine();

Car car = new Car();
car.Drive();
Console.WriteLine();

Airplane airplane = new Airplane();
airplane.Fly();
Console.WriteLine();

MultiFunctionalCarRev2 multiRev2 = new MultiFunctionalCarRev2(car, airplane);
//multiRev2._car = car; // this gives error due to private set though the _car is public, it can set only from class constructor

multiRev2.Drive();

Console.WriteLine();