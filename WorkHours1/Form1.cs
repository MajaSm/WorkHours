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
    public partial class Form1 : Form 
    {
        private JsonLoader _jsonLoader;

        private Month _month = new Month();

      

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            SetDateTimeFormat(dateTimeStart);
            SetDateTimeFormat(dateTimeEnd);
            SetDateTimeFormat(dateTimeWorkDone);
        }

        private void SaveNewDayToJson(Day newDay, string nameOfMonth)
        {
            if (_jsonLoader == null)
            {
                _jsonLoader = new JsonLoader();
            }

            _month.MonthName = nameOfMonth;
            _month.SaveDay(newDay);

            _jsonLoader.SaveMonthData(_month, nameOfMonth);
        }

        private void LoadDaysFromJson(string nameOfMonth, bool isFullPath)
        {
            if(_jsonLoader == null)
            {
                _jsonLoader = new JsonLoader();
            }
            

            _month = _jsonLoader.LoadMonthData(nameOfMonth, isFullPath);
           
            if(_month == null)
            {
                _month = new Month();
            }
        }

     
        private void SetDateTimeFormat(DateTimePicker dateTimeStart)
        {
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "HH:mm";
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimeWorkDone_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            DateTime timeStart = dateTimeStart.Value;
            DateTime timeEnd = dateTimeEnd.Value;
            DateTime timeWorkDone = dateTimeWorkDone.Value;

            TimeSpan dateTimeWorkDoneTimeSpan = new TimeSpan(timeWorkDone.Hour, timeWorkDone.Minute,0);
            TimeSpan dateto = timeEnd - timeStart;
            TimeSpan a = dateto - dateTimeWorkDoneTimeSpan;

            if(a.TotalMinutes >= 0 )
            {
                RemainingHoursTextBox.Text = a.ToString(@"hh\:mm");
            }
          
            else
            {
                RemainingHoursTextBox.Text = "+" + a.ToString(@"hh\:mm");
            }


            TimeSpan timeStartSpan = new TimeSpan(timeStart.Hour, timeStart.Minute, 0);
            TimeSpan timeNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute,0);
            TimeSpan timeFromStartToNow = timeNow - timeStartSpan;
            
            TimeSpan remainingCurTime = timeFromStartToNow - dateTimeWorkDoneTimeSpan;
           

            if(remainingCurTime.TotalMinutes > 0)
            {
                RemainingHoursToCurrentTimetextBox.Text =  remainingCurTime.ToString(@"hh\:mm");
            }
            else
            {
                RemainingHoursToCurrentTimetextBox.Text = "+" + remainingCurTime.ToString(@"hh\:mm");
            }            
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

       /* private void listOfAllHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestMonthDataPath();

            Form2 f2 = new Form2(_month);
            f2.ShowDialog();
        }*/

       /* private void RequestMonthDataPath()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents | *" + Constants.FILE_TYPE_EXTENSION, Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        LoadDaysFromJson(ofd.FileName, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void buttonSaveDay_Click(object sender, EventArgs e)
        {
            DateTime fullDateTime = dateTimePicker.Value;
            TimeSpan dateTimeWorkDoneTimeSpan = new TimeSpan(dateTimeWorkDone.Value.Hour, dateTimeWorkDone.Value.Minute, 0);
            TimeSpan  totalOverTime = dateTimeWorkDoneTimeSpan.Add(new TimeSpan(-8,0,0));
            
            string nameOfMonth = dateTimePicker.Value.ToString("MMMM");

            Day newDay = new Day(fullDateTime, totalOverTime, dateTimePicker.Value.ToString("dddd"));

            LoadDaysFromJson(nameOfMonth, false);
            SaveNewDayToJson(newDay, nameOfMonth);
        }*/
    }
}
