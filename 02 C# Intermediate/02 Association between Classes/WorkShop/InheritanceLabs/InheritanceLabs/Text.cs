using System;

namespace InheritanceLabs
{
    public class Text : PersentationObject
    {
        public string Color;
        public string Font;

        public void AddHyperLink(string url)
        {
            Console.WriteLine("hyperlink was added to " + url);
        }
    }

    public class SubText : Text
    {
        public string SubColor;
        public string SubFont;

        public void SubAddHyperLink(string url)
        {
            this.Width
            Console.WriteLine("hyperlink was added to " + url);
        }
    }
}
