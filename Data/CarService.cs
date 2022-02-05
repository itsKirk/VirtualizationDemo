using BlazorLibrary.Models;

namespace DummyBlazorServerApp.Data
{
    public class CarService
    {
        private static readonly List<string> Models = new()
        {
            "Dulce", "Gerbi", "Melson", "Heskins", "Adamczyk", "Janssen", "Gong", "Kellett", "Attawell", "Arliene"
        };
        private static readonly List<string> Colors = new()
        {
            "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Purple", "White", "Black", "Silver"
        };
        public Task<List<Car>> GetCarsAsync()
        {
            return Task.FromResult(Enumerable.Range(1, new Random().Next(500)).Select(index => new Car
            {
                Id = index,
                Model = Models[Random.Shared.Next(Models.Count)],
                Make = (CarMake)new Random().Next(4),
                Year = new Random().Next(2000, DateTime.Now.Year),
                Color = Colors[Random.Shared.Next(Colors.Count)]
            }).ToList()); ;
        }
    }
}
