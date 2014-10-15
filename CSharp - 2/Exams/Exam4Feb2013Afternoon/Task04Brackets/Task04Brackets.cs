using System;
using System.Text;
using System.Text.RegularExpressions;

class Task04Brackets
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        string spaceses = Console.ReadLine();
        //string[] text = new string[lines];

        RegexOptions options = RegexOptions.None;
        Regex regex = new Regex(@"[ ]{2,}", options);

        StringBuilder text = new StringBuilder();
        for (int i = 0; i < lines; i++)
        {
            string temp = Console.ReadLine();
            temp = regex.Replace(temp, @" ");
            if (i != lines - 1)
                text.AppendLine(temp);
            else
            {
                text.Append(temp);
            }
        }

        string[] splitted = text.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < splitted.Length; i++)
        {
            string temp = splitted[i];
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == '{')
                {
                    if (sb.ToString() != "" && !(sb.ToString()[sb.ToString().Length - 1] == '\n'))
                    {
                        sb.AppendLine();
                    }
                    
                    sb.AppendLine(temp[j].ToString());
                }
                else if (temp[j] == '}')
                {
                    if (j > 0 && temp[j - 1] != '}')
                    {
                        sb.AppendLine();
                    }
                    if (i != splitted.Length - 1)
                    {
                        sb.AppendLine(temp[j].ToString());
                    }
                }
                else
                {
                    // here for white space
                    if (j < splitted.Length - 1 && temp[j] == ' ' && temp[j + 1] == '\"')
                    {
                    }
                    else
                    {
                        sb.Append(temp[j].ToString());
                    }
                }

                if (j == temp.Length - 1 && temp[j] != '}' && temp[j] != '{')
                {
                    sb.AppendLine();
                }
            }
        }
        sb.AppendLine("}");

        string[] source = sb.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < source.Length; i++)
        {
            source[i] = source[i].Trim();
        }

        int counter = 0;
        int oldCounter = 0;
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] == "{")
            {
                oldCounter = counter;
                while (oldCounter > 0)
                {
                    Console.Write(spaceses);
                    oldCounter--;
                }
                Console.WriteLine(source[i]);
                counter++;
                continue;
            }
            else if (source[i] == "}")
            {
                counter--;
            }
            
            oldCounter = counter;
            while (oldCounter > 0)
            {
                Console.Write(spaceses);
                oldCounter--;
            }
            Console.WriteLine(source[i]);
        }
    }
}