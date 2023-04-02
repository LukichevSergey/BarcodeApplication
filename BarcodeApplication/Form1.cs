using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BarcodeApplication
{
    public partial class Form1 : Form
    {

        private BarcodeFormat selectedFormat = BarcodeFormat.EAN_13;
        private List<BarcodeItem> items = new List<BarcodeItem>();

        public Form1()
        {
            InitializeComponent();
            SetUpDropDownList();
            SetUpHistory();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = selectedFormat };
            barcodeImage.Image = writer.Write(encodeText.Text);

            BarcodeItem item = new BarcodeItem(selectedFormat, encodeText.Text);
            items.Add(item);
            barcodeItems.Items.Add(item.date);
            barcodeItems.SelectedIndex = barcodeItems.Items.Count - 1;
        }

        private void SetUpDropDownList()
        {
            foreach (BarcodeFormat item in Enum.GetValues(typeof(BarcodeFormat)))
            {
                dropDownList.Items.Add(item);
            }

            dropDownList.SelectedIndex = 0;
        }

        private void SetUpHistory()
        {
            BarcodeItem item1 = new BarcodeItem(BarcodeFormat.QR_CODE, "HelloWorld!");
            BarcodeItem item2 = new BarcodeItem(BarcodeFormat.QR_CODE, "Hello!");
            items.Add(item1);
            items.Add(item2);

            foreach (BarcodeItem item in items)
            {
                barcodeItems.Items.Add(item.date);
            }
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = dropDownList.SelectedItem;
            selectedFormat = (BarcodeFormat)selectedItem;
        }

        private void barcodeItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = items[barcodeItems.SelectedIndex];
            BarcodeWriter writer = new BarcodeWriter() { Format = selectedItem.format };
            barcodeImage.Image = writer.Write(selectedItem.text);
            encodeText.Text = selectedItem.text;
            selectedFormat = selectedItem.format;
            dropDownList.SelectedItem = selectedItem.format;
        }
    }
}
