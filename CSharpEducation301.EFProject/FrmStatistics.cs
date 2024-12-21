using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEducation301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EducationEFDbEntities db = new EducationEFDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            

            lblLocationCount.Text = db.TblLocation.Count().ToString();

            lblTotalCapacity.Text = db.TblLocation.Sum(x => x.LocationCapacity).ToString();

            lblGuideNumber.Text = db.TblGuide.Count().ToString();

            lblAvgCapacity.Text = db.TblLocation.Average(x => x.LocationCapacity)?.ToString("0.0");
            // Bu kodda location tablosundaki location price alanının
            // null olma durumuna karşı kontrol eklenmiştir.
            // Null değilse to.string ile stringe çevirilip 0.00 formatına göre yazdırılır.
            lblAvgTourPrice.Text = db.TblLocation.Average(x => x.LocationPrice)?.ToString("0.00") + " ₺";

            int lastCountry = db.TblLocation.Max(x => x.LocationId);
            lblLastCountry.Text = db.TblLocation.Where(x => x.LocationId == lastCountry)
                .Select(y => y.LocationCountry).FirstOrDefault(); // FirstOrDefault() metodu ile sorgunun ilk değeri alınır.

            lblCappadocia.Text = db.TblLocation.Where(x => x.LocationCity == "Cappadocia")
                .Select(y => y.LocationCapacity).FirstOrDefault().ToString();

            lblTurkeyCapacity.Text = db.TblLocation.Where(x => x.LocationCountry == "Turkey")
                .Average(y => y.LocationCapacity)?.ToString("0.0");
            
            int? romeGuideId = db.TblLocation.Where(x => x.LocationCity == "Rome Turistic")
                .Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.TblGuide.Where(x => x.GuideId == romeGuideId)
                .Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            int? maxCapacity = db.TblLocation.Max(x => x.LocationCapacity);
            lblMaxCapacity.Text = db.TblLocation.Where(x => x.LocationCapacity == maxCapacity)
                .Select(y => y.LocationCity + ":" + maxCapacity).FirstOrDefault();

            var mostExpensive = db.TblLocation.Max(x => x.LocationPrice);
            lblMostExpensive.Text = db.TblLocation.Where(x => x.LocationPrice == mostExpensive)
                .Select(y => y.LocationCity + ":\n" + mostExpensive + "₺").FirstOrDefault();

            int? tourAysegul = db.TblGuide
                .Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar")
                .Select(y => y.GuideId).FirstOrDefault();

            lblAysegulTNumber.Text = db.TblLocation.Where(x => x.GuideId == tourAysegul).Count().
                ToString();

        }
    }
}
