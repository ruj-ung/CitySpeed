using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CitySpeedLimit.Model;

namespace CitySpeedLimit.ViewModel
{
    public class MainViewModel
    {
        public List<Item> ItemList { get; set; }
        public List<Item> ItemList2 { get; set; }
        public MainViewModel()
        {
            ItemList = new List<Item>();
            ItemList2 = new List<Item>();
            FillList();
        }

        private void FillList()
        {
            ItemList.Add(
                new Item
                {
                    Tag = 0,
                    Description = "Downtown / Central Business District street",
                    Checked = false
                }); ; ;
            ItemList.Add(
                new Item
                {
                    Tag = 1,
                    Description = "Retail corridor",
                    Checked = false
                });

            ItemList2.Add(
                new Item
                {
                    Tag = 0,
                    Description = "Downtown / Central Business District street",
                    Checked = false
                }); ; ;
            ItemList2.Add(
                new Item
                {
                    Tag = 1,
                    Description = "Retail corridor",
                    Checked = false
                });
        }
        internal void FillListFromDB()
        {
            DataTable dt = new DataTable();
            var fileName = @"CheckList.xlsx";
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=YES;TypeGuessRows=0;ImportMixedTypes=Text\""; ;
            using (var conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM [" + sheets.Rows[0]["TABLE_NAME"].ToString() + "] ";

                        var adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

                DataRow[] rows = dt.Select("Category=1");
                foreach (DataRow row in rows)
                {
                    ItemList.Add(
                    new Item
                    {
                        Tag = int.Parse(row.ItemArray[0].ToString()),
                        Description = row.ItemArray[1].ToString(),
                        Checked = false
                    });

                }
                rows = dt.Select("Category=2");
                foreach (DataRow row in rows)
                {
                    ItemList2.Add(
                    new Item
                    {
                        Tag = int.Parse(row.ItemArray[0].ToString()),
                        Description = row.ItemArray[1].ToString(),
                        Checked = false
                    });

                }

            }
        }
    }
}
