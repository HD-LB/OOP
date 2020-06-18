namespace SoftwareAcademy.Interfaces
{
    using System;

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }
}
