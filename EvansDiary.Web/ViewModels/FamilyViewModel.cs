using System.Collections.Generic;
using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class FamilyViewModel
    {
        public IEnumerable<IAssociatedImage> Images { get; set; }
    }
}