using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise2
{
      public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Record records = new Record();

        public class Record
        {
            public double array1 { get; set; }
            public double array2 { get; set; }
            public double array3 { get; set; }
            public double array4 { get; set; }
            public double array5 { get; set; }

            List<Record> records = new List<Record>();
            
        }

        private void btnArray1_Click(object sender, EventArgs e)
        {
            try
            {
               
                records.array1 = Double.Parse(txtInput.Text);
                txtInput.Clear();
            }
            catch (Exception ex)
            {


                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }

        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            try
            {
              
                records.array2 = Double.Parse(txtInput.Text);
                txtInput.Clear();
            }
            catch (Exception ex)
            {


                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnArray3_Click(object sender, EventArgs e)
        {
            try
            {
              
                records.array3 = Double.Parse(txtInput.Text);
                txtInput.Clear();
            }
            catch (Exception ex)
            {


                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnArray4_Click(object sender, EventArgs e)
        {
            try
            {
                
                records.array4 = Double.Parse(txtInput.Text);
                txtInput.Clear();
            }
            catch (Exception ex)
            {


                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnArray5_Click(object sender, EventArgs e)
        {
            try
            {
            
                records.array5 = Double.Parse(txtInput.Text);
                txtInput.Clear();
            }
            catch (Exception ex)
            {


                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
          
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
        }
                           
        }
    }



/* switch ()
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }*/