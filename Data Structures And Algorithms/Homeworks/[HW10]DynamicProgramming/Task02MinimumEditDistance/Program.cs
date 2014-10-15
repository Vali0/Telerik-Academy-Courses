using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02MinimumEditDistance
{
    class Program
    {
        private static readonly double replaceWeight = 1;
        private static readonly double deleteWeight = 0.9;
        private static readonly double insertWeight = 0.8;

        internal static void Main()
        {
            Console.WriteLine("The total weight is: {0}", GetTotalWeight("developer", "enveloped"));
        }
        
        private static string GetMaxEqualSequence(string source, string result)
        {
            for (int i = source.Length; i >= 1; i--)
            {
                for (int j = 0; j <= source.Length - i; j++)
                {
                    var current = source.Substring(j, i);
                    if (result.IndexOf(current) > -1)
                    {
                        return current;
                    }
                }
            }

            return string.Empty;
        }

        private static double GetTotalWeight(string source, string result)
        {
            var common = GetMaxEqualSequence(source, result);
            if (common == string.Empty)
            {
                if (source.Length < result.Length)
                {
                    return (source.Length * replaceWeight) + ((result.Length - source.Length) * insertWeight);
                }
                else
                {
                    return (result.Length * replaceWeight) + ((source.Length - result.Length) * deleteWeight);
                }
            }

            var prefixResult = result.Substring(0, result.IndexOf(common));
            var suffixResult = result.Substring(result.IndexOf(common) + common.Length);
            var prefixSource = source.Substring(0, source.IndexOf(common));
            var suffixSource = source.Substring(source.IndexOf(common) + common.Length);

            return GetTotalWeight(prefixSource, prefixResult) + GetTotalWeight(suffixSource, suffixResult);
        }
    }
}