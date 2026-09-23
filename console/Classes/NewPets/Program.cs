using NewPets;
using Pets;

List<IPets> pets = new List<IPets>()
{
 new Dog(),
new Cat()
};

foreach (IPets pet in pets)
{
 Console.WriteLine(pet.TalkDisplay());
}