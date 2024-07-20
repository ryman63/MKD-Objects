using Microsoft.Office.Interop.Excel;
using Npgsql;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace MDKObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var FormInputMKD = new InputMKD();
                FormInputMKD.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReport1_Click(object sender, EventArgs e)
        {
            using (ExcelFile file = new ExcelFile())
            {
                file.Open(Path.Combine(Directory.GetCurrentDirectory(), textBoxReport1FileName.Text));

                var source = file._excel.Workbooks.Open(Path.Combine(Directory.GetCurrentDirectory(), "־בנאחצû מעק¸עמג (ֵֽ ׂ׀־ְֳׂÜ)/ֿנטלונםûי מעקוע 1.xlsx"));

                file.Copy(source.Worksheets[1]);

                source.Close();

                var ListCountries = GiveAllCountriesDistinct();

                const int PrimaryRow = 8;

                for (int i = 0; i < ListCountries.Count; i++)
                {
                    file.Set("A", PrimaryRow + i, ListCountries[i]);
                    file.Set("B", PrimaryRow + i, GiveCountPermissionCurrentToDate(ListCountries[i]));
                    file.Set("C", PrimaryRow + i, GiveSumSquareCurrentToDate(ListCountries[i]));
                    file.Set("D", PrimaryRow + i, GiveCountPermissionSuspendedToDate(ListCountries[i]));
                    file.Set("E", PrimaryRow + i, GiveSumSquareSuspendedToDate(ListCountries[i]));
                    file.Set("F", PrimaryRow + i, GiveCountCurrentObjects());
                    file.Set("G", PrimaryRow + i, GiveSumSquareCurrent());
                    file.Set("H", PrimaryRow + i, GiveCountSuspendedObjects());
                    file.Set("I", PrimaryRow + i, GiveSumSquareSuspended());
                    file.Set("J", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2023,1,1)));
                    file.Set("K", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2024, 1, 1)));
                    file.Set("L", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2025, 1, 1)));
                    file.Set("M", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2026, 1, 1)));
                    file.Set("N", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2027, 1, 1)));
                    file.Set("O", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2028, 1, 1)));
                    file.Set("P", PrimaryRow + i, GiveCountCurrentAndSuspended());
                    file.Set("Q", PrimaryRow + i, GiveSumSquareCurrentAndSuspended());
                    file.Set("R", PrimaryRow + i, GiveCountSuspendedObjects());
                    file.Set("S", PrimaryRow + i, GiveSumSquareSuspended());
                }

                file.Save();
            }
        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            using (ExcelFile file = new ExcelFile())
            {
                file.Open(Path.Combine(Directory.GetCurrentDirectory(), textBoxReport2FileName.Text));

                var source = file._excel.Workbooks.Open(Path.Combine(Directory.GetCurrentDirectory(), "־בנאחצû מעק¸עמג (ֵֽ ׂ׀־ְֳׂÜ)/ֿנטלונםûי מעקוע 2.xlsx"));

                file.Copy(source.Worksheets[1]);

                source.Close();

                var ListCountries = GiveAllCountriesDistinct();

                const int PrimaryRow = 8;

                for (int i = 0; i < ListCountries.Count; i++)
                {
                    file.Set("A", PrimaryRow + i, ListCountries[i]);
                    file.Set("B", PrimaryRow + i, GiveCountPermissionCurrentToDate(ListCountries[i]));
                    file.Set("C", PrimaryRow + i, GiveSumSquareCurrentToDate(ListCountries[i]));
                    file.Set("D", PrimaryRow + i, GiveCountPermissionSuspendedToDate(ListCountries[i]));
                    file.Set("E", PrimaryRow + i, GiveSumSquareSuspendedToDate(ListCountries[i]));
                    file.Set("F", PrimaryRow + i, GiveCountCurrentObjects());
                    file.Set("G", PrimaryRow + i, GiveSumSquareCurrent());
                    file.Set("H", PrimaryRow + i, GiveCountSuspendedObjects());
                    file.Set("I", PrimaryRow + i, GiveSumSquareSuspended());
                    file.Set("J", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2023, 1, 1)));
                    file.Set("K", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2024, 1, 1)));
                    file.Set("L", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2025, 1, 1)));
                    file.Set("M", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2026, 1, 1)));
                    file.Set("N", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2027, 1, 1)));
                    file.Set("O", PrimaryRow + i, GiveSumSquareToDate(new DateTime(2028, 1, 1)));
                    file.Set("P", PrimaryRow + i, GiveCountCurrentAndSuspended());
                    file.Set("Q", PrimaryRow + i, GiveSumSquareCurrentAndSuspended());
                    file.Set("R", PrimaryRow + i, GiveCountSuspendedObjects());
                    file.Set("S", PrimaryRow + i, GiveSumSquareSuspended());
                }

                file.Save();
            }
        }

        private List<string> GiveAllCountriesDistinct()
        {
            var List = new List<string>();

            var cmd = new NpgsqlCommand("SELECT distinct object_country FROM current union SELECT distinct object_country from suspended", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    List.Add(dataReader[0].ToString());


            }
            dataReader.Close();
            return List;
        }

        private string GiveCountPermissionCurrentToDate(string Country)
        {
            string result = string.Empty;
            using var cmd = new NpgsqlCommand("SELECT COUNT(object_name) FROM current WHERE object_country = $1 " +
                "AND date_give_permission > '01.01.2023'", Program.pgConnection)
            {
                Parameters = { new() { Value = Country } }
            };
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = dataReader[0].ToString();
            }
            dataReader.Close();
            return result;
        }

        private double GiveSumSquareCurrentToDate(string Country)
        {
            double result = 0;
            using var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM current WHERE object_country = $1 " +
                "AND date_give_permission > '01.01.2023'", Program.pgConnection)
            {
                Parameters = { new() { Value = Country } }
            };
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = Convert.ToDouble(dataReader[0]);
            }
            dataReader.Close();
            return result;
        }

        private string GiveCountPermissionSuspendedToDate(string Country)
        {
            string result = string.Empty;
            using var cmd = new NpgsqlCommand("SELECT COUNT(object_name) FROM suspended WHERE object_country = $1 " +
                "AND date_give_permission > '01.01.2023'", Program.pgConnection)
            {
                Parameters = { new() { Value = Country } }
            };
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = dataReader[0].ToString();
            }
            dataReader.Close();
            return result;
        }

        private double GiveSumSquareSuspendedToDate(string Country)
        {
            double result = 0;
            using var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM suspended WHERE object_country = $1 " +
                "AND date_give_permission > '01.01.2023'", Program.pgConnection)
            {
                Parameters = { new() { Value = Country } }
            };
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = Convert.ToDouble(dataReader[0]);
            }
            dataReader.Close();
            return result;
        }

        private string GiveCountCurrentObjects()
        {
            string result = string.Empty;
            var cmd = new NpgsqlCommand("SELECT COUNT(object_name) FROM current", Program.pgConnection);
  
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = dataReader[0].ToString();
            }
            dataReader.Close();
            return result;
        }

        private double GiveSumSquareCurrent()
        {
            double result = 0;
            var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM current", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = Convert.ToDouble(dataReader[0]);
            }
            dataReader.Close();
            return result;
        }

        private string GiveCountSuspendedObjects()
        {
            string result = string.Empty;
            var cmd = new NpgsqlCommand("SELECT COUNT(object_name) FROM suspended", Program.pgConnection);

            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = dataReader[0].ToString();
            }
            dataReader.Close();
            return result;
        }

        private double GiveSumSquareSuspended()
        {
            double result = 0;
            var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM suspended", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = Convert.ToDouble(dataReader[0]);
            }
            dataReader.Close();
            return result;
        }

        private double GiveSumSquareToDate(DateTime Date)
        {
            double result = 0;
            using var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM current WHERE case when date_extend IS NULL then date_expiration > $1 else date_extend > $1 end", Program.pgConnection)
            {
                Parameters = { new() { Value = Date } }
            };
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = Convert.ToDouble(dataReader[0]);
            }
            dataReader.Close();
            return result;
        }

        private string GiveCountCurrentAndSuspended()
        {
            string result = string.Empty;
            var cmd = new NpgsqlCommand("SELECT (select count(*) from current) + (select count(*) from suspended) as total_rows", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    result = dataReader[0].ToString();
            }
            dataReader.Close();
            return result;
        }

        private int GiveSumSquareCurrentAndSuspended()
        {
            int sum = 0;
            var cmd = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM current", Program.pgConnection);

            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                if (!dataReader.IsDBNull(0))
                    sum += Convert.ToInt32(dataReader[0]);
            }
            dataReader.Close();
            var cmd2 = new NpgsqlCommand("SELECT SUM(general_square_mkd) FROM suspended", Program.pgConnection);

            var dataReader2 = cmd2.ExecuteReader();
            if (dataReader2.Read())
            {
                if (dataReader[0] != DBNull.Value)
                {

                    sum += Convert.ToInt32(dataReader2[0]);
                }
                    
            }
            dataReader2.Close();
            return sum;
        }
    }
}