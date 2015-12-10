namespace EvansDiary.Web.Interfaces
{
    public interface IStaticContentDelivery
    {
        IDiaryEntry GetEntry(string key);

        void InitialiseStaticContent();
    }
}
