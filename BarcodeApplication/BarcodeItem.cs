using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace BarcodeApplication
{
    internal class BarcodeItem
    {
        public string guid;
        public DateTime date;
        public BarcodeFormat format;
        public string text;

        public BarcodeItem(BarcodeFormat format, string text)
        {
            this.guid = Guid.NewGuid().ToString();
            this.date = DateTime.Now;
            this.format = format;
            this.text = text;
        }
    }
}
