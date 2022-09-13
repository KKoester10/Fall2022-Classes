using Fall2022_Classes;
// creating a car with our default constructor
Car ashleysCar = new Car();

Console.WriteLine(ashleysCar.Make);

ashleysCar.IsPaidFor = true;
Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

var gavCarMake = "Toyota";
//creating another car with a different constructor
Car gavinsCar = new Car(gavCarMake, "Camry", "Grey", 2007, 0, false);

Console.WriteLine("Gavin has a " + gavinsCar.Make);


// making a list of objects from out new class
var garage = new List<Car>();
// adding our cars to the List
garage.Add(ashleysCar);
garage.Add(gavinsCar);
//showing we can access those cars and their properties from our List
Console.WriteLine(garage[0].Model);

//see the effects fo the accelerate method
Console.WriteLine(ashleysCar.Speed);
ashleysCar.Accelerate();
Console.WriteLine(ashleysCar.Speed);
//use of our overloaded Accerate method
gavinsCar.Accelerate(7); // up to 17 from 10
Console.WriteLine(gavinsCar.Speed);

var timeToDrive = gavinsCar.TimeToTravelDistance(500);
// gavinsCar.TimeToTravelDistance(500); // this is a incomplete sentance ; its just a variable 
Console.WriteLine(timeToDrive);// this is a complete sentance becuase we gave the variable a place to go

// how to access the static method from the car class Car.cs
// note this only works by calling the class,not an instance of the class (aka object)
// Console.WriteLine(); is a static method
Car.Honk();



