using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        #region Instance fields


        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double baseFee = 1000;
        
        List<Dog> Dogs = new List<Dog>();

        #endregion

        public Member()
        {
            List<Dog> Dogs = new List<Dog>();
        }


        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public void RemoveDog(Dog dog)
        {
            Dogs.Remove(dog);
        }
        public void PrintDogs()
        {
            foreach (Dog dog in Dogs) { Console.WriteLine($"{dog}"); }
        }

        public int Age()
        {
            int age = DateTime.Now.Year - Birthdate.Year;

            if (DateTime.Now.Month - Birthdate.Month > 0) { return age + 1; }

            return age;
           
        }

        public double MemberFee(double baseFee)
        {
            Console.WriteLine("Your memberfee is : ");
            if (Age() >= 65) { return Dogs.Count * 500; }
            return baseFee + ((Dogs.Count-1) * 500);
        }

        public bool Validate()
        {
            
            if (Age() < 18 ) { Console.WriteLine("you are too young"); return false; } 
            else if (string.IsNullOrEmpty(Name)) { Console.WriteLine("No name detected. Please enter name"); return false; }
            else if (string.IsNullOrEmpty(Email)) { Console.WriteLine("No Email detected. Please enter an Email"); return false; }
            else if (string.IsNullOrEmpty(PhoneNumber)) { Console.WriteLine("No phonenumber detected. Please enter Phone number"); return false; }
            else if (string.IsNullOrEmpty(Adress)) { Console.WriteLine("No adress detected. Please enter an adress"); return false; }

            return true;
        }

        public bool Validate2()
        {
            if (Age() < 18) { throw new FormatException("Age is too low"); }
            else if (string.IsNullOrEmpty(Name)) { throw new FormatException("No name detected. Please enter name"); }
            else if (string.IsNullOrEmpty(Email)) { throw new FormatException("No Email detected. Please enter Email"); }
            else if (string.IsNullOrEmpty(PhoneNumber)) { throw new FormatException("No Phonenumber detected. Please enter phonenumber"); }
            else if (string.IsNullOrEmpty(Adress)) { throw new FormatException("No Adress detected. Please enter Adress"); }
            return true;
        }
        

        public override string ToString()
        {
            return $"Id: {ID}, Name: {Name}, Adress: {Adress}, Birthdate {Birthdate}, Phone number {PhoneNumber}, E-mail {Email} \n\n";
        }

        
    }
}
