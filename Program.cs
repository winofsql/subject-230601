using System.Data.Odbc;
using System.Diagnostics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("こんにちは世界");
            Debug.WriteLine("こんにちは世界");

            OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();
            builder.Driver = "MySQL ODBC 8.0 Unicode Driver";

            // 接続用のパラメータを追加
            builder.Add("server", "localhost");
            builder.Add("database", "lightbox2");
            builder.Add("uid", "root");
            builder.Add("pwd", "");

            // 接続の作成
            OdbcConnection myCon = new OdbcConnection();

            // MySQL の接続準備完了
            myCon.ConnectionString = builder.ConnectionString;

            // MySQL に接続
            myCon.Open();

            myCon.Close();
        }
    }
}