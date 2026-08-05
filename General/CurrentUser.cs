using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Full_Proj.General
{
    public static class CurrentUser
    {
      public static clsUsers_BusinessLayer  User=null;
      static  string _filePath = @"C:\DVLD_Users_Info\LoginInfo.txt";
      static  Char _Spliter = '|';
        public static void Write_To_File(string Line1, string Line2)
        {
            string content = Line1 + _Spliter + Line2;



             string folderPath = Path.GetDirectoryName(_filePath);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);


            File.WriteAllText(_filePath, content);
        }


        public static  string[] Read_From_File()
        {
            if (!File.Exists(_filePath))
                return null;

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    return line.Split(_Spliter);
                }
            }

            return null;
        }


        public static  void ClearFile()
        {


            if (File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, string.Empty);
            }
            return;
        }



    }
}
