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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EducationEFDbEntities db = new EducationEFDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblGuide.ToList(); // Tüm listeyi döndürür.
            dataGridView1.DataSource = values; // DataGridView'e doldurur.

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide();    
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.TblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide succesfully added.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.TblGuide.Find(id);
            db.TblGuide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Guide succesfully deleted.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.TblGuide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide succesfully updated.",
                "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnListById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.TblGuide.Where(x => x.GuideId == id).ToList(); // x öyle ki x'in GuideId'si id'ye eşit olsun.
            dataGridView1.DataSource = values;
        }
    }
}
