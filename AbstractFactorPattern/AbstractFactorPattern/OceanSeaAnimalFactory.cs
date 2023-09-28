// OceanSeaAnimalFactory.cs
public class OceanSeaAnimalFactory : ISeaAnimalFactory
{
    public ISeaAnimal CreateSeaAnimal()
    {
        return new Shark();
    }
}