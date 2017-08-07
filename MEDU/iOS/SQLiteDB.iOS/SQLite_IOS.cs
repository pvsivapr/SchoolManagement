using System;
using System.IO;
using Xamarin.Forms;
using MEDU.SQLiteDB.Connection;
using SQLite.Net;
using MEDU.iOS.SQLiteDB_IOS;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace MEDU.iOS.SQLiteDB_IOS
{

	public class SQLite_IOS : ISQLite
	{
		public SQLite_IOS() { }

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "MEDU.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			// Create the connection
			var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var conn = new SQLiteConnection(plat, path);
			// Return the database connection
			return conn;
		}
	}
}