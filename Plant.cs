// Plant.cs
public abstract class Plant
{
    // Властивості базового класу Рослина
    public string Name { get; set; }
    public string About { get; set; }

    public Plant(string name, string about)
    {
        Name = name;
        About = about;
    }
}