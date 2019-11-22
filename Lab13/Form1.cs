using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.planetsTableAdapter.Fill(this.lab13DataSet.planets);
            int ColumnCount = this.lab13DataSet.planets.Columns.Count;
            for (int i = 0; i < ColumnCount; i++)
                this.Filter.Items.Add(this.lab13DataSet.planets.Columns[i].ToString());
            label4.Text = "";
            Value.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {// установитьфильтр
            string filter = this.Filter.Text;
            this.planetsBindingSource.Filter = filter + " = '" + this.Value.Text + "'";
            label4.Text = filter + " = '" + this.Value.Text + "'";
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {//отменитьфильтр
            this.planetsBindingSource.Filter = "";
            label4.Text = "";
            Value.Text = "";
        }
    }

}
