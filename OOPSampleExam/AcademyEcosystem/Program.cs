//https://my.telerikacademy.com/Courses/LectureResources/Video/6136/Видео-Academy-Ecosystem-4-април-2015-Евлоги

//https://my.telerikacademy.com/Courses/Courses/Details/225

//https://www.youtube.com/watch?time_continue=31&v=8Dl1tGCyHDw





namespace AcademyEcosystem  
{
    using System;


    class Program
    {
        static Engine GetEngineInstance()
        {
            return new ExtendedEngine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}
