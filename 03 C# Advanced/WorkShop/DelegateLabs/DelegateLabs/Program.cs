using PhotoManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLabs
{
    class Program
    {
        static void CustomFilter(Photo photo)
        {
            Console.WriteLine("Custom filter was applied");
        }
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            Action<Photo> handler = photoFilters.ApplyBrightness;
            handler += photoFilters.ApplyContrast;
            handler += photoFilters.Resize;
            handler += CustomFilter;

            processor.Process("photo.jpeg", handler);
        }
    }
}
