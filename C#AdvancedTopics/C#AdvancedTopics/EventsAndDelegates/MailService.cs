// See https://aka.ms/new-console-template for more information
using C_AdvancedTopics.EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
    }
}
