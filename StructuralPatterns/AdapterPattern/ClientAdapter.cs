namespace DesignPatterns.StructuralPatterns.AdapterPattern;

internal class ClientAdapter
{
private readonly IEmail _email;

    public ClientAdapter(IEmail email)
    {
        _email = email;
    }

    public void SendAnEmail(string to, string subject, string body)
    {
        _email.SendEmail(to, subject, body);
    }
}
