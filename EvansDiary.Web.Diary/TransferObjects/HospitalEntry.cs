using EvansDiary.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class HospitalEntry : IHospitalEntry
    {
        public int Day { get; set; }

        public string Entry { get; set; }

        public string Title { get; set; }
    }
}
