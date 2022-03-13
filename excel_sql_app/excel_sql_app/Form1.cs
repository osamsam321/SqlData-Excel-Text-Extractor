using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections;


namespace excel_sql_app
{
   
    public partial class Form1 : Form
    {
        bool excelDatainitated = false;
        System.Threading.Timer performanceTime;
        int selectColorIndex = -1;
        long timeExecuted;
        long lastTime;
        Dictionary<string, List<int>> keywordD;
        readonly string dataSyntax = "(??)";

        public Form1()
        {
            InitializeComponent();
           
        }
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keywordD = new Dictionary<string, List<int>>();
             timeExecuted = 0L;
            lastTime = 0L;
            string[] sqlKeyWords = {"AND","ALTER TABLE","AS","BETWEEN","CREATE DATABASE",
                "CREATE TABLE","CREATE INDEX","DELETE","GRANT","REVOKE","COMMIT","ROLLBACK",
                "SAVEPOINT","DROP DATABASE","DROP INDEX","DROP TABLE","EXISTS","GROUP BY",
                "HAVING","IN","INSERT INTO","INNER JOIN","LEFT JOIN","RIGHT JOIN","FULL JOIN",
                "LIKE","OR","ORDER BY","SELECT","SELECT *","SELECT DISTINCT","SELECT INTO","SELECT TOP",
                "TRUNCATE TABLE","UNION","UNION ALL","UPDATE","WHERE" };
            foreach (string keyword in sqlKeyWords)
            {
                keywordD.Add(keyword.ToLower(), new List<int>());
            }

            mainSqlTextBox_TextChanged(null, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void updateSysMsgTitle(string msg, Color forColor)
        {
            this.systemMSGLabel.Visible = true;
            this.systemMSGLabel.Text = msg;
            this.systemMSGLabel.ForeColor = forColor;
        }
       public void closeSysMsgTitle()
        {
            this.systemMSGLabel.Visible = false;
        }
        private void DdPanelCont_DragDrop(object sender, DragEventArgs e)
        {
           
            if ( e.Data.GetDataPresent(DataFormats.FileDrop))
             {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                /*FIlePathLabel.Text = files.First();*/
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                StartPerformanceTimer();
                string a = (string) e.Data.GetData(DataFormats.Text, false);
                string result1 = a.Replace("\r\n", ",");
                StringBuilder sbFinal = new StringBuilder(result1);              
                sbFinal.Remove(sbFinal.Length - 1, 1);
                /*  string[] arr = sbFinal.ToString().Split(",");
                  List<string> list = new List<string>(arr);*/
                if (sbFinal.Length > 0)
                {
                    FillDataBox(sbFinal);
                    excelDatainitated = true;
                }
                ClosePerformanceTimer("read in ");
            }

        }

        private void performanceTimerRun(object state)
        {          
            timeExecuted = DateTime.UtcNow.Millisecond - lastTime;
        }
        private int GetCellOrOne()
        {
            return (string.IsNullOrEmpty(colTextBox.Text)) ? 1 : int.Parse(colTextBox.Text);
        }
        private void ddPanelCont_DragOver(object sender, DragEventArgs e)
        {
                if (!excelDatainitated && e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                StartPerformanceTimer();
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                    e.Effect = DragDropEffects.All;
                    string path = files.First();
                    FIlePathLabel.Text = path;
                /*HashSet<string> excelDataSet = executeExcelReader(new Uri(path));*/
                int cell = GetCellOrOne();
                StringBuilder sb = ExcelReader.getInstance(new Uri(path)).ExecuteDataSb(cell);
                 /*   if(excelDataSet == null)
                    {
                         updateSysMsgTitle("Please close your Excel app or place an .xlsx file", Color.Red);
                    }*/
                    if(sb == null)
                    {
                        updateSysMsgTitle("Please close your Excel app, place an .xlsx file and add correct values", Color.Red);
                     }
                    else
                    {
                        closeSysMsgTitle();
                    /* List<string> excelValues = new List<string>(excelDataSet);*/
                    /*FillDataBox(excelValues);*/
                    FillDataBox(sb);
                        excelDatainitated = true;
                    }

                ClosePerformanceTimer("read in ");
            }
         
        }


        private void FillDataBox(List<string> excelDataList )
        {
           
            StringBuilder excelData = new StringBuilder("(");
            string last = excelDataList[excelDataList.Count - 1];
            foreach(string data in excelDataList)
            {
                StringBuilder tempSb = new StringBuilder();
                tempSb.Append(data);

                if (tempSb[0] == '\'' || tempSb[0] == '\"')
                {
                    tempSb.Remove(0, 1);
                }
                if (tempSb[tempSb.Length - 1] == '\'' || tempSb[tempSb.Length -1] == '\"')
                {
                    
                    tempSb.Remove(tempSb.Length - 1, 1);
                }                
                
                if(data.Equals(last))
                    excelData.Append("'" + tempSb + "'" + " )");
                else
                  excelData.Append("'" + tempSb + "'" + ", ");
            }

            dataRichBox.Text = excelData.ToString();
           
        }

        private void FillDataBox(StringBuilder sb)
        {
            if(uniqueCheckBox.Checked)
            {
                Debug.WriteLine("inside of checked condition");
                HashSet<string> s = new HashSet<string>(sb.ToString().Split(","));
                sb = new StringBuilder(string.Join(',', s));
                uniqueCheckBox.Checked = false;
            }
            StringBuilder excelData = new StringBuilder("(");
            StringBuilder tempSb = new StringBuilder();

            for(int i = 0; i < sb.Length;i++)
            {             
                if(sb[i] != ',')
                {
                    tempSb.Append(sb[i]);
                }
               
                if(sb[i] == ',' || i == sb.Length - 1)
                {
                    if (tempSb[0] == '\'' || tempSb[0] == '\"')
                    {
                        tempSb.Remove(0, 1);
                    }
                    if (tempSb[tempSb.Length - 1] == '\'' || tempSb[tempSb.Length - 1] == '\"')
                    {
                        tempSb.Remove(tempSb.Length - 1, 1);
                    }

                    if (i == sb.Length - 1)
                    {
                        excelData.Append("'" + tempSb + "'" + " )");
                    }
                    else
                    {
                        excelData.Append("'" + tempSb + "'" + ", ");
                    }

                    tempSb = new StringBuilder();

                }

                
            }

            dataRichBox.Text = excelData.ToString();
          
        }
        private HashSet<string> executeExcelReader(Uri path) {
            ExcelReader er = ExcelReader.getInstance(path);

            return er.ExecuteDataHash();
          
        }
        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || 
                e.Data.GetDataPresent(DataFormats.Text))
            {

                e.Effect = DragDropEffects.All;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
            cleanUp();
        }
        private void cleanUp()
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainSqlTextBox_TextChanged(object sender, EventArgs e)
        {
            Color defaultColor = mainSqlRichBox.ForeColor;
            Color highColor = Color.GreenYellow;
            Color highKeyword = Color.MediumPurple;
            

            int occurances = 0;
            int colorChangeIndex = 0;
            string richtxt = mainSqlRichBox.Text;
            int tempKeywordTempIndex;
            int deleteKeywordTempIndex;
            List<string>keys = keywordD.Keys.ToList();
            //--------------------- keyword implementation
     /*      
      *      for(int i = 0; i < keys.Count;i++)
            {
                string key = keys[i].ToLower();
              *//*  if((deleteKeywordTempIndex = richtxt.IndexOf(key))!= null> -1 && keywordD[key] < richtxt.Length )
                {
                    mainSqlRichBox.Select(deleteKeywordTempIndex, richtxt.Length);
                    mainSqlRichBox.SelectionColor = defaultColor;
                    Debug.WriteLine("insde of first delete case");
                }*/

            /*  if ((deleteKeywordTempIndex = richtxt.IndexOf(key)) > -1 && !richtxt.Contains(key))
                {
                    keywordD[key] = -1;
                    mainSqlRichBox.
                    mainSqlRichBox.Select(deleteKeywordTempIndex, key);
                    mainSqlRichBox.SelectionColor = defaultColor;

                }*//*
                for(int j = 0; i < keywordD[key].Count;j++)
                {

                }
                if ((tempKeywordTempIndex = richtxt.IndexOf(key)) != null)
                {
                    var list = keywordD[key];
                    list = new List<int>();
                    list.Add(tempKeywordTempIndex);
                    keywordD[key] = list;
                    mainSqlRichBox.Select(tempKeywordTempIndex, key.Length);
                    mainSqlRichBox.SelectionColor = highKeyword;
                }
                mainSqlRichBox.SelectionStart = mainSqlRichBox.Text.Length;
                mainSqlRichBox.SelectionColor = defaultColor;
            }*/
            for (int i = 0; i < richtxt.Length; i++)
            {        
                
                if (richtxt[i].Equals('(') && i + dataSyntax.Length <= richtxt.Length)
                {
                        string tempSub = richtxt.Substring(i, dataSyntax.Length );
                        if(tempSub.Equals(dataSyntax))
                        {
                            occurances++;
                            colorChangeIndex = i;
                            
                        }              
                }

            }
            
            if(occurances == 1)
            {
                if (selectColorIndex == -1)
                {
                    selectColorIndex = colorChangeIndex;
                    mainSqlRichBox.Select(colorChangeIndex, dataSyntax.Length);
                    mainSqlRichBox.SelectionColor = highColor;               
                }

                mainSqlRichBox.SelectionStart = mainSqlRichBox.Text.Length;
                mainSqlRichBox.SelectionColor = defaultColor;

            }
            else if(occurances > 1 && selectColorIndex >= 0)
            {
                mainSqlRichBox.Select(selectColorIndex, dataSyntax.Length);
                mainSqlRichBox.SelectionColor = defaultColor;
                mainSqlRichBox.SelectionStart = mainSqlRichBox.Text.Length;
                selectColorIndex = -1;
            }
            else if(selectColorIndex >= 0)
            {
                mainSqlRichBox.Select(selectColorIndex, dataSyntax.Length);
                mainSqlRichBox.SelectionColor = defaultColor;
                mainSqlRichBox.SelectionStart = mainSqlRichBox.Text.Length;
                selectColorIndex = -1;
            }
            
            mainSqlRichBox.Focus();
            mainSqlRichBox.DeselectAll();
        }
        private void StartPerformanceTimer()
        {
            timeExecuted = 0;
            lastTime = DateTime.UtcNow.Millisecond;
            performanceTime = new System.Threading.Timer(new TimerCallback(performanceTimerRun),
                           null, 1, 1);
        }
        private void ClosePerformanceTimer(string msg)
        {
            performanceTime.Dispose();
            performanceLabel.Text = (msg + timeExecuted + " MS");
            performanceLabel.Visible = true;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainAreaTitle_Click(object sender, EventArgs e)
        {

        }

        private void ddPanelCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sqlDataTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool dataSqlInclusionReady()
        {
            return selectColorIndex > -1;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            dataRichBox.Text = string.Empty;
        }
        private int getGroupInputValue()
        {
            return (string.IsNullOrEmpty(groupTextBox.Text)) ? 0 : int.Parse(groupTextBox.Text);
        }
        private void executeBtn_Click(object sender, EventArgs e)
        {
            bool mainSqlReady = false;
            StringBuilder mainSqlText;
            StringBuilder dataText;
            
            if(dataSqlInclusionReady())
            {
                StartPerformanceTimer();
                mainSqlText = new StringBuilder(mainSqlRichBox.Text);
                int group = getGroupInputValue();
                if (group == 0)
                {
                   
                    mainSqlText.Remove(selectColorIndex, dataSyntax.Length);
                    mainSqlText.Insert(selectColorIndex, dataRichBox.Text);
                    mainSqlRichBox.Text = mainSqlText.ToString();
                }
                else
                {
                                    
                    int groupCounter = 0;
                    string[] tempGroup =  dataRichBox.Text.Split(",");
                    for (int i = 0; i < dataRichBox.Text.Length;i++)
                    {
                             
                        if ( i % group == 0)
                        {
                            string groupTmpStr = string.Empty;
                            StringBuilder groupSB = new StringBuilder(mainSqlRichBox.Text);
                            for (int j = i; j < i + group; j++ )
                            {
                                groupTmpStr = tempGroup[j] + string.Empty;
                            }
                            mainSqlRichBox.AppendText("------------" + Math.Floor((double) i / group) + "------------");
                            groupSB.Remove(selectColorIndex, dataSyntax.Length);
                            groupSB.Append(groupTmpStr, 2, dataSyntax.Length);
                            mainSqlRichBox.AppendText(groupSB.ToString());
                            mainSqlRichBox.AppendText(" ----------- end of group");
                        }
                    }
                }
                ClosePerformanceTimer("Exported in ");
 
            }

            else
            {
                updateSysMsgTitle("Please complete forms first", Color.Red);
            }
        }

        private void ddLabel_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            excelDatainitated = false;

            Form1 NewForm = new Form1();
            int timeExecutedMilli = 0;
            NewForm.Show();
            this.Dispose(false);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void systemMSGLabel_Click(object sender, EventArgs e)
        {

        }
        private void DataRichBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = groupTextBox.Text;
            if (!Regex.IsMatch(value, @"\d") )
            {
                groupTextBox.Text = string.Empty;
                updateSysMsgTitle("Please enter a postive Number greator then zero", Color.Red);          
            }
            
            else
            {
                if(int.Parse(value) > 0)
                {
                    closeSysMsgTitle();
                }
                else
                {
                    updateSysMsgTitle("Please enter a postive Number greator then zero", Color.Red);
                }
                            
            }
        }

        private void performanceCheckTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void performanceLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void uniqueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ColTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = colTextBox.Text;
            if (!Regex.IsMatch(value, @"\d"))
            {
                colTextBox.Text = string.Empty;
                updateSysMsgTitle("Please enter a postive Number", Color.Red);               
            }

            else
            {
                closeSysMsgTitle();
            }
        }
    }
}
