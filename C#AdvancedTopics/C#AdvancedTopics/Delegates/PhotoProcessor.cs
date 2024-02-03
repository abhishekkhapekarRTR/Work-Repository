using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedTopics.Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        public void UsingGenericcDelegate(string path, Action<Photo> photoHandler)
        {
            var photo = Photo.Load(path);

            photoHandler(photo);

            photo.Save();
        }
    }
}
