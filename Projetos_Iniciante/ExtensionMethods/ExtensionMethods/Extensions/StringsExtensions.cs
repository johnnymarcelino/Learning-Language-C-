
using System.Runtime.CompilerServices;

namespace System  // utilizando o macete do namespace que é proprietário do tipo utilizado
{
    static class StringsExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
