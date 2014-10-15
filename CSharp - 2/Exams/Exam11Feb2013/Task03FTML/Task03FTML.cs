using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Task03FTML
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        string text = null;
        for (int i = 0; i < n; i++)
        {
            text = Console.ReadLine();
            if (i != n - 1)
            {
                sb.AppendLine(text);
            }
            else
            {
                sb.Append(text);
            }
        }
        text = sb.ToString();
        int openStartTag = text.IndexOf('<');
        int openEndTag = text.IndexOf('>');

        int closeStartTag = text.IndexOf("</", openEndTag + 1);
        int closeEndTag = text.IndexOf('>', closeStartTag + 1);
        string toReplace = null;
        string tagName = null;

        while (openStartTag != -1 && openEndTag != -1 && closeStartTag != -1 && closeEndTag != -1)
        {
            toReplace = text.Substring(openStartTag, closeEndTag - openStartTag + 1);
            tagName = text.Substring(openStartTag, openEndTag - openStartTag + 1);

            while (Regex.Matches(toReplace, "<").Count > 2)
            {
                openStartTag = text.IndexOf('<', openEndTag + 1);
                openEndTag = text.IndexOf('>', openStartTag + 1);
                toReplace = text.Substring(openStartTag, closeEndTag - openStartTag + 1);
                tagName = text.Substring(openStartTag, openEndTag - openStartTag + 1);
            }
            string closingTagName = text.Substring(closeStartTag, closeEndTag - closeStartTag + 1);
            closingTagName = closingTagName.Replace("/", "");
            if (tagName != closingTagName)
            {
                while (tagName != closingTagName)
                {
                    closeStartTag = text.IndexOf("</", closeEndTag + 1);
                    closeEndTag = text.IndexOf('>', closeStartTag + 1);
                    closingTagName = text.Substring(closeStartTag, closeEndTag - closeStartTag + 1);
                    closingTagName = closingTagName.Replace("/", "");
                }
                toReplace = text.Substring(openStartTag, closeEndTag - openStartTag + 1);
            }
            text = TagDictionary(text, toReplace, tagName);

            openStartTag = text.IndexOf('<');
            openEndTag = text.IndexOf('>');
            closeStartTag = text.IndexOf("</");
            closeEndTag = text.IndexOf('>', closeStartTag + 1);
        }
        Console.WriteLine(text);
    }

    public static string TagDictionary(string text, string toReplace, string whatIs)
    {
        if (whatIs == "<upper>")
        {
            string repWith = toReplace;
            repWith = Regex.Replace(repWith, @"<upper>|</upper>", "");
            repWith = repWith.ToUpper();
            text = text.Replace(toReplace, repWith);
            return text;
        }
        else if (whatIs == "<lower>")
        {
            string repWith = toReplace;
            repWith = Regex.Replace(repWith, @"<lower>|</lower>", "");
            repWith = repWith.ToLower();
            text = text.Replace(toReplace, repWith);
            return text;
        }
        else if (whatIs == "<toggle>")
        {
            string temp = toReplace;

            temp = Regex.Replace(temp, @"<toggle>|</toggle>", "");

            char[] repArray = temp.ToCharArray();
            for (int i = 0; i < repArray.Length; i++)
            {
                if (char.IsUpper(repArray[i]))
                {
                    repArray[i] = char.ToLower(repArray[i]);
                }
                else
                {
                    repArray[i] = char.ToUpper(repArray[i]);
                }
            }

            StringBuilder repWith = new StringBuilder();
            foreach (var item in repArray)
            {
                repWith.Append(item);
            }
            text = text.Replace(toReplace, repWith.ToString());
            return text;
        }
        else if (whatIs == "<del>")
        {
            text = text.Replace(toReplace, "");
            return text;
        }
        else
        {
            string temp = toReplace;
            temp = Regex.Replace(temp, @"<rev>|</rev>", "");
            char[] repArray = temp.ToCharArray();
            Array.Reverse(repArray);
            StringBuilder repWith = new StringBuilder();
            foreach (var item in repArray)
            {
                repWith.Append(item);
            }

            text = text.Replace(toReplace, repWith.ToString());
            return text;
        }
    }
}