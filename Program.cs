namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Name = "Baby";
            dog1.ID = 1;
            dog1.Race = "Pitbull";
            dog1.YearOfBirth = 2017;
            Console.WriteLine($"{dog1}");

            Dog dog2 = new Dog();
            dog2.Name = "Bam";
            dog2.ID = 2;
            dog2.Race = "Pitbull";
            dog2.YearOfBirth = 2017;
            Console.WriteLine($"{dog2}");

            Dog dog3 = new Dog();
            dog3.Name = "Plet";
            dog3.ID = 3;
            dog3.Race = "Pitbull";
            dog3.YearOfBirth = 2017;
            Console.WriteLine($"{dog3}");


            Member member1 = new Member();
            member1.Name = "Bob";
            member1.ID = 1;
            member1.Adress = "vejvej 1";
            member1.Email = "email@email.email";
            member1.PhoneNumber = "1234567890";
            member1.Birthdate = new DateTime(1975, 2, 7);
            Console.WriteLine($"{member1}");
            //Test af Age Opgave 6
            Console.WriteLine("Alder:");
            Console.WriteLine(member1.Age());
         

            //Test af opgave 4 (CRUD)


            member1.RegisterDog(dog1);
            member1.RegisterDog(dog2);
            member1.RemoveDog(dog1);
            member1.RegisterDog(dog3);
            member1.PrintDogs();

            //Test af opgave 6 Memberfee

            Console.WriteLine(member1.MemberFee(member1.baseFee));

            //test af opgave 7 (uden adresse)


            Member member2 = new Member();
            member2.Name = "Bob";
            member2.ID = 5;
           
            member2.Email = "email@email.email";
            member2.PhoneNumber = "1234567890";
            member2.Birthdate = new DateTime(1975, 2, 7);

            member2.Validate();

            //test af opgave 8

            Member member3 = new Member();
            member3.Name = "Bob";
            member3.ID = 7;

            member3.Email = "email@email.email";
            member3.PhoneNumber = "1234567890";
            member3.Birthdate = new DateTime(1975, 2, 7);

            try
            {
                member3.Validate2();
            }
            catch (FormatException e){ Console.WriteLine(e.Message); }


        }
    }
}
