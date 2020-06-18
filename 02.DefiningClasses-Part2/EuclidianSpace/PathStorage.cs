namespace EuclidianSpace
{
    using System;
    using System.IO;

    using EuclidianSpace.Models;


    public static class PathStorage
   {
      public static void SavePath(Models.Path path, string filePath)
      {
         using (var sw = new StreamWriter(filePath, true))
         {
            foreach (var point in path)
            {
               sw.WriteLine(point);
            }
         }
      }

      public static Models.Path LoadPath(string filePath)
      {
         var path = new Models.Path();
         var sr = new StreamReader(filePath);
         using (sr)
         {
            string line;
            while((line = sr.ReadLine()) != null)
            {
               Points3D point = Points3D.Parse(line);
               path.AddPoint(point);
            }
         }

         return path;
      }
   }
}
