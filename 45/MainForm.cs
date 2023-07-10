using _45.Domain.Abstract;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUnitOfWork unitOfWork = DbFactory.GetUnitOfWork();

            unitOfWork.CreateTransaction();
            unitOfWork.Commit();

            Thread.Sleep(500);

            lblSuccessText.Text = "Succesfully Connected";
            lblSuccessText.ForeColor = Color.Green;

            Thread.Sleep(500);

            Form n = new Form1();
            n.Show();
        }
    }
}