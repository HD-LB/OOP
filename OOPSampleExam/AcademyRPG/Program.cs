//https://my.telerikacademy.com/Courses/Courses/Details/225

//https://my.telerikacademy.com/Courses/LectureResources/Video/6130/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-Academy-RPG-3-%d0%b0%d0%bf%d1%80%d0%b8%d0%bb-2015-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8

//https://www.youtube.com/watch?v=jRNyWnNu8nY


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
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
