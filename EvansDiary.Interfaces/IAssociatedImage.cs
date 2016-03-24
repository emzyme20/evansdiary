namespace EvansDiary.Interfaces
{
    public interface IAssociatedImage
    {
        string Caption { get; set; }

        string Source { get; set; }

        string GetUrl(double? width, double? height, int? quality, string additionalOptions);
    }
}