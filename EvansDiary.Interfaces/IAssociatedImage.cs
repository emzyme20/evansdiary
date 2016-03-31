namespace EvansDiary.Interfaces
{
    public interface IAssociatedImage
    {
        string Height { get; set; }

        string Width { get; set; }

        string Caption { get; set; }

        string Source { get; set; }
    }
}