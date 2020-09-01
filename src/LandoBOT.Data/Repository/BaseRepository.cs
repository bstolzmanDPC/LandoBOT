using System;
using System.IO;
using System.Data.SQLite;
using Dapper;

namespace LandoBOT.Data.Repository
{
	public class BaseRepository
	{
		private const string DBNAME = "bot.db";
		protected readonly SQLiteConnection _connection;

		public BaseRepository()
		{
			
			_connection = SQLiteConnection($@"{Environment.CurrentDirectory}/{DBNAME}");
			//TODO: check db existance
			//generate db structure if not existant
		}
		protected string DBPath
		{
			get => $@"{Environment.CurrentDirectory}/{DBNAME}";
		}

		private void DbHealthCheck()
		{
			if(File.Exists(DBPath)
			{
				try
				{
					_connection.Open();
				}
				catch(SQLiteException)
				{
					//TODO: log and handle
				}
			}
			else
			{
				//TODO create database
			}
		}
	}
}
