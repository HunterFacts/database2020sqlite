using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD20202SqliteMK
{
    class DatabaseService
    {
        private const string dbFileName = "database.db";
        public bool CreateDatabase()
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                var m_dbConn = new SQLiteConnection();
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                var tableEmployee = "CREATE TABLE employee(id INTEGER PRIMARY KEY, fio STRING, mail STRING, act INTEGER, FOREIGN KEY(act) references act(id)); ";
                var tableAct = " CREATE TABLE act(id INTEGER PRIMARY KEY, actNumber INTEGER, status BOOL, accountDeviceAct INTEGER, FOREIGN KEY(accountDeviceAct) references accountDeviceAct(id)); ";
                var tableAccountDeviceAct = " CREATE TABLE accountDeviceAct(id INTEGER PRIMARY KEY, number INTEGER, name string);";           
                SQLiteCommand Command = new SQLiteCommand(tableEmployee + tableAct + tableAccountDeviceAct, m_dbConn);
                m_dbConn.Open();
                Command.ExecuteNonQuery();
                m_dbConn.Close();             
                return true;
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
