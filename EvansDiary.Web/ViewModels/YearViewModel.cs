using System.Collections.Generic;
using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class YearViewModel
    {
        public YearViewModel(int year)
        {
            Year = year;
            Age = year - 2004;
            Description = "Evan's Monthly Diary";

            if (Age == 1)
            {
                Description = "Evan's Weekly Diary";
            }

            switch (Age)
            {
                case 1:
                    Birthday = "first";
                    break;
                case 2:
                    Birthday = "second";
                    break;
                case 3:
                    Birthday = "third";
                    break;
                case 4:
                    Birthday = "fourth";
                    break;

                default:
                    Birthday = "first";
                    break;
            }
        }

        public int Age { get; set; }

        public string Birthday { get; set; }

        public string Description { get; set; }

        public IEnumerable<IAssociatedImage> Images { get; set; }

        public int Year { get; set; }
    }
}