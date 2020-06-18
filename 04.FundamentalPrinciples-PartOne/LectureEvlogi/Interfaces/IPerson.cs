namespace LectureEvlogi.Interfaces
{
    using System;

    public interface IPerson
    {
        //Proparty
        string EMail { get; }
        string Name { get; }
        Gender Gender { get; }




        //Method
        void Walk();
    }
}
