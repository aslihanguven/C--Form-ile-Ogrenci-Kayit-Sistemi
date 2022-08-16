using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Data.Sqlite;
using System.Windows.Forms;

namespace Öğrenci_Kaydetmek
{
    public class sqliteClass
    {
        SqliteConnection sqlCon = new SqliteConnection();

        public sqliteClass(string dbPath, string dbPass) //Initialize Class
        {
            sqlCon.ConnectionString = string.Format(
                "Data Source={0};" +
                "Version=3;" +
                "UseUTF8Encoding=True;" +
                (dbPass == "" ? "" : "Password=" + dbPass + ";"),
                dbPath);

            sqlCon.Open();
        }

        ~sqliteClass() //Finalize Class
        {
            sqlCon.Close();
        }

        public DataGridViewRow[] getAllRecords(string tableName)
        {

            var resultRows = new List<DataGridViewRow>();

            SqliteCommand sqlCom = new SqliteCommand(sqlCon);
            sqlCom.CommandText = "SELECT rowid,* FROM " + tableName + " WHERE 1";
            SqliteDataReader sqlDat = sqlCom.ExecuteReader();

            while (sqlDat.Read())
            {
                var row = new DataGridViewRow();

                for (int sut = 1; sut < sqlDat.FieldCount; sut++)
                {
                    string record = sqlDat[sut].ToString();

                    if (record.Contains('-') && record.Length == 10) //Date text
                    {
                        record = DateTime.Parse(record).ToString("dd.MM.yyyy");
                    }

                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = record });
                }

                row.Tag = sqlDat["rowid"].ToString();
                resultRows.Add(row);
            }

            return resultRows.ToArray();
        }

        public bool insertRow(string tableName, string[] values) {

            SqliteCommand sqlCom = new SqliteCommand(sqlCon);
            sqlCom.CommandText = String.Format("INSERT INTO " + tableName + " VALUES ('{0}')", string.Join("','", values));
           
            if (sqlCom.ExecuteNonQuery() > 0)
            {
                return true;
            }

            return false;
        }

        public bool updateRow(string tableName, string[] values, string expres)
        {

            var columnsName = this.getFieldsName(tableName);

            if (columnsName.Length == 0) { return false; }

            for (int i = 0; i < columnsName.Length; i++)
            {
                columnsName[i] = columnsName[i] + "='" + values[i] + "'";
            }

            SqliteCommand sqlCom = new SqliteCommand(sqlCon);
            sqlCom.CommandText = String.Format("UPDATE " + tableName + " SET {0} WHERE {1}", string.Join(",",columnsName), expres);

            if (sqlCom.ExecuteNonQuery() > 0)
            {
                return true;
            }

            return false;
        }

        public bool deleteRow(string tableName, int rowid)
        {

            SqliteCommand sqlCom = new SqliteCommand(sqlCon);
            sqlCom.CommandText = String.Format("DELETE FROM " + tableName + " WHERE rowid={0}", rowid.ToString());

            if (sqlCom.ExecuteNonQuery() > 0)
            {
                return true;
            }

            return false;
        }

        public string[] getFieldsName(string tableName)
        {

            var columnsName = new List<string>();

            SqliteCommand sqlCom = new SqliteCommand(sqlCon);
            sqlCom.CommandText = "SELECT * FROM " + tableName + " WHERE 1";
            SqliteDataReader sqlDat = sqlCom.ExecuteReader();

            for(int i=0; i < sqlDat.FieldCount; i++)
            {
                columnsName.Add(sqlDat.GetName(i));
            }

            return columnsName.ToArray();
        }

    }
}
