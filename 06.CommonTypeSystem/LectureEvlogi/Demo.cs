namespace LectureEvlogi

//https://my.telerikacademy.com/Courses/LectureResources/Video/6085/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-26-%d0%bc%d0%b0%d1%80%d1%82-2015-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8

{
    using System;

    class Demo
    {
        static void Main()
        {
            Dog dog1 = new Dog()
            {
                Name = "Stamat",
                Age = 3,
                Owner = new Person() { Name = "Pesho" }
            };


            //Dog dog2 = new Dog() { Name = "Stamat" };

            //Console.WriteLine(dog1.Equals(dog2));


            //var type1 = dog2.GetType();
            //var type2 = typeof(Dog);

            //Console.WriteLine(type1);
            //Console.WriteLine(type2);

            var dog2 = (Dog)dog1.Clone();
            dog2.Owner.Name = "Toshko";

            Console.WriteLine(dog1.Owner.Name);
            Console.WriteLine(dog2.Owner.Name);


            //IEnumerable
            var enumerator = dog1.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Dispose();

            foreach (var item in dog1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
