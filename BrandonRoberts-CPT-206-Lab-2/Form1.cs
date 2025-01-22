using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonRoberts_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDataSet.City);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!");
            this.Close();
        }

        private void btnSortCity_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.OrderByCity(this.cityDataSet.City);
        }

        private void btnPopAscend_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.OrderByPopulationAscending(this.cityDataSet.City);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.OrderByPopulationDescending(this.cityDataSet.City);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total population: " + this.cityTableAdapter.TotalQuery());        
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The average population is: " + this.cityTableAdapter.AverageQuery());
        }

        private void btnHighestPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The highest population is: " + this.cityTableAdapter.HighestQuery());
        }

        private void btnLowestPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The lowest population is: " + this.cityTableAdapter.LowestQuery());
        }
    }
}
