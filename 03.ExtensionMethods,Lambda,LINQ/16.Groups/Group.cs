namespace _16.Groups
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Group
   {
      public Group(int groupNumber, string departmentName)
      {
         this.GroupNumber = groupNumber;
         this.DepartmentName = departmentName;
      }
      public int GroupNumber { get; set; }

      public string DepartmentName { get; set; }

      public override string ToString()
      {
         return string.Format("Group Number: {0}, Department Number {1}", this.GroupNumber, this.DepartmentName);
      }
   }
}
