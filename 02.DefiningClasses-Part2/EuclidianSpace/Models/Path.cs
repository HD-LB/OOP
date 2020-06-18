namespace EuclidianSpace.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;


    public class Path : IEnumerable<Points3D>
    {
        //Fields
        private ICollection<Points3D> points;

        //Constructors
        public Path()
        {
            this.points = new HashSet<Points3D>();
        }


        //Mathods
        public void AddPoint(Points3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Points3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Points3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
