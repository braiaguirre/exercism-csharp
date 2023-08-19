using System;
using System.Linq;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string div)
    {
        return str.Substring(str.IndexOf(div) + div.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string end)
    {
        return str.Substring(str.IndexOf(start) + start.Length, str.IndexOf(end) - (str.IndexOf(start) + start.Length)); 
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");     
    }
}