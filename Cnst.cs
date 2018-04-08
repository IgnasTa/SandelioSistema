using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SandelioSistema
{
    class Cnst
    {
        public static int alevel = 0;
        
        public static SqlConnection SqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Igno dokumentai\Programavimas\Programs\SandelioSistema\Database SQL\SandelioDB.mdf;Integrated Security=True;Connect Timeout=30");

        public static List<DropList> DropTipai = new List<DropList>
        {
            new DropList() {Name = " "},
            new DropList() {Name = "Maistas"},
            new DropList() {Name = "Chemija"},
            new DropList() {Name = "Elektronika"}
        };

        public static List<DropList> DropAutorizacija = new List<DropList>
        {
            new DropList() {Value = 0, Name = "Sandelininkas"},
            new DropList() {Value = 1, Name = "Pardavejas"},
            new DropList() {Value = 2, Name = "Administratorius"}
        };

        public static string ToMd5(string input)

        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static void ExitApp()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
       
    }
}
