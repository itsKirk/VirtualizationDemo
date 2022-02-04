namespace DummyBlazorServerApp.Data
{
    public class PersonService 
    {
        private static readonly string[] Names = new[]
        {
            "Dulce Leeming", "Fionnula	Gerbi", "Amy Melson", "Toby	Heskins", "Carri Adamczyk", "Barnie	Janssen", "Virgie Gong", "Ritchie Kellett", "Kassi	Attawell", "Arliene	Letch"
        };

        public Task<Person[]> GetPeopleAsync()
        {
            return Task.FromResult(Enumerable.Range(1, new Random().Next(500)).Select(index => new Person
            {
                Id = index,
                Name = Names[Random.Shared.Next(Names.Length)],
                Gender = (Gender)new Random().Next(3),
                Age = new Random().Next(18, 77)
                
            }).ToArray());
        }
    }
}
