// AfricanLandAnimalFactory.cs
public class AfricanLandAnimalFactory : ILandAnimalFactory
{
    public ILandAnimal CreateLandAnimal()
    {
        return new Lion();
    }
}