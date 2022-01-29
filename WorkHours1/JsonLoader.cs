using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace WorkHours1
{
    public class JsonLoader
    {
        private string _dataPath;

        public JsonLoader()
        {
        }

        public void SaveMonthData(Month month, string nameOfMonth)
        {
            string monthJson = JsonConvert.SerializeObject(month);

            SetDataPath(nameOfMonth);

            File.WriteAllText(_dataPath, monthJson);
        }

        public Month LoadMonthData(string monthPath, bool isFullPath)
        {
            if (isFullPath)
            {
                _dataPath = monthPath;
            }
            else
            {
                SetDataPath(monthPath);
            }
          
            if (File.Exists(_dataPath))
            {
                string monthJson = File.ReadAllText(_dataPath);
                Month month = JsonConvert.DeserializeObject<Month>(monthJson);
                return month;
            }

            return null;
        }

        private void SetDataPath(string nameOfMonth)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            _dataPath = Application.UserAppDataPath + "\\" + System.Text.RegularExpressions.Regex.Replace(nameOfMonth + Constants.FILE_TYPE_EXTENSION, invalidRegStr, "_");
            //_dataPath = Application.UserAppDataPath + "month.txt"; 

        }
    }
}
