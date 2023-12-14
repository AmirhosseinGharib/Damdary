List<Animal> animals = new List<Animal>()
{
    new Cow () { IsMale = true , Weight=250 , BirthDate=new DateTime(2022,10,05)},
   new Sheep() { IsMale = false, Weight=100,  BirthDate = new DateTime(2021, 06, 07) },
   new Sheep() { IsMale = false, Weight=80,   BirthDate = new DateTime(2021, 06, 07) }
};


foreach (Animal animal in animals)
{
    Console.WriteLine(animal.Life());
}

public class HealthParameter
{

}

