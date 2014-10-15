class MainClass
{
    public enum Gender
    {
        Male,
        Female
    };

    class Human
    {
        public Gender Sex { get; set; }
        
        public string PersonName { get; set; }

        public int Age { get; set; }
    }

    public void CreateHuman(int age)
    {
        Human person = new Human();
        person.Age = age;
		
        if (age % 2 == 0)
        {
            person.PersonName = "Pesho Peshev"; // Cool guy
            person.Sex = Gender.Male;
        }
        else
        {
            person.PersonName = "Mariika Ivanova"; // Hot chick
            person.Sex = Gender.Female;
        }
    }
}