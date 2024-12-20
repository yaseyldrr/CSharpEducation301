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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EducationEFDbEntities db = new EducationEFDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList(); // Tüm listeyi döndürür.
            dataGridView1.DataSource = values; // DataGridView'e doldurur.

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString()); 
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location succesfully added.");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,// anonymous type, anonim nesne
                x.GuideId
            }).ToList();

            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
            cmbGuide.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deleteId = int.Parse(txtId.Text);
            var deleteValue = db.TblLocation.Find(deleteId);
            db.TblLocation.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Location succesfully deleted.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateId = int.Parse(txtId.Text);
            var updateValue = db.TblLocation.Find(updateId);

            updateValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.LocationCity = txtCity.Text;
            updateValue.LocationCountry = txtCountry.Text;
            updateValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updateValue.DayNight = txtDayNNight.Text;
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Location succesfully updated.");

        }
    }
}
