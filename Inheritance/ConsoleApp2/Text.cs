using System;

namespace Inheritance
{
    class Text : PresntationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }


        public Text(int fontsize,string fontname)
        {
            FontSize = fontsize;
            FontName = fontname;
            Console.WriteLine("Text details are: "+FontName,FontSize);
        }

        public Text()
        {
        }
    }
}
