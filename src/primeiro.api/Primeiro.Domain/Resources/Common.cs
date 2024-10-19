using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Domain.Resources
{
    public static class Common
    {
        public static readonly string IntIsRequired = "Please ensure you have entered the Integer Value";
        public static readonly int IntMinValue = 0;
        public static readonly int IntMaxValue = int.MaxValue;
        public static readonly string IntLengthMessage = $@"The Int must have between {IntMinValue} and {IntMaxValue} characters";

        public static readonly string IdIsRequired = "Please ensure you have entered the Id";
        public static readonly int IdMinLength = 36;
        public static readonly int IdMaxLength = 36;
        public static readonly string IdLengthMessage = $@"The Id must have between {IdMinLength} and {IdMaxLength} characters";


        public static readonly string NameIsRequired = "Please ensure you have entered the Name";
        public static readonly int NameMinLength = 4;
        public static readonly int NameMaxLength = 100;
        public static readonly string NameLengthMessage = $@"The Name must have between {NameMinLength} and {NameMaxLength} characters";

        public static readonly string InsertedByIsRequired = "Please ensure you have entered the InsertedBy";

        public static readonly string UpdatedByIsRequired = "Please ensure you have entered the UpdatedBy";

        public static readonly string StatusIsRequired = "Please ensure you have entered the Status";
    }
}
