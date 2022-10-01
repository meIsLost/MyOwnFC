namespace MyOwnFC
{
    public class FootballPlayer
    {

        public int Id { set; get; }
        public string? Name { set; get; }
        public int Age { set; get; }
        public int ShirtNumber { get; set; }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber= shirtNumber;
        }

   

        public void ValidateName()
        {
            //at least 2 characters
            if (Name?.Length < 2)
            {
                throw new ArgumentException("Player name too short");
            }
        }
        public void ValidateAge()
        {
            //age > 1
            if (Age<= 1)
            {
                throw new ArgumentOutOfRangeException("Player age must be greater than one");
            }
        }
        public void ValidateShirtNumber()
        {
            // number, 1 <= ShirtNumber <= 99
            if (ShirtNumber > 99 || ShirtNumber < 1 )
            {
                throw new ArgumentOutOfRangeException(" Shirt Number should be between 1 and  99");
            }
        }
        public void Validate()
        {
            ValidateName();
            ValidateShirtNumber();
            ValidateAge();

        }
    }
}