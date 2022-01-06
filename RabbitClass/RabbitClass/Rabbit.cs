using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitClass
{
        enum Eyes
        {
            Blue,
            Red,
            Black
        }
        enum Fur
        {
            White,
            Brown,
            Black,
            Grey
        }
        enum Gender
        {
            Female,
            Male
        }
    class Rabbit : Mammal
    {

        private Eyes eyes;
        private Fur furr;
        private Gender gender;

        public DateTime BirthDate 
        { 
            get; 
        }

        public int Age 
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }  
        }
        public Rabbit(Eyes eyes, Fur furr, Gender gender, DateTime birthDate, string food) : base(food)
        {
            this.eyes = eyes;
            this.furr = furr;
            this.gender = gender;
            BirthDate = birthDate;
        }

        public override void Moves()
        {
            Console.WriteLine("I am a rabbit and I move fast");
        }

        public override void Sleeps()
        {
            Console.WriteLine("I am a rabbit and I sleep with one eye open");
        }

        public override void Eats()
        {
            Console.WriteLine("I am a rabbit and I eat carrots");
        }
    }
}


//Model the Rabbit class knowing that:

//a rabbit can have Blue, Red or Black eyes
//a rabbit's fur can be white, brown, black or grey
//it has a gender
//has a birth date, and based on that you should be able to see how
//old the rabbit is
//we also know that a rabbit is a mammal that moves, sleeps and eats certain foods