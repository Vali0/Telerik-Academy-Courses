using System.Text;

static class SbSubstringExtension
{
    // Simple method which use ToString().Substring(); but before that checks for invalid index and length
    public static string Substring(this StringBuilder word, int index, int length)
    {
        if (index < 0 || index > word.Length)
        {
            throw new System.ArgumentOutOfRangeException("Invalid index!");
        }
        if (length < 0 || length > word.Length)
        {
            throw new System.ArgumentOutOfRangeException("Invalid length!");
        }
            return word.ToString().Substring(index, length);
    }
}