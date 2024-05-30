using Polymorphism.Models;

//Animal rex = new Dog();
//rex.Sound();

Animal[] animals = [new Cat(), new Dog()/*, new Golden()*/];

foreach (var animal in animals)
    animal.Sound();

