﻿namespace MVC_LAB.Models.Person
{
    public class PersonModel
    {
        public PersonModel()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public string City { get; set; }

        public List<PersonModel> GetPersons()
        {
            return new List<PersonModel>()
        {
            new PersonModel()
            {
                Name = "Andrezej",
                City = "Rzeszow",
                Gender = GenderEnum.Male,
                ID = 1,
            },
            new PersonModel()
            {
                Name = "Katarzyna",
                City = "Rzeszow",
                Gender = GenderEnum.Famale,
                ID = 2,
            },
            new PersonModel()
            {

                Name = "Julia",
                City = "Krakow",
                Gender = GenderEnum.Famale,
                ID = 3,

            },
            new PersonModel()
            {

                Name = "Piotr",
                City = "Warszawa",
                Gender = GenderEnum.Male,
                ID = 2,
            },
          };


        }
   
    }
}
