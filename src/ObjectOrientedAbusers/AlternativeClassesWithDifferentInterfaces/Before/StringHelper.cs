namespace ObjectOrientedAbusers.AlternativeClassesWithDifferentInterfaces.Before;

public class StringHelper
{
    public static string NormalizeCharacters(string content)
    {
        content = content.Replace("\"", "'");
        content = content.Replace("{", "[");
        content = content.Replace("}", "]");

        return content;
    }
}