namespace DesignPatterns.StructuralPatterns.AdapterPattern;

internal class EmailAdapter : IEmail
{
    private readonly ExternalEmailLibrary _emailLibrary;
    public EmailAdapter()
    {
        _emailLibrary = new ExternalEmailLibrary();
    }

    public void SendEmail(string reciver, string subject, string body)
    {
        _emailLibrary.SendEmailThirdLibrary(subject, body, reciver);
    }
}
