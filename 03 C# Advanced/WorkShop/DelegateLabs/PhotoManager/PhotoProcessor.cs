using System;

namespace PhotoManager
{
    public class PhotoProcessor
    {
        public string Sample(int a)
        {
            return a.ToString();
        }
        public void Process(string path, Action<Photo> handler)
        {
            //Func<int, string> func = Sample;
            //func(5);
            var photo = Photo.Load(path);

            handler(photo);

            photo.Save();
        }
    }
}
