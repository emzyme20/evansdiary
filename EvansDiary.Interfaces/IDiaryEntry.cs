using System.Collections.Generic;

namespace EvansDiary.Interfaces
{
    public interface IDiaryEntry
    {
        List<ITimeLineEntry> Timeline { get; set; }

        string Tag { get; set; }

        string Headline { get; set; }
    }
}