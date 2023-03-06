namespace Graduate_Project_1.Models
{
    public class ProfileViewModel
    {
        public String Name { get; }
        public String Surname { get; }
        public String DOB { get; }
        public int Age { get; }
        public String Country { get; }
        public String City { get; }

        public ProfileViewModel()
        {
            this.Name = "Yasteel";
            this.Surname = "Gungapursat";
            this.DOB = new DateTime(1998,8,4).ToString();
            this.Age = 24;
            this.Country = "South Africa";
            this.City = "Durban";
        }
    }
}
