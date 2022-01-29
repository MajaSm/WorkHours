using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHours1
{
    public partial class Form2 : Form
    {
        private Month _sendMonth = null;
        public Form2(Month month)
        {
            InitializeComponent();
            _sendMonth = month;
        }
        
        private  void Form2_Load(object sender, EventArgs e)
        {
            txtValue.Text = String.Empty;
            for (int i = 0; i < _sendMonth.ListOfDays.Count; i++)
            {
                Day day = _sendMonth.ListOfDays[i];
                
                txtValue.Text += $"{day.Date.ToString("dd.MM")} {day.DayName} : {day.TotalOvertime}\n";
            }
            NewLine(2);


            txtValue.Text += $"Overtime this month: {_sendMonth.Overtime}"; 


            //fix new lines
            txtValue.Text = txtValue.Text.Replace("\n", Environment.NewLine);
        }

        
        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLine(int numberOfLine)
        {
            for(int i = 0;i< numberOfLine; i++)
            {
                txtValue.Text += "\n";
            }
           
        }
    }
}
