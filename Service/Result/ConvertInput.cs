using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Result
{
    public static class ConvertInput
    {
        public static string ConvertToLower(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input.ToLower();
        }

    }
}
