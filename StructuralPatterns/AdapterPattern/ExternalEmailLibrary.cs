namespace DesignPatterns.StructuralPatterns.AdapterPattern;

internal class ExternalEmailLibrary
{
    public void SendEmailThirdLibrary(string subject, string body, string to)
    {
        Console.WriteLine("Sending an email by third external library...");
    }
}
