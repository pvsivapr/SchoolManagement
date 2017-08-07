using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

#region Created by Balaraju

namespace MEDU.SQLiteDB.Connection
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

#endregion
