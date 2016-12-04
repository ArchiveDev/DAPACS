using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAPACS.BLL;

namespace DAPACS
{
    public partial class Form1 : Form
    {
        private IExcelManager excelManager = new ExcelManagerImpl();

        public Form1()
        {
            InitializeComponent();
        }

        private void TimeBtn_Click(object sender, EventArgs e)
        {
            excelManager.test();
        }
    }
}
