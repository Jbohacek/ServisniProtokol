using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServisniProtokol.Items;
using ServisniProtokol.Managers;
using ServisniProtokol.Managers.SaveItemsData;

namespace ServisniProtokol.Forms
{
    public partial class PreviewForm : Form
    {
        private PreviewItem PreviewItem { get; set; }

        public PreviewForm(PreviewItem preview)
        {
            InitializeComponent();
            PreviewItem = preview;
            _formatLeft.Alignment = StringAlignment.Near;
            _formatMiddle.Alignment = StringAlignment.Center;
            _formatRight.Alignment = StringAlignment.Far;

            _boxOneInfoNazev += PreviewItem.CustomerInfo.Nazev;
            _boxOneInfoAdresa += PreviewItem.CustomerInfo.adresa;
            _boxOneInfoPsc += PreviewItem.CustomerInfo.PSC;
            _boxOneInfoIc += PreviewItem.CustomerInfo.IC;

            _boxTwoInfoModel += PreviewItem.DeviceInfo.Model;
            _boxTwoInfoVyrobce += PreviewItem.DeviceInfo.Vyrobce;
            _boxTwoInfoSerioveCislo += PreviewItem.DeviceInfo.SerioveCislo;

            _infoOne += PreviewItem.BasicInfo.DateOfMeasurement.ToShortDateString();
            _infoTwo += PreviewItem.BasicInfo.NumProtokol;

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private readonly Pen _blackPen = Pens.Black;
        private const string TitleText = "Potvrzení o provedení měření";

        private  string _infoOne = "Datum měření: ";
        private  string _infoTwo = "Čislo protokolu: ";

        private const string HeaderBoxOne = "Zákazník";
        private  string _boxOneInfoNazev = "Název: ";
        private  string _boxOneInfoAdresa = "Adresa: ";
        private  string _boxOneInfoPsc = "PSČ: ";
        private  string _boxOneInfoIc = "IČ: ";

        private const string HeaderBoxTwo = "Zařízení";
        private string _boxTwoInfoVyrobce = "Výrobce: ";
        private string _boxTwoInfoModel = "Model: ";
        private string _boxTwoInfoSerioveCislo = "Sériové číslo: ";

        private const string Measurements = "Měření";
        private const string Parameter = "Parameter";
        private const string Value = "Naměřená hodnota";
        private const string IsValid = "Vyhovuje";

        private const string DeviceIsCapable = "Zařízení je schopné dalšího provozu";
        private const string DeviceIsNotCapable = "Zařízení není schopné dalšího provozu";

        private const string FontName = "Arial";

        private readonly Font _titleFont = new Font(FontName, 24f, FontStyle.Bold);
        private readonly Font _infoTextFont = new Font(FontName, 13f, FontStyle.Regular);
        private readonly Font _boxHeaderTextFont = new Font(FontName, 19f, FontStyle.Regular);
        private readonly Font _boxTextFont = new Font(FontName, 14f, FontStyle.Regular);
        private readonly Font _lastSentence = new Font(FontName, 20f, FontStyle.Bold);

        private readonly Font _normalFont = new Font(FontName, 15f, FontStyle.Regular);

        private const int pading = 10;
        private const int paddingInside = 10;

        readonly StringFormat _formatLeft = new StringFormat();
        readonly StringFormat _formatMiddle = new StringFormat();
        readonly StringFormat _formatRight = new StringFormat();

        private void pPaintBox_Paint(object sender, PaintEventArgs e)
        {
            int width = pPaintBox.Width;
            int height = pPaintBox.Height;


            Graphics g = e.Graphics;
            g.Clear(Color.White);

            Rectangle outLineRec = new Rectangle(pading, 10, width - pading*2, height - pading*2);

            g.DrawRectangle(_blackPen, outLineRec);

            //Title

            var titleMeasure = g.MeasureString(TitleText, _titleFont);
            Rectangle titleRect = new Rectangle(pading, pading, width - pading * 2, Convert.ToInt32(titleMeasure.Height) + 25);

            g.DrawString(TitleText, _titleFont, Brushes.Black, titleRect, _formatMiddle);

            g.TranslateTransform(titleRect.X + paddingInside,titleRect.Y + titleRect.Height);

            //Info

            var infoMeasure = g.MeasureString(_infoOne, _infoTextFont);

            Rectangle infoRect = new Rectangle(0, 0, width - (pading * 2 + paddingInside * 2), Convert.ToInt32(infoMeasure.Height));


            g.DrawString(_infoOne,_infoTextFont,Brushes.Black,infoRect,_formatLeft);
            g.DrawString(_infoTwo, _infoTextFont, Brushes.Black, infoRect, _formatRight);

            g.TranslateTransform(infoRect.X, infoRect.Y + infoRect.Height + paddingInside);
            //Box1

            Rectangle boxOne = new Rectangle(0,
                0,
                width / 2 - paddingInside * 2, 
                100);

            var boxHeight = DrawBox(g,boxOne, HeaderBoxOne, new string[] { _boxOneInfoNazev, _boxOneInfoAdresa, _boxOneInfoPsc, _boxOneInfoIc });

            // Box2

            Rectangle boxTwo = new Rectangle(0 + width / 2 - pading,
                0,
                width / 2 - paddingInside * 3,
                boxHeight);
            DrawBox(g,boxTwo,HeaderBoxTwo,new string[]{_boxTwoInfoVyrobce,_boxTwoInfoModel,_boxTwoInfoSerioveCislo},false);


            g.TranslateTransform(0, boxHeight + pading * 4);

            //Measurement
            int fontHeight = Convert.ToInt32(g.MeasureString(Measurements, _normalFont).Height);

            g.DrawString(Measurements, _normalFont, Brushes.Black,0,0);
            g.TranslateTransform(0, fontHeight + pading);

            // Headings

            Rectangle headingRectangle = new Rectangle(0, 0, width - pading * 4, fontHeight);

            g.DrawString(Parameter, _normalFont, Brushes.Black, headingRectangle,_formatLeft);
            g.DrawString(Value, _normalFont, Brushes.Black, headingRectangle, _formatMiddle);
            g.DrawString(IsValid, _normalFont, Brushes.Black, headingRectangle, _formatRight);

            g.TranslateTransform(0, fontHeight + pading);

            //Rows
            foreach (var item in PreviewItem.Items)
            {
                DrawRow(g,item,width,fontHeight);
                g.TranslateTransform(0, fontHeight);
            }
            g.TranslateTransform(0, fontHeight + pading);

            // LastSentence

            string textToWrite = PreviewItem.DeviceIsCapable ? DeviceIsCapable : DeviceIsNotCapable;

            Rectangle lastSentence = new Rectangle(0, 0, width - pading * 4, Convert.ToInt32(g.MeasureString(Measurements, _lastSentence).Height));

            g.DrawString(textToWrite, _lastSentence, Brushes.Black, lastSentence, _formatMiddle);
        }

        private void DrawRow(Graphics g, ListItemMeasurement item, int width, int fontHeight)
        {
            Rectangle rowValue = new Rectangle(0, 0, width - pading * 4, fontHeight);

            var result = item.IsValid == true ? "ANO" : "NE";

            g.DrawString(item.Parameter, _normalFont, Brushes.Black, rowValue, _formatLeft);
            g.DrawString(item.Value.ToString() + " " + item.Unit, _normalFont, Brushes.Black, rowValue, _formatMiddle);
            g.DrawString(result, _normalFont, Brushes.Black, rowValue, _formatRight);
        }

        private int DrawBox(Graphics g, Rectangle box, string header, string[] values, bool overWrite = true)
        {
            g.DrawString(header, _boxHeaderTextFont, Brushes.Black, box.X + pading, box.Y + pading);

            var heightHeader = Convert.ToInt32(g.MeasureString(HeaderBoxOne, _boxHeaderTextFont).Height);
            var heightText = Convert.ToInt32(g.MeasureString(_boxOneInfoNazev, _boxTextFont).Height);

            for (int i = 0; i < values.Length; i++)
            {
                g.DrawString(values[i], _boxTextFont, Brushes.Black, box.X + pading, box.Y + pading + heightHeader + heightText * i );
            }

            if(overWrite)
                box.Height = heightHeader + heightText * values.Length + pading;

            g.DrawRectangle(Pens.Black, box);

            return box.Height;
        }

        private void pPaintBox_Resize(object sender, EventArgs e)
        {
            pPaintBox.Refresh();
        }
    }
}
