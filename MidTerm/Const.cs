using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Const
    {
        public static string? Authorize;
        public static int CarId;
        public static List<Feature>? Features;
        public static int DestinationId;

        public static string ToTitleCase(string str)
        {
            var firstword = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.Split(' ')[0].ToLower());
            str = str.Replace(str.Split(' ')[0], firstword);
            return str;
        }
    }
}
