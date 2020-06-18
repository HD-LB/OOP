namespace _01.SchoolClasses.Models
{
  
   using System;
   using System.Collections.Generic;
   using System.Text;
   using Interface;

   class Class : IComment
   {
      private string textIdentifier;
      private List<Teacher> teacherSet;


      //Constructor
      public Class(string textIdentifier, params Teacher[] teacherSet)
      {
         this.TextIdentifier = textIdentifier;
         this.teacherSet = new List<Teacher>();
         this.teacherSet.AddRange(teacherSet);
      }

      //Proparties
      public string TextIdentifier
      {
         get { return this.textIdentifier; }
         set { this.textIdentifier = value; }
      }

      public List<Teacher>  TeacherSet
      {
         get
         {
            return new List<Teacher>(this.teacherSet);
         }
      }

      //Methods
      public void AddTeacher(Teacher teacher)
      {
         this.teacherSet.Add(teacher);
      }

      public void RemoveTacher(Teacher teacher)
      {
         this.teacherSet.Remove(teacher);
      }

      
      public List<string> comment;


      public void AddComment(string newComment)
      {
         var comment = new List<string>();
         comment.Add(newComment);
         Console.WriteLine(string.Join("", comment));
      }


      public override string ToString()
      {
         return "Class " + this.TextIdentifier;
      }
   }
}
