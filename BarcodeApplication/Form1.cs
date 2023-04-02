using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BarcodeApplication
{
    public partial class Form1 : Form
    {

        private BarcodeFormat selectedFormat = BarcodeFormat.EAN_13;

        public Form1()
        {
            InitializeComponent();
            SetUpDropDownList();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = selectedFormat };
            barcodeImage.Image = writer.Write(encodeText.Text);
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)barcodeImage.Image);
            if (result != null)
            {
                decodeText.Text = result.Text;
            }
        }

        private void SetUpDropDownList()
        {
            foreach (BarcodeFormat item in Enum.GetValues(typeof(BarcodeFormat)))
            {
                dropDownList.Items.Add(item);
            }

            dropDownList.SelectedIndex = 0;
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = dropDownList.SelectedItem;
            selectedFormat = (BarcodeFormat)selectedItem;
        }
    }
}
