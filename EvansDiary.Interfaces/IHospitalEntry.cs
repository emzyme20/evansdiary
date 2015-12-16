namespace EvansDiary.Interfaces
{
    public interface IHospitalEntry
    {
        int Day { get; set; }

        string Entry { get; set; }

        string Title { get; set; }
    }
}
