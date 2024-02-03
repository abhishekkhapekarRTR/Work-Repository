// See https://aka.ms/new-console-template for more information
using C_AdvancedTopics.Delegates;

internal class PhotoFilter
{
    public PhotoFilter()
    {
    }

    internal void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Apply brightness method is called");
    }

    internal void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Apply contrast method is called");
    }
}