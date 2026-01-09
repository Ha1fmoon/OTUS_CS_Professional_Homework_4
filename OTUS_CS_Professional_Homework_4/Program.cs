using OTUS_CS_Professional_Homework_4.Class;

Console.WriteLine("Create original objects:");
var tiger = new Tiger("Tiger", 5, 8.5, 1);
var cat = new Cat("Cat", 3, 2.5, "Turkish angora");
var wolf = new Wolf("Wolf", 7, 2, 10);
var dog = new Dog("Dog", 4, 10, "Hound");

Console.WriteLine(tiger);
Console.WriteLine(cat);
Console.WriteLine(wolf);
Console.WriteLine(dog);

Console.WriteLine();

Console.WriteLine("Using IMyCloneable<Animal>");
var tigerCustomClone = tiger.Clone();
var catCustomClone = cat.Clone();
var wolfCustomClone = wolf.Clone();
var dogCustomClone = dog.Clone();

Console.WriteLine(tigerCustomClone);
Console.WriteLine(catCustomClone);
Console.WriteLine(wolfCustomClone);
Console.WriteLine(dogCustomClone);

Console.WriteLine();

Console.WriteLine("Using ICloneable");
ICloneable clonableTiger = tiger;
ICloneable catCloneable = cat;

var clonedTigerObject = clonableTiger.Clone();
var clonedTiger = (Animal)clonedTigerObject;

var clonedCatObject = catCloneable.Clone();
var clonedCat = (Animal)clonedCatObject;

Console.WriteLine(clonedTiger);
Console.WriteLine(clonedCat);

Console.WriteLine();

Console.WriteLine("Change original objects:");

Console.WriteLine();

tiger.Name = "Changed Tiger";
tiger.Age = 6;
cat.Breed = "British Shorthair";

Console.WriteLine("Original objects:");
Console.WriteLine(tiger);
Console.WriteLine(cat);

Console.WriteLine();

Console.WriteLine("Cloned objects:");
Console.WriteLine("IMyCloneable:");
Console.WriteLine(tigerCustomClone);
Console.WriteLine(catCustomClone);
Console.WriteLine("ICloneable:");
Console.WriteLine(clonedTiger);
Console.WriteLine(clonedCat);

Console.WriteLine();

Console.WriteLine("Check is objects equal by reference:");
Console.WriteLine($"Original tiger and IMyCloneable: {ReferenceEquals(tiger, tigerCustomClone)}");
Console.WriteLine($"Original tiger and ICloneable: {ReferenceEquals(tiger, clonedTiger)}");
Console.WriteLine($"IMyCloneable and ICloneable: {ReferenceEquals(tigerCustomClone, clonedTiger)}");