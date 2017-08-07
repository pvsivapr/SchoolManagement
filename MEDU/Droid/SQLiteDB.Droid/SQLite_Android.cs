using MEDU.SQLiteDB.Connection;
using MEDU.Droid.SQLite_Android;
using System.IO;
using SQLite.Net;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace MEDU.Droid.SQLite_Android
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android()
		{ }

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "MEDU.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			// Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var conn = new SQLiteConnection(plat, path);
			// Return the database connection
			return conn;
		}
	}
}