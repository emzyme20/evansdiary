namespace EvansDiary.Interfaces
{
    public interface IStaticContentDelivery
    {
        IDiaryEntry GetEntry(string key);
    }
}
