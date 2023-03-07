namespace Graduate_Project_1.Models
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String DOB { get; set; }
        public int Age { get; set; }
        public String Country { get; set; }
        public String City { get; set; }

        public ProfileViewModel()
        {
            this.Id = 0;
            this.Name = "Yasteel";
            this.Surname = "Gungapursat";
            this.DOB = new DateTime(1998,8,4).ToString();
            this.Age = 24;
            this.Country = "South Africa";
            this.City = "Durban";
        }
    }
}
