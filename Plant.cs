// Plant.cs
public abstract class Plant : IName, IAbout
{
    public string Name { get; set; }
    public string About { get; set; }

    public Plant(string name, string about)
    {
        Name = name;
        About = about;
    }
}