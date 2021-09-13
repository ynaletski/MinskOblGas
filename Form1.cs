using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Database_reader_for_MinskOblGas
{
    public partial class DatabaseReader : Form
    {
        Excel.Application excelApp;

        public DatabaseReader()
        {
            InitializeComponent();
            comboBoxObject.SelectedIndex = 0;

            //для устранения dataerror
            GridForViewData.DataError += new DataGridViewDataErrorEventHandler(GridforViewData_DataError);

            GridForViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
//**********************************************************************************************
//**********************************************************************************************
        string[] objects = { "Березино","Бобровичи","Борисов","Вилейка","Воложин","Дзержинск","Клецк",
                                "Княгинин","Копыль","Крупки","Логойск","Любань","Минское_РПУ","Молодечно",
                                "Мядель","Несвиж","Пуховичи","Руденск","Слуцк","Смолевичи","Солигорск",
                                "Стародороги","Столбцы","ТП_Березин","Узда","Червень" };
//**********************************************************************************************
//**********************************************************************************************
        string[] belongOfObjects = { "Березинскому РГС","Бобровичскому РГС","ПУ Борисовгаз","Вилейскому РГС",
                                        "Воложинскому РГС","ПУ Дзержинскгаз","Клецкому РГС","Княгининскому ГНС",
                                        "Копыльскому РГС","Крупскому РГС","Логойскому РГС","Любаньскому РГС",
                                        "Минскому РПУ","ПУ Молодечногаз","Мядельскому РГС","Несвижскому РГС",
                                        "Пуховичскому РГС","Руденскому ГНС","ПУ Слуцкгаз","СмолевичиСмолевичскому РГС",
                                        "ПУ Солигорскгаз","Стародорожскому РГС","ПУ Столбцыгаз","ТП Березинское",
                                        "Узденскому РГС","Червенскому РГС" };
//**********************************************************************************************
//**********************************************************************************************
        private void DatabaseReader_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(600, 790);

            try
            {
                excelApp = new Excel.Application();
            }
            catch (Exception error)
            {
                labelErrorDescription.Text = error.Message;
            }
            if (excelApp == null)
            {
                PrintErrors(Errors.ExcelDisabled);
            }
            else
            {
                PrintErrors(Errors.ExcelEnabled);
            }
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

        private void sqlQueryAndFillingGridView(CheckBox checkBoxObject, CheckBox checkBoxData, 
                                                    CheckBox checkBoxPeriod, DataGridView GridForViewData, 
                                                        ComboBox comboBoxSensorNumber, ComboBox comboBoxObject,
                                                            Label labelErrorDescription, DateTimePicker dateTime,
                                                                DateTimePicker dateTimePeriodFrom, DateTimePicker dateTimePeriodTo,
                                                                        TextBox textBoxDbName)
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
                ConnectionAndFillingGridView(query, GridForViewData, comboBoxSensorNumber, labelErrorDescription, textBoxDbName);
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
                ConnectionAndFillingGridView(query, GridForViewData, comboBoxSensorNumber, labelErrorDescription, textBoxDbName);             
            }
        }
//**********************************************************************************************
//**********************************************************************************************
        private void ConnectionAndFillingGridView(string query, DataGridView GridForViewData, ComboBox comboBoxSensorNumber, Label labelErrorDescription, TextBox textBoxDbName)
        {
            SQLiteConnection connection =
            //new SQLiteConnection(@"data source=D:\программирование\C#\database\MOG.sq3");
            new SQLiteConnection(@"data source=Db\" + textBoxDbName.Text); //в папке Db/ с программой
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
            addItemForComboBoxSensorNumber(GridForViewData, comboBoxSensorNumber);
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
            ExcelEnabled,
            ExcelDisabled,
            ComboBoxSensorNumberIsEmpty,
            WrongDataInValue_Re,
            WrongDataInValue_Izm,
            WrongDataInDate,
            WrongDataInColumsOfTable,
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
                case Errors.ExcelEnabled:
                    labelExistExcel.Text = "Excel установлен на ПК";
                    labelExistExcel.ForeColor = System.Drawing.Color.Green;
                    break;
                case Errors.ExcelDisabled:
                    labelErrorDescription.Text = "Excel не установлен на ПК";
                    break;
                case Errors.ComboBoxSensorNumberIsEmpty:
                    labelErrorDescription.Text = "Для получения протокола или сертификата необходимо сформировать таблицу";
                    break;
                case Errors.WrongDataInValue_Re:
                    labelErrorDescription.Text = "Некорректные данные в столбце Value_Re по выбранному манометру";
                    break;
                case Errors.WrongDataInValue_Izm:
                    labelErrorDescription.Text = "Некорректные данные в столбце Value_Izm по выбранному манометру";
                    break;
                case Errors.WrongDataInDate:
                    labelErrorDescription.Text = "Некорректные данные в столбце Date по выбранному манометру";
                    break;
                case Errors.WrongDataInColumsOfTable:
                    labelErrorDescription.Text = "Некорректные данные в выбраной строке";
                    break;
            }
        }
//**********************************************************************************************
//**********************************************************************************************
        private void buttonTable_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQueryAndFillingGridView(checkBoxObject, checkBoxData,
                                                    checkBoxPeriod, GridForViewData,
                                                        comboBoxSensorNumber, comboBoxObject,
                                                            labelErrorDescription, dateTime,
                                                                dateTimePeriodFrom, dateTimePeriodTo,
                                                                    textBoxDbName);
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

        private void GridForViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxSensorNumber.SelectedIndex = e.RowIndex;
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

        private void comboBoxSensorNumber_SelectedIndexChanged(object sender, EventArgs e) 
        {
            GridForViewData.ClearSelection();
            GridForViewData.Rows[comboBoxSensorNumber.SelectedIndex].Selected = true;
            GridForViewData.CurrentCell = GridForViewData[0, comboBoxSensorNumber.SelectedIndex];

        }

//**********************************************************************************************
//**********************************************************************************************
        private void addItemForComboBoxSensorNumber(DataGridView GridForViewData, ComboBox comboBoxSensorNumber)
        {
            if (GridForViewData.RowCount > 1)
            {
                comboBoxSensorNumber.Items.Clear();
                for (int i = 0; i < GridForViewData.RowCount - 1; i++)
                {               
                    if (GridForViewData.Columns.Count == 13)
                    {
                        comboBoxSensorNumber.Items.Add(GridForViewData[0, i].Value);
                    }
                    else
                    {
                        comboBoxSensorNumber.Items.Add(GridForViewData[1, i].Value);
                    }
                    comboBoxSensorNumber.SelectedIndex = 0;
                }
            }
            else
            {
                comboBoxSensorNumber.Items.Clear();
                comboBoxSensorNumber.Text = "";
            }
        }
//**********************************************************************************************
//**********************************************************************************************

        private void buttonProtocol_Click(object sender, EventArgs e)
        {
            protocolPopulate(excelApp, GridForViewData, 
                                comboBoxSensorNumber, belongOfObjects, objects, 
                                    comboBoxObject, labelErrorDescription);
        }

//**********************************************************************************************
//**********************************************************************************************

        private void buttonSertificate_Click(object sender, EventArgs e)
        {
            SertrficatePopulate(excelApp ,GridForViewData, 
                                    comboBoxSensorNumber, belongOfObjects, objects, 
                                        comboBoxObject, labelErrorDescription);
        }

//**********************************************************************************************
//**********************************************************************************************

        private enum ColumnsTable : int
        {
            Number,
            Date,
            Diap,
            Diam,
            Clas,
            Red,
            Points,
            Values_Re,
            Values_Izm,
            T_ext,
            P_ext,
            DevCfg,
            Smth,
        }
//----------------------------------------------
        private void protocolPopulate(Excel.Application excelApp, DataGridView GridForViewData, 
                                        ComboBox comboBoxSensorNumber, string[] belongOfObjects, 
                                            string[] objects, ComboBox comboBoxObject, Label labelErrorDescription)
        {
            if(checkValueInGridView(GridForViewData, comboBoxSensorNumber) == 1) { }
            else
            {
                excelApp.Visible = true;
                Excel.Workbooks excelAppWorkBooks = excelApp.Workbooks;
                string fileName = System.Windows.Forms.Application.StartupPath + "//" + "Без имени 1.ods";
                try
                {
                    excelApp.DisplayAlerts = false;
                    excelApp.Workbooks.Close();
                    excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
                }
                catch(Exception error)
                {
                    labelErrorDescription.Text = error.Message;
                    return;

                }
                Excel.Workbook excelAppWorkBook = excelAppWorkBooks[1];
                Excel.Sheets excelSheets = excelAppWorkBook.Worksheets;
                Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelSheets.get_Item(1);

                prepareValueForProtocol(excelWorkSheet, GridForViewData, comboBoxSensorNumber, belongOfObjects, objects, comboBoxObject);
            }
        }

//**********************************************************************************************
//**********************************************************************************************

        private void SertrficatePopulate(Excel.Application excelApp, DataGridView GridForViewData, 
                                            ComboBox comboBoxSensorNumber, string[] belongOfObjects, 
                                                string[] objects, ComboBox comboBoxObject, Label labelErrorDescription)
        {
            //System.Diagnostics.Process.Start(@"Без имени 2.ods");
            if (checkValueInGridView(GridForViewData, comboBoxSensorNumber) == 1) { }
            else
            {
                excelApp.Visible = true;
                Excel.Workbooks excelAppWorkBooks = excelApp.Workbooks;
                string fileName = System.Windows.Forms.Application.StartupPath + "//" + "Без имени 2.ods";
                try
                {
                    excelApp.DisplayAlerts = false;
                    excelApp.Workbooks.Close();
                    excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
                }
                catch (Exception error)
                {
                    labelErrorDescription.Text = error.Message;
                    return;

                }
                Excel.Workbook excelAppWorkBook = excelAppWorkBooks[1];
                Excel.Sheets excelSheets = excelAppWorkBook.Worksheets;
                Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelSheets.get_Item(1);

                prepareValueForSertificate(excelWorkSheet, GridForViewData, comboBoxSensorNumber, belongOfObjects, objects, comboBoxObject);
            }
        }
        //**********************************************************************************************
        //**********************************************************************************************
        private void prepareValueForProtocol(Excel.Worksheet worksheet, DataGridView gridView, 
                                                ComboBox comboboxSensor, string[] belongOfObjects, 
                                                        string[] objects, ComboBox comboboxObject)
        {
            string smth, number, clas, date, t_exp, diam, diap, belongOfObject = "";
            string[] datas_re, datas_izm;

            if (gridView.Columns.Count == 13)
            {
                smth = gridView[((int)ColumnsTable.Smth), comboboxSensor.SelectedIndex].Value.ToString();
                number = gridView[((int)ColumnsTable.Number), comboboxSensor.SelectedIndex].Value.ToString();
                clas = gridView[((int)ColumnsTable.Clas), comboboxSensor.SelectedIndex].Value.ToString();
                date = gridView[((int)ColumnsTable.Date), comboboxSensor.SelectedIndex].Value.ToString();
                t_exp = gridView[((int)ColumnsTable.T_ext), comboboxSensor.SelectedIndex].Value.ToString();
                diam = gridView[((int)ColumnsTable.Diam), comboboxSensor.SelectedIndex].Value.ToString();
                diap = gridView[((int)ColumnsTable.Diap), comboboxSensor.SelectedIndex].Value.ToString();
                diap = diap.Remove(diap.Length - 1);
                datas_re = gridView[((int)ColumnsTable.Values_Re), comboboxSensor.SelectedIndex].Value.ToString().Split('-');
                datas_izm = gridView[((int)ColumnsTable.Values_Izm), comboboxSensor.SelectedIndex].Value.ToString().Split('-');
                belongOfObject = belongOfObjects[comboboxObject.SelectedIndex];
            }
            else
            {
                smth = gridView[((int)ColumnsTable.Smth)+1, comboboxSensor.SelectedIndex].Value.ToString();
                number = gridView[((int)ColumnsTable.Number)+1, comboboxSensor.SelectedIndex].Value.ToString();
                clas = gridView[((int)ColumnsTable.Clas)+1, comboboxSensor.SelectedIndex].Value.ToString();
                date = gridView[((int)ColumnsTable.Date)+1, comboboxSensor.SelectedIndex].Value.ToString();
                t_exp = gridView[((int)ColumnsTable.T_ext)+1, comboboxSensor.SelectedIndex].Value.ToString();
                diam = gridView[((int)ColumnsTable.Diam)+1, comboboxSensor.SelectedIndex].Value.ToString();
                diap = gridView[((int)ColumnsTable.Diap)+1, comboboxSensor.SelectedIndex].Value.ToString();
                diap = diap.Remove(diap.Length - 1);
                datas_re = gridView[((int)ColumnsTable.Values_Re)+1, comboboxSensor.SelectedIndex].Value.ToString().Split('-');
                datas_izm = gridView[((int)ColumnsTable.Values_Izm)+1, comboboxSensor.SelectedIndex].Value.ToString().Split('-');
                int i = 0;
                foreach (string itemObjects in objects)
                {
                    if (gridView[0, comboboxSensor.SelectedIndex].Value.ToString() == itemObjects)
                    {
                        belongOfObject = belongOfObjects[i];
                    }
                    i++;
                }
            }
            worksheet.Cells[9, 8] = smth;
            worksheet.Cells[11, 8] = number;
            worksheet.Cells[12, 8] = clas;
            worksheet.Cells[15, 6] = date;
            worksheet.Cells[14, 7] = t_exp;
            worksheet.Cells[11, 6] = diam;
            worksheet.Cells[13, 6] = belongOfObject;
            worksheet.Cells[12, 6] = diap;
            worksheet.Cells[27, 3] = datas_re[0];
            worksheet.Cells[28, 3] = datas_re[1];
            worksheet.Cells[29, 3] = datas_re[2];
            worksheet.Cells[30, 3] = datas_re[3];
            worksheet.Cells[29, 4] = datas_re[4];
            worksheet.Cells[28, 4] = datas_re[5];
            worksheet.Cells[27, 4] = datas_re[6];
            worksheet.Cells[27, 5] = datas_izm[0];
            worksheet.Cells[28, 5] = datas_izm[1];
            worksheet.Cells[29, 5] = datas_izm[2];
            worksheet.Cells[30, 5] = datas_izm[3];
            worksheet.Cells[29, 6] = datas_izm[4];
            worksheet.Cells[28, 6] = datas_izm[5];
            worksheet.Cells[27, 6] = datas_izm[6];
        }
        //**********************************************************************************************
        //**********************************************************************************************

        private void prepareValueForSertificate(Excel.Worksheet worksheet, DataGridView gridView, 
                                                    ComboBox comboboxSensor, string[] belongOfObjects, 
                                                       string[] objects, ComboBox comboboxObjects)
        {
            string smth, number, clas, date, dateLast, diam, diap, belongOfObject = "";

            if (gridView.Columns.Count == 13)
            {
                smth = gridView[((int)ColumnsTable.Smth), comboboxSensor.SelectedIndex].Value.ToString();
                date = gridView[((int)ColumnsTable.Date), comboboxSensor.SelectedIndex].Value.ToString();
                dateLast = Convert.ToDateTime(gridView[((int)ColumnsTable.Date), comboboxSensor.SelectedIndex].Value.ToString()).AddYears(1).ToString("dd.MM.yy");
                number = gridView[((int)ColumnsTable.Number), comboboxSensor.SelectedIndex].Value.ToString();
                clas = gridView[((int)ColumnsTable.Clas), comboboxSensor.SelectedIndex].Value.ToString();
                diam = gridView[((int)ColumnsTable.Diam), comboboxSensor.SelectedIndex].Value.ToString();
                diap = gridView[((int)ColumnsTable.Diap), comboboxSensor.SelectedIndex].Value.ToString();
                diap = diap.Remove(diap.Length - 1);
                belongOfObject = belongOfObjects[comboboxObjects.SelectedIndex];

                worksheet.Cells[12, 8] = smth;
                worksheet.Cells[15, 5] = date;
                worksheet.Cells[19, 5] = number;
                worksheet.Cells[25, 5] = clas;
                worksheet.Cells[21, 5] = diam;
                worksheet.Cells[16, 5] = dateLast;
                worksheet.Cells[23, 5] = diap;
                worksheet.Cells[27, 5] = belongOfObject;
            }
            else
            {
                smth = gridView[((int)ColumnsTable.Smth) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                date = gridView[((int)ColumnsTable.Date) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                dateLast = Convert.ToDateTime(gridView[((int)ColumnsTable.Date) + 1, comboboxSensor.SelectedIndex].Value.ToString()).AddYears(1).ToString("dd.MM.yy");
                number = gridView[((int)ColumnsTable.Number) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                clas = gridView[((int)ColumnsTable.Clas) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                diam = gridView[((int)ColumnsTable.Diam) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                diap = gridView[((int)ColumnsTable.Diap) + 1, comboboxSensor.SelectedIndex].Value.ToString();
                diap = diap.Remove(diap.Length - 1);
                int i = 0;
                foreach (string itemObjects in objects)
                {
                    if (gridView[0, comboboxSensor.SelectedIndex].Value.ToString() == itemObjects)
                    {
                        belongOfObject = belongOfObjects[i];
                    }
                    i++;
                }

                worksheet.Cells[12, 8] = smth;
                worksheet.Cells[15, 5] = date;
                worksheet.Cells[19, 5] = number;
                worksheet.Cells[25, 5] = clas;
                worksheet.Cells[21, 5] = diam;
                worksheet.Cells[16, 5] = dateLast;
                worksheet.Cells[23, 5] = diap;
                worksheet.Cells[27, 5] = belongOfObject;
            }
        }
        //**********************************************************************************************
        //**********************************************************************************************

        private int checkValueInGridView(DataGridView GridForViewData, ComboBox comboBoxSensorNumber)
        {
            if (comboBoxSensorNumber.Items.Count == 0)
            {
                PrintErrors(Errors.ComboBoxSensorNumberIsEmpty);
                return 1;
            }
            try
            {
                if (GridForViewData.Columns.Count == 13)
                {
                    DateTime dt = Convert.ToDateTime(GridForViewData[((int)ColumnsTable.Date), comboBoxSensorNumber.SelectedIndex].Value.ToString());
                    if (GridForViewData[((int)ColumnsTable.Values_Re), comboBoxSensorNumber.SelectedIndex].Value.ToString().Split('-').Length != 8)
                    {
                        PrintErrors(Errors.WrongDataInValue_Re);
                        return 1;
                    }
                    else if (GridForViewData[((int)ColumnsTable.Values_Izm), comboBoxSensorNumber.SelectedIndex].Value.ToString().Split('-').Length != 8)
                    {
                        PrintErrors(Errors.WrongDataInValue_Izm);
                        return 1;
                    }
                    else if (GridForViewData[((int)ColumnsTable.Smth), comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Number), comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Clas), comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.T_ext), comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Diam), comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Diap), comboBoxSensorNumber.SelectedIndex].Value.ToString() == "")
                    {
                        PrintErrors(Errors.WrongDataInColumsOfTable);
                        return 1;
                    }
                    else return 0;
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(GridForViewData[((int)ColumnsTable.Date) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString());
                    if (GridForViewData[((int)ColumnsTable.Values_Re) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString().Split('-').Length != 8)
                    {
                        PrintErrors(Errors.WrongDataInValue_Re);
                        return 1;
                    }
                    else if (GridForViewData[((int)ColumnsTable.Values_Izm) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString().Split('-').Length != 8)
                    {
                        PrintErrors(Errors.WrongDataInValue_Izm);
                        return 1;
                    }
                    else if (GridForViewData[((int)ColumnsTable.Smth) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Number) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Clas) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.T_ext) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Diam) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == ""
                                || GridForViewData[((int)ColumnsTable.Diap) + 1, comboBoxSensorNumber.SelectedIndex].Value.ToString() == "")
                    {
                        PrintErrors(Errors.WrongDataInColumsOfTable);
                        return 1;
                    }
                    else return 0;
                }
            }
            catch
            {
                PrintErrors(Errors.WrongDataInDate);
                return 1;
            }
        }
    }
}