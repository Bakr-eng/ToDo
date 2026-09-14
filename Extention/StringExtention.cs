using System.Runtime.CompilerServices;

namespace ToDo.Extention
{
    public static class StringExtention
    {
        public static string LimitLength(this string str, int maxlength)
        {
            if (str != null)
            {
                if (str.Length <= maxlength)
                {
                    return str;
                }
            }
            return str.Substring(0, maxlength);
        }

    }
}
