using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConvertSQLCase
{
    class Program
    {
        public static string FileAddress = "c:\\Data.txt";
        static void Main(string[] args)
        {
            var list = EnumHelper.GetDescriptionAndValue(typeof(ProductStatus));
            StringBuilder result = new StringBuilder();
            foreach (var data in list)
            {
                result.AppendLine(string.Format(" when {0} then '{1}'",data.Value,data.Key));
            }

            // 写入文件
            WriteString(result.ToString());
        }

        public static void WriteString(string str)
        {
            FileStream fs = null;
            if (!File.Exists(FileAddress))
            {
                fs = new FileStream(FileAddress, FileMode.Create);
            }
            else
            {
                fs = new FileStream(FileAddress, FileMode.Append);
            }

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(str); 
            sw.Close();
        }
    }
}
