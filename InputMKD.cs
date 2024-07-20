using Microsoft.Office.Interop.Excel;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDKObjects
{
    public partial class InputMKD : Form
    {
        public InputMKD()
        {
            InitializeComponent();
        }

        private bool CheckTextBoxes()
        {
            if (radioButtonCurrent.Checked)
            {
                if (string.IsNullOrEmpty(textBoxNameObject.Text)
                || string.IsNullOrEmpty(textBoxContractNumber.Text)
                || string.IsNullOrEmpty(textBoxCountry.Text)
                || string.IsNullOrEmpty(textBoxStreet.Text)
                || string.IsNullOrEmpty(textBoxHouseNumber.Text)
                || string.IsNullOrEmpty(textBoxPercantage.Text)
                || string.IsNullOrEmpty(textBoxBuildingStage.Text)
                || string.IsNullOrEmpty(textBoxNameOrganization.Text)
                || string.IsNullOrEmpty(textBoxSquareMKD.Text))
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxNameObject.Text)
                || string.IsNullOrEmpty(textBoxContractNumber.Text)
                || string.IsNullOrEmpty(textBoxCountry.Text)
                || string.IsNullOrEmpty(textBoxStreet.Text)
                || string.IsNullOrEmpty(textBoxHouseNumber.Text)
                || string.IsNullOrEmpty(textBoxPercantage.Text)
                || string.IsNullOrEmpty(textBoxNameOrganization.Text)
                || string.IsNullOrEmpty(textBoxSquareMKD.Text))
                {
                    return false;
                }
                return true;
            }
            
        }

        private void LoadGridViews()
        {
            var cmd = new NpgsqlCommand("SELECT object_name as \"Наименование объекта\", contract_number as \"Номер договора\", date_give_permission as \"Дата выдачи разрешения\", date_expiration as \"Дата окончания срока\", date_extend as \"Продлено до\", object_country as \"Город\", object_street as \"Улица\", object_number_house as \"Номер дома\", building_stage as \"Этап строительства\", percantage_ready as \"Процент готовности\", organization_name as \"Название организации\", general_square_mkd as \"Общая площадь МКД\", notes as \"Заметки\" FROM current;", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            var dataTable = new System.Data.DataTable();
            dataTable.Load(dataReader);
            dataGridViewCurrent.DataSource = dataTable;

            var cmd2 = new NpgsqlCommand("SELECT object_name as \"Наименование объекта\", contract_number as \"Номер договора\", date_give_permission as \"Дата выдачи разрешения\", date_expiration as \"Дата окончания срока\", object_country as \"Город\", object_street as \"Улица\", object_number_house as \"Номер дома\", percantage_ready as \"Процент готовности\", organization_name as \"Название организации\", general_square_mkd as \"Общая площадь МКД\", notes as \"Заметки\" FROM suspended", Program.pgConnection);
            var dataReader2 = cmd2.ExecuteReader();
            var dataTable2 = new System.Data.DataTable();
            dataTable2.Load(dataReader2);
            dataGridViewSuspended.DataSource = dataTable2;


        }

        private async void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextBoxes())
                {
                    if (radioButtonCurrent.Checked)
                    {

                        await using var cmd = new NpgsqlCommand("INSERT INTO current " +
                                "(object_name, " +
                                "contract_number, " +
                                "date_give_permission, " +
                                "date_expiration, " +
                                "date_extend, " +
                                "object_country, " +
                                "object_street, " +
                                "object_number_house, " +
                                "building_stage, " +
                                "percantage_ready, " +
                                "organization_name, " +
                                "general_square_mkd, " +
                                "notes) VALUES ($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13)", Program.pgConnection)
                        {
                            Parameters =
                            {
                                new() { Value = textBoxNameObject.Text },
                                new() { Value = Convert.ToInt32(textBoxContractNumber.Text) },
                                new() { Value = DateGivePermission.Value },
                                new() { Value = DateExpiration.Value },
                                new() { Value = DateExtend.Value },
                                new() { Value = textBoxCountry.Text },
                                new() { Value = textBoxStreet.Text },
                                new() { Value = Convert.ToInt32(textBoxHouseNumber.Text) },
                                new() { Value = textBoxBuildingStage.Text },
                                new() { Value = Convert.ToInt32(textBoxPercantage.Text) },
                                new() { Value = textBoxNameOrganization.Text },
                                new() { Value = Convert.ToDouble(textBoxSquareMKD.Text) },
                                new() { Value = textBoxNotes.Text },
                            }
                        };

                        await cmd.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        await using var cmd = new NpgsqlCommand("INSERT INTO suspended " +
                                "(object_name, " +
                                "contract_number, " +
                                "date_give_permission, " +
                                "date_expiration, " +
                                "object_country, " +
                                "object_street, " +
                                "object_number_house, " +
                                "percantage_ready, " +
                                "organization_name, " +
                                "general_square_mkd, " +
                                "notes) VALUES ($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11)", Program.pgConnection)
                        {
                            Parameters =
                            {
                                new() { Value = textBoxNameObject.Text },
                                new() { Value = Convert.ToInt32(textBoxContractNumber.Text) },
                                new() { Value = DateGivePermission.Value },
                                new() { Value = DateExpiration.Value },
                                new() { Value = textBoxCountry.Text },
                                new() { Value = textBoxStreet.Text },
                                new() { Value = Convert.ToInt32(textBoxHouseNumber.Text) },
                                new() { Value = Convert.ToInt32(textBoxPercantage.Text) },
                                new() { Value = textBoxNameOrganization.Text },
                                new() { Value = Convert.ToDouble(textBoxSquareMKD.Text) },
                                new() { Value = textBoxNotes.Text },
                            }
                        };

                        await cmd.ExecuteNonQueryAsync();
                    }
                    LoadGridViews();
                }
                else
                {
                    MessageBox.Show("Заполните важные поля для ввода", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void radioButtonCurrent_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = radioButtonCurrent.Checked;
            if(checkBox1.Checked)
                DateExtend.Visible = radioButtonCurrent.Checked;
            LabelBuildingStage.Visible = radioButtonCurrent.Checked;
            textBoxBuildingStage.Visible = radioButtonCurrent.Checked;
            checkBox1.Visible = radioButtonCurrent.Checked;
            ClearTextBoxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DateExtend.Visible = checkBox1.Checked;
        }

        private void textBoxBuildingStage_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelBuildingStage_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateExtend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InputMKD_Load(object sender, EventArgs e)
        {
            LoadGridViews();
        }

        private async void buttonChange_Click(object sender, EventArgs e)
        {
            if(dataGridViewCurrent.CurrentRow != null || dataGridViewSuspended.CurrentRow != null)
            {
                if (CheckTextBoxes())
                {
                    if (radioButtonCurrent.Checked)
                    {

                        await using var cmd = new NpgsqlCommand("UPDATE current SET " +
                                "object_name = $1, " +
                                "contract_number = $2, " +
                                "date_give_permission = $3, " +
                                "date_expiration = $4, " +
                                "date_extend = $5, " +
                                "object_country = $6, " +
                                "object_street = $7, " +
                                "object_number_house = $8, " +
                                "building_stage = $9, " +
                                "percantage_ready = $10, " +
                                "organization_name = $11, " +
                                "general_square_mkd = $12, " +
                                "notes = $13" +
                                " WHERE Id_mkd = $14", Program.pgConnection)
                        {
                            Parameters =
                            {
                                new() { Value = textBoxNameObject.Text },
                                new() { Value = Convert.ToInt32(textBoxContractNumber.Text) },
                                new() { Value = DateGivePermission.Value },
                                new() { Value = DateExpiration.Value },
                                new() { Value = DateExtend.Value },
                                new() { Value = textBoxCountry.Text },
                                new() { Value = textBoxStreet.Text },
                                new() { Value = Convert.ToInt32(textBoxHouseNumber.Text) },
                                new() { Value = textBoxBuildingStage.Text },
                                new() { Value = Convert.ToInt32(textBoxPercantage.Text) },
                                new() { Value = textBoxNameOrganization.Text },
                                new() { Value = Convert.ToDouble(textBoxSquareMKD.Text) },
                                new() { Value = textBoxNotes.Text },
                                new() {Value = Convert.ToInt32(textBoxId.Text) },
                            }
                        };

                        await cmd.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        await using var cmd = new NpgsqlCommand("UPDATE current SET " +
                                 "object_name = $1, " +
                                 "contract_number = $2, " +
                                 "date_give_permission = $3, " +
                                 "date_expiration = $4, " +
                                 "object_country = $5, " +
                                 "object_street = $6, " +
                                 "object_number_house = $7, " +
                                 "percantage_ready = $8, " +
                                 "organization_name = $9, " +
                                 "general_square_mkd = $10, " +
                                 "notes = $11" +
                                 " WHERE Id_mkd = $12", Program.pgConnection)
                        {
                            Parameters =
                            {
                                new() { Value = textBoxNameObject.Text },
                                new() { Value = Convert.ToInt32(textBoxContractNumber.Text) },
                                new() { Value = DateGivePermission.Value },
                                new() { Value = DateExpiration.Value },
                                new() { Value = textBoxCountry.Text },
                                new() { Value = textBoxStreet.Text },
                                new() { Value = Convert.ToInt32(textBoxHouseNumber.Text) },
                                new() { Value = Convert.ToInt32(textBoxPercantage.Text) },
                                new() { Value = textBoxNameOrganization.Text },
                                new() { Value = Convert.ToDouble(textBoxSquareMKD.Text) },
                                new() { Value = textBoxNotes.Text },
                                new() {Value = Convert.ToInt32(textBoxId.Text) },
                            }
                        };

                        await cmd.ExecuteNonQueryAsync();
                    }
                    LoadGridViews();
                }
                else
                {
                    MessageBox.Show("Заполните важные поля для ввода", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку из таблицы", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurrent.CurrentRow != null || dataGridViewSuspended.CurrentRow != null)
            {
                if(dataGridViewCurrent.CurrentRow != null)
                {
                    using var cmd = new NpgsqlCommand("DELETE FROM current WHERE id_mkd = ($1)", Program.pgConnection) 
                    {
                        Parameters = { new() { Value = Convert.ToInt32(dataGridViewCurrent.CurrentRow.Cells[0].Value) } } 
                    };
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    using var cmd = new NpgsqlCommand("DELETE FROM suspended WHERE id_mkd = ($1)", Program.pgConnection)
                    {
                        Parameters = { new() { Value = Convert.ToInt32(dataGridViewSuspended.CurrentRow.Cells[0].Value) } }
                    };
                    cmd.ExecuteNonQuery();
                }
                LoadGridViews();
            }
            else
            {
                MessageBox.Show("Выберите строку из таблицы", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCurrent_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewSuspended_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            textBoxId.Text = string.Empty;
            textBoxNameObject.Text = string.Empty;
            textBoxContractNumber.Text = string.Empty;
            DateGivePermission.Value = DateTime.Now;
            DateExpiration.Value = DateTime.Now;
            DateExtend.Value = DateTime.Now;
            textBoxCountry.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            textBoxHouseNumber.Text = string.Empty;
            textBoxBuildingStage.Text = string.Empty;
            textBoxPercantage.Text = string.Empty;
            textBoxNameOrganization.Text = string.Empty;
            textBoxSquareMKD.Text = string.Empty;
            textBoxNotes.Text = string.Empty;

            dataGridViewCurrent.ClearSelection();
            dataGridViewSuspended.ClearSelection();
        }

        private void dataGridViewCurrent_SelectionChanged(object sender, EventArgs e)
        {
            radioButtonCurrent.Checked = true;
            dataGridViewSuspended.ClearSelection();
            var cmd = new NpgsqlCommand("SELECT * FROM current", Program.pgConnection);
            var dataReader = cmd.ExecuteReader();
            var dataTable = new System.Data.DataTable();
            dataTable.Load(dataReader);

            if (dataTable.Rows.Count > 0)
            {
                textBoxId.Text = dataTable.Rows[0][0].ToString();
                textBoxNameObject.Text = dataTable.Rows[0][1].ToString();
                textBoxContractNumber.Text = dataTable.Rows[0][2].ToString();
                DateGivePermission.Value = Convert.ToDateTime(dataTable.Rows[0][3]);
                DateExpiration.Value = Convert.ToDateTime(dataTable.Rows[0][4]);
                DateExtend.Value = Convert.ToDateTime(dataTable.Rows[0][5]);
                textBoxCountry.Text = dataTable.Rows[0][6].ToString();
                textBoxStreet.Text = dataTable.Rows[0][7].ToString();
                textBoxHouseNumber.Text = dataTable.Rows[0][8].ToString();
                textBoxBuildingStage.Text = dataTable.Rows[0][9].ToString();
                textBoxPercantage.Text = dataTable.Rows[0][10].ToString();
                textBoxNameOrganization.Text = dataTable.Rows[0][11].ToString();
                textBoxSquareMKD.Text = dataTable.Rows[0][12].ToString();
                groupBoxNotes.Text = dataTable.Rows[0][13].ToString();
            }

        }

        private void dataGridViewSuspended_SelectionChanged(object sender, EventArgs e)
        {
            radioButtonSuspended.Checked = true;
            dataGridViewCurrent.ClearSelection();
            var cmd2 = new NpgsqlCommand("SELECT * FROM suspended", Program.pgConnection);
            var dataReader2 = cmd2.ExecuteReader();
            var dataTable2 = new System.Data.DataTable();
            dataTable2.Load(dataReader2);
            if (dataTable2.Rows.Count > 0)
            {
                textBoxId.Text = dataTable2.Rows[0][0].ToString();
                textBoxNameObject.Text = dataTable2.Rows[0][1].ToString();
                textBoxContractNumber.Text = dataTable2.Rows[0][2].ToString();
                DateGivePermission.Value = Convert.ToDateTime(dataTable2.Rows[0][3]);
                DateExpiration.Value = Convert.ToDateTime(dataTable2.Rows[0][4]);
                textBoxCountry.Text = dataTable2.Rows[0][5].ToString();
                textBoxStreet.Text = dataTable2.Rows[0][6].ToString();
                textBoxHouseNumber.Text = dataTable2.Rows[0][7].ToString();
                textBoxPercantage.Text = dataTable2.Rows[0][8].ToString();
                textBoxNameOrganization.Text = dataTable2.Rows[0][9].ToString();
                textBoxSquareMKD.Text = dataTable2.Rows[0][10].ToString();
                groupBoxNotes.Text = dataTable2.Rows[0][11].ToString();
            }

        }
    }
}
