using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SandelioSistema
{
    class Cnst
    {
        public static int alevel = -1;

        public static string User;

        public static SqlConnection SqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Igno dokumentai\Programavimas\Programs\SandelioSistema\Database SQL\SandelioDB.mdf;Integrated Security=True;Connect Timeout=30");

        public static List<DropList> DropTipai = new List<DropList>
        {
            new DropList() {Name = " "},
            new DropList() {Name = "Vaizdo plokštės"},
            new DropList() {Name = "Procesoriai"},
            new DropList() {Name = "Pagrindinės plokštės"},
            new DropList() {Name = "Aušintuvai"},
            new DropList() {Name = "Operatyvinė atmintis"},
            new DropList() {Name = "Garso Plokštės"},
            new DropList() {Name = "Maitinimo blokai"},
            new DropList() {Name = "Vidiniai duomenų kaupikliai (HDD, SSD)"}

        };

        public static List<DropList> DropAutorizacija = new List<DropList>
        {
            new DropList() {Value = 0, Name = "Pardavėjas"},
            new DropList() {Value = 1, Name = "Sandėlinikas"},
            new DropList() {Value = 2, Name = "Administratorius"}
        };

        public static string ToMd5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            
            return sb.ToString();
        }

        public static void ExitApp()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }       
    }
}
