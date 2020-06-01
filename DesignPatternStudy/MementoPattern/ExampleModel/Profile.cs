using System;

namespace MementoPattern.ExampleModel
{
    public class Profile
    {
        public Profile(string name, string email, DateTime? birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2} years old", this.Name, this.Email, (!this.BirthDate.HasValue ? 0 : ((DateTime.Now - this.BirthDate.Value).Days / 365)));
        }
    }
}
