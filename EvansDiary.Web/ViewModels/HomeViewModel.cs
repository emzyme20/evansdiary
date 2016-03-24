using System.Collections.Generic;

namespace EvansDiary.Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<FlipbookItemViewModel> FlipbookItems { get; set; }
    }
}