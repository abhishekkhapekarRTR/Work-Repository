
namespace C_AdvancedTopics.Delegates
{
    public class Photo
    {
        internal static Photo Load(string path)
        {
            return new Photo();
        }

        internal void Save()
        {
            Console.WriteLine("Your photo is saved now.");
        }
    }
}