namespace AcademyRPG.Models
{
    using System;

    public class House : StaticObject
    {
        public House(Point position, int owner)
            : base(position, owner)
        {
            base.HitPoints = 500;
        }
        //public House(Point position, int owner = 0) : base(position, owner)
        //{
        //}
    }
}
