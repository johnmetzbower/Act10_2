using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act10_2
{
    public partial class Form1 : Form
    {
        private DataSet _pubDataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            _pubDataSet = author.GetData();
            dgvAuthors.DataSource = _pubDataSet.Tables["Authors"];
        }
    }
}
