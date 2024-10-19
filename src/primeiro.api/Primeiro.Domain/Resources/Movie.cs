using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Domain.Resources
{
    public static class Movie
    {
        public static readonly string TitleIsRequired = "Please ensure you have entered the Title";
        public static readonly int TitleMinLength = 4;
        public static readonly int TitleMaxLength = 100;
        public static readonly string TitleLengthMessage = $@"The Title must have between {TitleMinLength} and {TitleMaxLength} characters";

        public static readonly string GenreIsRequired = "Please ensure you have entered the Genre";
        public static readonly int GenreMinLength = 4;
        public static readonly int GenreMaxLength = 100;
        public static readonly string GenreLengthMessage = $@"The Genre must have between {GenreMinLength} and {GenreMaxLength} characters";

        public static readonly string YearIsRequired = "Please ensure you have entered the Year";
        public static readonly int YearMinValue = 1900;
        public static readonly int YearMaxValue = 2100;
        public static readonly string YearLengthMessage = $@"The Year must have between {YearMinValue} and {YearMaxValue} characters";
    }
}
