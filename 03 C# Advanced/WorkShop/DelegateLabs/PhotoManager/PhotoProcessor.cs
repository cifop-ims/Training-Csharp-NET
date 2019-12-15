namespace PhotoManager
{
    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            
            var photoFilters = new PhotoFilters();
            photoFilters.ApplyBrightness(photo);
            photoFilters.ApplyContrast(photo);
            photoFilters.Resize(photo);
            
            photo.Save();
        }
    }
}
