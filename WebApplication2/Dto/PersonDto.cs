using System.Reflection;

namespace WebApplication2.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
