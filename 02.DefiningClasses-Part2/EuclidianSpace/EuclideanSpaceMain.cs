//https://my.telerikacademy.com/Courses/LectureResources/Video/6116/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-21-%d0%bc%d0%b0%d1%80%d1%82-2015-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8

//https://www.youtube.com/watch?v=ffeCjzOap2g



namespace EuclidianSpace
{
    using System;
   
    using Models;
    using Extensions;


    public class EuclideanSpaceMain
    {
        static void Main()
        {
            Points3D point = new Points3D() { X = 1, Y = 2, Z = 3 };

            Console.WriteLine(point);

            Console.WriteLine(Points3D.Origin);

            var dist = Point3DExtensions.CalcutateDistance(point, Points3D.Origin);
            Console.WriteLine(dist);

            var path = new Path();
            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Points3D() { X = i, Y = i * 2, Z = i + 3 });
            }


            string pathStr = "../../path.txt";
            PathStorage.SavePath(path, pathStr);
            var pathFromFile = PathStorage.LoadPath(pathStr);

            foreach (var p in pathFromFile)
            {
                Console.WriteLine(p);
            }
        }
    }
}
