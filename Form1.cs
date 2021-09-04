using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Database_reader_for_MinskOblGas
{
    public partial class DatabaseReader : Form
    {
        public DatabaseReader()
        {
            InitializeComponent();
            comboBoxObject.SelectedIndex = 0;
            comboBoxSensorNumber.SelectedIndex = 0;

            //для устранения dataerror
            GridForViewData.DataError += new DataGridViewDataErrorEventHandler(GridforViewData_DataError);
        }
//**********************************************************************************************
//**********************************************************************************************
        string[] objects = { "Березино","Бобровичи","Борисов","Вилейка","Воложин","Дзержинск","Клецк",
                                "Княгинин","Копыль","Крупки","Логойск","Любань","Минское_РПУ","Молодечно",
                                "Мядель","Несвиж","Пуховичи","Руденск","Слуцк","Смолевичи","Солигорск",
                                "Стародороги","Столбцы","ТП_Березин","Узда","Червень" };
//**********************************************************************************************
//**********************************************************************************************
        private void DatabaseReader_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(600, 790);
        }
//**********************************************************************************************
//**********************************************************************************************
        private void buttonProtocol_Click(object sender, EventArgs e)
        {
        }
//**********************************************************************************************
//**********************************************************************************************

        private string QueryForObjectAndDate(string dateValue, string objectFromComboBox)
        {
            string query;
            query = "SELECT * FROM " + objectFromComboBox + " Where Date = '" + dateValue + "'";
            return query;
        }

//**********************************************************************************************
//**********************************************************************************************

        private string QueryForObjectAndPeriod(DateTimePicker dateValueMin, DateTimePicker dateValueMax, string objectFromComboBox)
        {
            string query = "";
            int i = 0;
            for (DateTime dt = dateValueMin.Value; dt <= dateValueMax.Value; dt = dt.AddDays(1))
            {
                if(i == 0)
                {
                    query += "SELECT * FROM " + objectFromComboBox + " Where Date = '" + dt.ToString("dd.MM.yy") + "' ";
                }
                else
                {
                    query += "UNION SELECT * FROM " + objectFromComboBox + " Where Date = '" + dt.ToString("dd.MM.yy") + "' ";
                    if(dt == dateValueMax.Value)
                    {
                        query += "ORDER by Date";
                    }
                }
                i++;
            }
            return query;
        }

//**********************************************************************************************
//**********************************************************************************************

        private string QueryForOnlyObject(string objectFromComboBox)
        {
            string query;
            query = "SELECT * FROM " + objectFromComboBox + " ORDER by Date";
            return query;
        }

//**********************************************************************************************
//**********************************************************************************************

        private string QueryForOnlyDate(string dateValue, string[] objects)
        {
            string query = "";
            int i = 0;
            foreach (string itemObject in objects)
            {
                if (i == 0)
                {
                    query += "SELECT '" + itemObject + "' as Object, * FROM " + itemObject + " where date = '" + dateValue + "' ";
                }
                else
                {
                    query += "UNION SELECT '" + itemObject + "' as Object, * FROM " + itemObject + " where Date = '" + dateValue + "' ";
                }
                i++;
            }
            return query;
        }

//**********************************************************************************************
//**********************************************************************************************

        private string QueryForOnlyPeriod(DateTimePicker dateValueMin, DateTimePicker dateValueMax, string[] objects)
        {
            string query = "";
            int i = 0;
            for (DateTime dt = dateValueMin.Value; dt <= dateValueMax.Value; dt = dt.AddDays(1))
            {
                foreach(string itemObject in objects)
                {
                    if (i == 0)
                    {
                        query += "SELECT '" + itemObject + "' as Object, * FROM " + itemObject + " where date = '" + dt.ToString("dd.MM.yy") + "' ";
                    }
                    else
                    {
                        query += "UNION SELECT '" + itemObject + "' as Object, * FROM " + itemObject + " where Date = '" + dt.ToString("dd.MM.yy") + "' ";
                        if (dt == dateValueMax.Value && itemObject == "Червень")
                        {
                            query += "ORDER by Date";
                        }
                    }
                    i++;
                }
            }
            return query;
        }

//**********************************************************************************************
//**********************************************************************************************

        private int dateDifference(DateTimePicker dateTo, DateTimePicker dateFrom)
        {
            DateTime dateBig = dateTo.Value;
            DateTime dateSmall = dateFrom.Value;
            TimeSpan result = dateBig - dateSmall;
            return result.Days;
        }

//**********************************************************************************************
//**********************************************************************************************

        private void sqlQueryAndFillingGridView()
        {
            string query;

            if (checkBoxObject.Checked == true)
            {
                if (checkBoxData.Checked == true)
                {
                    string dateValue = dateTime.Value.ToString("dd.MM.yy");
                    query = QueryForObjectAndDate(dateValue, comboBoxObject.Text);
                }
                else if (checkBoxPeriod.Checked == true)
                {
                    if (dateTimePeriodFrom.Value > dateTimePeriodTo.Value)
                    {
                        PrintErrors(Errors.Period);
                        query = "";
                        return;
                    }
                    else if (dateDifference(dateTimePeriodTo, dateTimePeriodFrom) > 500) //scale period > 500 days
                    {
                        PrintErrors(Errors.ScalePeriodYear);
                        query = "";
                        return;
                    }
                    query = QueryForObjectAndPeriod(dateTimePeriodFrom, dateTimePeriodTo, comboBoxObject.Text);
                }
                else
                {
                    query = QueryForOnlyObject(comboBoxObject.Text);
                }
                PrintErrors(Errors.Empty);
                ConnectionAndFillingGridView(query);
            }
            else
            {
                if (checkBoxData.Checked == true)
                {
                    string dateValue = dateTime.Value.ToString("dd.MM.yy");
                    query = QueryForOnlyDate(dateValue, objects);
                }
                else if (checkBoxPeriod.Checked == true)
                {
                    if (dateTimePeriodFrom.Value > dateTimePeriodTo.Value)
                    {
                        PrintErrors(Errors.Period);
                        query = "";
                        return;
                    }
                    else if( dateDifference(dateTimePeriodTo, dateTimePeriodFrom) > 15 ) //scale period > 15 days
                    {
                        PrintErrors(Errors.ScalePeriodHalfMonth);
                        query = "";
                        return;
                    }
                    query = QueryForOnlyPeriod(dateTimePeriodFrom, dateTimePeriodTo, objects);
                }
                else
                {
                    query = "";
                    PrintErrors(Errors.WithoutSettings);
                    return;
                }
                PrintErrors(Errors.Empty);
                ConnectionAndFillingGridView(query);
            }
        }
//**********************************************************************************************
//**********************************************************************************************
        private void ConnectionAndFillingGridView(string query)
        {
            SQLiteConnection connection =
            //new SQLiteConnection(@"data source=D:\программирование\C#\database\MOG.sq3");
            new SQLiteConnection(@"data source=MOG.sq3"); //в одной папке с программой
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridForViewData.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                PrintErrors(Errors.EmptyTable);
            }
            else labelErrorDescription.Text += " Количество поверенных манометров: " + dt.Rows.Count.ToString();
        }
//**********************************************************************************************
//**********************************************************************************************
        private enum Errors : int
        {
            Empty,
            WithoutSettings,
            DataBase,
            Period,
            DataBaseNotFound,
            EmptyTable,
            ScalePeriodHalfMonth,
            ScalePeriodYear,
        }
        private void PrintErrors(Errors errors)
        {
            switch (errors)
            {
                case Errors.Empty:
                    labelErrorDescription.Text = "Ошибок нет.";
                    break;
                case Errors.WithoutSettings:
                    labelErrorDescription.Text = "Для формирования таблицы необходима настройка";
                    break;
                case Errors.DataBase:
                    labelErrorDescription.Text = "Ошибка Базы данных  -> неверный тип данных столбца таблицы";
                    break;
                case Errors.Period:
                    labelErrorDescription.Text = "В настройках периода верхняя дата должна быть меньше нижней";
                    break;
                case Errors.DataBaseNotFound:
                    labelErrorDescription.Text = "База данных не найдена";
                    break;
                case Errors.EmptyTable:
                    labelErrorDescription.Text = "По данному запросу ничего не найдено";
                    break;
                case Errors.ScalePeriodHalfMonth:
                    labelErrorDescription.Text = "Настройка диапазона времени не должна превышать 15 дней";
                    break;
                case Errors.ScalePeriodYear:
                    labelErrorDescription.Text = "Настройка диапазона времени не должна превышать 500 дней (1 год 5 месяцев)";
                    break;
            }
        }
//**********************************************************************************************
//**********************************************************************************************
        private void buttonTable_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQueryAndFillingGridView();
            }
            catch (Exception error)
            {
                PrintErrors(Errors.DataBaseNotFound);
                labelErrorDescription.Text += "\n" + error.Message;
            }            
        }
//**********************************************************************************************
//**********************************************************************************************
        private void GridforViewData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            PrintErrors(Errors.DataBase);
        }
//**********************************************************************************************
//**********************************************************************************************
        private void GridForViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
//**********************************************************************************************
//**********************************************************************************************
        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxData.Checked == true && checkBoxPeriod.Checked == true)
            {
                checkBoxPeriod.Checked = false;
            }
        }
//**********************************************************************************************
//**********************************************************************************************
        private void checkBoxPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxData.Checked == true && checkBoxPeriod.Checked == true)
            {
                checkBoxData.Checked = false;
            }
        }
//**********************************************************************************************
//**********************************************************************************************
    }
}