using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EGIControlButtonsv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void strategyParametersPerformanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.strategyParametersPerformanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFundDataSet);

        }

        private void strategyParametersPerformanceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.strategyParametersPerformanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eFundDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eFundDataSet.StrategyParametersPerformance' table. You can move, or remove it, as needed.
            this.strategyParametersPerformanceTableAdapter.Fill(this.eFundDataSet.StrategyParametersPerformance);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conVM = new SqlConnection("Data Source=localhost;Initial Catalog=EFund;Integrated Security=True");
            conVM.Open();
            SqlCommand scVM = new SqlCommand("exec [PIPrecisionEntry].[ReduceMAEBy50]",conVM);
            scVM.ExecuteNonQuery();
            MessageBox.Show("MAE Values have been reduced by 50... Make sure you don't run this more than once a day! -VM");
            conVM.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                           
            if (RedlightBox.Visible == false)
            {
                RedlightBox.Visible = true;
                GreenlightBox.Visible = false;
                penguinBox.Visible = false;
                spinnerBox.Visible = false;
                workingOnItLabel.Visible = false;
                button3.Text = "GO!";
            }
            else if (RedlightBox.Visible == true)
            {
                RedlightBox.Visible = false;
                GreenlightBox.Visible = true;
                penguinBox.Visible = true;
                spinnerBox.Visible = true;
                workingOnItLabel.Visible = true;
                button3.Text = "STOP!";
            }

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
      
    }
}
