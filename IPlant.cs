// IPlant.cs
public interface IPlant
{
    // Властивість Name
    string Name { get; set; }

    // Властивість About
    string About { get; set; }

    // Метод для отримання ціни
    double Get_Price();

    // Метод для підрахунку кількості
    int Count();
}