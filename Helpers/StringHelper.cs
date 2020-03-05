using System;
using System.Collections.Generic;
using System.Linq;
using NorthWind.API.Helpers.Extensions;
using System.Threading.Tasks;

namespace NorthWind.API.Helpers
{
    public class StringHelper
    {
        public static string PreprocessKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return string.Empty;
            keyword = keyword.RemoveVietNameseSign().ToLower().Trim();

            var newChars = keyword.Select(ch =>
                             ((ch >= 'a' && ch <= 'z')
                                  || (ch >= 'A' && ch <= 'Z')
                                  || (ch >= '0' && ch <= '9')
                                  || ch == '-' || ch == ' ') ? ch : '-')
                       .ToArray();

            return new string(newChars);
        }

        public static string StandardizeKeyword(string keyword, out string secondQry, bool preProcessed = true)
        {
            secondQry = string.Empty;
            if (!preProcessed)
            {
                keyword = keyword.RemoveVietNameseSign().ToLower().Trim();
            }

            string[] parts = keyword.Split(' ');
            string qry = string.Empty;

            if (parts.Length > 1)
            {
                bool hasHouseNumber = false;
                if (parts[0].Any(char.IsDigit))
                {
                    hasHouseNumber = true;
                }

                for (int i = 0; i < parts.Length; i++)
                {
                    qry += " & " + parts[i];
                    if (hasHouseNumber && i != 0)
                    {
                        secondQry += " & " + parts[i];
                    }
                }
            }

            if (qry.StartsWith(" & "))
            {
                qry = qry.Substring(3);
            }

            if (secondQry.StartsWith(" & "))
            {
                secondQry = secondQry.Substring(3);
            }

            if (string.IsNullOrEmpty(qry))
            {
                qry = keyword;
            }
            return qry;
        }
    }
}
