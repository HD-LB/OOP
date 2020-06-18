namespace _01.SchoolClasses.Models
{
   
   using System;
   using System.Collections.Generic;
   using Interface;

   public class Discipline : IComment
   {
      //Fields
      private string name;
      private int numOfLectures;
      private int numOfExercises;

      //Constructors
      public Discipline(string name, int numOfLectures, int numOfExercises)
      {
         this.Name = name;
         this.NumOfLectures = numOfLectures;
         this.NumOfExercises = numOfExercises;

      }

      //Proparties
      public string Name
      {
         get { return this.name; }
         set
         {
            if (string.IsNullOrEmpty(value))
            {
               throw new ArgumentException("Discipline cannot be empty.");
            }
            this.name = value;
         }
      }

      public int NumOfLectures
      {
         get { return this.numOfLectures; }
         set
         {
            if (this.numOfLectures < 0)
            {
               throw new ArgumentOutOfRangeException("Number of Lectures cannot be a negative number.");
            }
            this.numOfLectures = value;
         }
      }

      public int NumOfExercises
      {
         get { return this.numOfExercises; }
         set
         {
            if (this.numOfExercises < 0)
            {
               throw new ArgumentOutOfRangeException("Number of Exercises cannot be a negative number.");
            }
            this.numOfExercises = value;
         }
      }

      //Methods
      public List<string> comment;

      public void AddComment(string newComment)
      {
         var comment = new List<string>();
         comment.Add(newComment);
         Console.WriteLine(string.Join("", newComment));
      }

      public override string ToString()
      {
         return this.Name;
      }
   }
}
