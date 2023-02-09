namespace ObjectOrientedAbusers.AlternativeClassesWithDifferentInterfaces.Before;

public static class StringExtensions
{
    public static string NormalizeContent(this string content)
    {
        content = content.Replace("\"", "'");
        content = content.Replace("{", "[");
        content = content.Replace("}", "]");

        return content;
    }
}