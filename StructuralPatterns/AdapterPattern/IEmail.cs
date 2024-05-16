namespace DesignPatterns.StructuralPatterns.AdapterPattern;

// Expected interface
internal interface IEmail
{
    void SendEmail(string reciver, string subject, string body);
}
