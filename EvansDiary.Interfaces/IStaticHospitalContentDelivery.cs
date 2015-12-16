namespace EvansDiary.Interfaces
{
    public interface IStaticHospitalContentDelivery
    {
        IHospitalEntry GetEntry(int key);

        void InitialiseStaticContent();
    }
}