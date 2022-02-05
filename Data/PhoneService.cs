using BlazorLibrary.Models;

namespace DummyBlazorServerApp.Data
{
    public class PhoneService
    {
        private static readonly List<string> Models = new()
        {
            "Nokia",
            "Samsung",
            "Qqmee",
            "Sagem",
            "Motorolla",
            "X-Tigi",
            "Siemens"
        };
        private static readonly List<string> Colors = new()
        {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Purple",
            "White",
            "Black",
            "Silver"
        };
        public Task<List<Phone>> GetPhonesAsync()
        {
            return Task.FromResult(Enumerable.Range(1, new Random().Next(500)).Select(index => new Phone
            {
                Id = index,
                Color = Colors[Random.Shared.Next(Models.Count)],
                Model = Models[Random.Shared.Next(Models.Count)],
                OS = (OS)new Random().Next(4)
            }).ToList()); ;
        }
    }
}
