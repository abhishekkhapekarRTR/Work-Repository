// See https://aka.ms/new-console-template for more information
using C_AdvancedTopics.EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MessageService : Sending a test message..." + e.Video.Title);
    }
}