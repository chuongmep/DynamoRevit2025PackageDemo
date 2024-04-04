using Autodesk.Revit.DB;
using RevitServices.Persistence;

namespace DynamoRevit2025Sample;

public static class Hello
{
    public static string SayHello(string name)
    {
        return $"Hello, {name}!";
    }
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static Document GetDBDocument()
    {
         var doc = DocumentManager.Instance.CurrentDBDocument;
         return doc;
    }
}