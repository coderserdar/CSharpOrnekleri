using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    public static class ExtensionMethod
    {
        public static string ClearString(this string param)
        {
            //Metin içerisinde yer alan her kelimein ilk harfini büyük yapıp, türkçe karakterlerden arındırma işlemi yapan bir extension method yazalım.
            param = param.ToLower()
                .Replace("ş", "s")
                .Replace("ü", "u")
                .Replace("ç", "c")
                .Replace("ö", "o")
                .Replace("ı", "i")
                .Replace("â", "a")
                .Replace("ğ", "g");

            //ToTitleCase metin içeriisnde yer alan her kelimenin ilk harfini/karakterini büyük hale çevirir.

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(param);
        }
    }
}
