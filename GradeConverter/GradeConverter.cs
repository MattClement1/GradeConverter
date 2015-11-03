using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeConverter
{
    public partial class frmGradeConverter : Form
    {
        private int CalculateGrade(string grade)
        {
            int percentGrade= 0;

            if (grade == "NE")
            {
                percentGrade = 0;
            }
            else if (grade == "R")
            {
                percentGrade = 30;
            }
            else if (grade == "1-")
            {
                percentGrade = 52;
            }
            else if (grade == "1")
            {
                percentGrade = 55;
            }
            else if (grade == "1+")
            {
                percentGrade = 57;
            }
            else if (grade == "2-")
            {
                percentGrade = 62;
            }
            else if (grade == "2")
            {
                percentGrade = 65;
            }
            else if (grade == "2+")
            {
                percentGrade = 67;
            }
            else if (grade == "3-")
            {
                percentGrade = 72;
            }
            else if (grade =="3")
            {
                percentGrade = 75;
            }
            else if (grade == "3+")
            {
                percentGrade = 77;
            }
            else if (grade == "4-")
            {
                percentGrade = 85;
            }
            else if (grade == "4")
            {
                percentGrade = 90;
            }
            else if (grade == "4+")
            {
                percentGrade = 95;
            }
            else
            {
                percentGrade = -1;
            }

            return percentGrade;
        }

        public frmGradeConverter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string gradeInput = this.txtGradeInput.Text;
            int percentGrade;

            percentGrade = CalculateGrade(gradeInput);

            this.lblAnswer.Text = Convert.ToString(percentGrade);
        }
    }
}
