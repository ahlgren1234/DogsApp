using DogsApp.Mvc.Models;

namespace DogsApp.Mvc.Services;

public class DogServices
{
    List<Dog> dogs = [
        new Dog { Id = 1, Name = "Rufus", Age = 5 },
        new Dog { Id = 2, Name = "Rex", Age = 10 },
        new Dog { Id = 3, Name = "Fido", Age = 8 }
        ];

    public void AddDog( Dog dog ) => dogs.Add( dog );

    public Dog[] GetAllDogs() => dogs.ToArray();

    public Dog? GetDogById( int id ) => dogs.FirstOrDefault(d => d.Id == id);

    public void UpdateDog(Dog updatedDog) {
        var index = dogs.FindIndex(d => d.Id == updatedDog.Id);
        if (index > -1)
        {
            dogs[index] = updatedDog;
        }
    }

    public void DeleteDog(int id) {
        var dog = GetDogById(id);
       dogs.Remove(dog!);
    }
}
