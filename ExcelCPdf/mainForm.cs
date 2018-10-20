using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Spire.Pdf;
using MSEXCEL = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace ExcelCPdf
{
    public partial class mainForm : Form
    {
        int iRowCount;
        int current_row;

        MSEXCEL.Application excelApp;
        MSEXCEL.Sheets excelSheets;
        MSEXCEL.Workbook excelWorkbook;
        MSEXCEL.Worksheet worksheet;

        int name_int;
        int num_int;
        int batch_int;
        int pdffilename_int;
        int iden_int;
        string current_pdffilename;
        int notequ_int;
        int notfilter_int;
        int reason_int;
        int mode_int;
        int m1_int, m2_int, m3_int, m4_int;

        XmlDocument xmldoc;
        XmlElement xmlelem;
        XmlDeclaration xmldecl;

        Image image;
        List<Image> ListImage;
        int pdfpage;

        Dictionary<string, int> wordtonum;

        Color idencolor;

        Point M_pot_p;
        int M_int_mx, M_int_my;
        int M_int_maxX, M_int_maxY;//加快读取用

        public mainForm()
        {
            InitializeComponent();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pdf_pictureBox_MouseWheel);

            M_pot_p = new Point();//原始位置
            M_int_mx = 0; //下次能继续
            M_int_my = 0;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if (excelApp != null)
            {
                QuitExcel(ref excelApp);
            }

            current_row = 1;
            pdfpage = 0;

            name_int = Convert.ToInt32(wordtonum[namecol_textBox.Text]);    //通过字典取得对应列标
            num_int = Convert.ToInt32(wordtonum[numcol_textBox.Text]);
            batch_int = Convert.ToInt32(wordtonum[batchcol_textBox.Text]);
            pdffilename_int = Convert.ToInt32(wordtonum[filenamecol_textBox.Text]);
            iden_int = Convert.ToInt32(wordtonum[idencol_textBox.Text]);
            notequ_int = Convert.ToInt32(wordtonum[notequcol_textBox.Text]);
            notfilter_int = Convert.ToInt32(wordtonum[notfiltercol_textBox.Text]);
            reason_int = Convert.ToInt32(wordtonum[reasoncol_textBox.Text]);
            mode_int = Convert.ToInt32(wordtonum[modecol_textBox.Text]);
            m1_int = Convert.ToInt32(wordtonum[m1col_textBox.Text]);
            m2_int = Convert.ToInt32(wordtonum[m2col_textBox.Text]);
            m3_int = Convert.ToInt32(wordtonum[m3col_textBox.Text]);
            m4_int = Convert.ToInt32(wordtonum[m4col_textBox.Text]);

            //处理excel文件
            try
            {
                excelApp = new MSEXCEL.Application();

                object oMissiong = System.Reflection.Missing.Value;
                excelWorkbook = null;

                excelWorkbook = excelApp.Workbooks.Open(exceldir_textBox.Text, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                excelSheets = excelWorkbook.Worksheets;

                worksheet = (MSEXCEL.Worksheet)excelSheets.get_Item(1);

                iRowCount = worksheet.UsedRange.Rows.Count; //获取excel中的行数

                data_process(current_row, pdfpage);

                pageredirect_button.Enabled = true;
                previous_button.Enabled = true;
                next_button.Enabled = true;
                idenmsg_button.Enabled = true;
            }
            catch (Exception e_load)
            {
                MessageBox.Show(e_load.Message);
            }
        }

        private void pdfdir_button_Click(object sender, EventArgs e)
        {
            if (pdfdir_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pdfdir_textBox.Text = pdfdir_folderBrowserDialog.SelectedPath;
            }
        }

        private void exceldir_button_Click(object sender, EventArgs e)
        {
            if (exceldir_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exceldir_textBox.Text = exceldir_openFileDialog.FileName;
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (current_row < iRowCount)
            {
                current_row++;
            }
            data_process(current_row, 0);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*try
            {
                object oMissiong = System.Reflection.Missing.Value;
                excelWorkbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                excelWorkbook = null;
                excelApp.Workbooks.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                excelApp = null;
                Process[] process1 = Process.GetProcessesByName("EXCEL.EXE");
                foreach (Process p1 in process1)
                {
                    if (!p1.HasExited)  // 如果程序没有关闭，结束程序
                    {
                        MessageBox.Show("");
                        p1.Kill();
                        p1.WaitForExit();
                    }
                }
            }
            catch
            {
            }*/
            if (excelApp != null)
            {
                QuitExcel(ref excelApp);
            }

            xmldoc = new XmlDocument();
            xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);   //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
            xmldoc.AppendChild(xmldecl);

            xmlelem = xmldoc.CreateElement("", "Config", "");   //加入一个元素
            xmldoc.AppendChild(xmlelem);

            XmlNode root = xmldoc.SelectSingleNode("Config");   //查找<Config>
            XmlElement xe1 = xmldoc.CreateElement("Node");  //创建一个<Node>节点
            xe1.SetAttribute("Ver", "1.0.0.0"); //设置该节点Ver属性

            XmlElement xesub1 = xmldoc.CreateElement("pdfdir");
            xesub1.InnerText = pdfdir_textBox.Text;     //设置文本节点
            xe1.AppendChild(xesub1);    //添加到<Node>节点中
            XmlElement xesub2 = xmldoc.CreateElement("exceldir");
            xesub2.InnerText = exceldir_textBox.Text;
            xe1.AppendChild(xesub2);
            XmlElement xesub3 = xmldoc.CreateElement("filenamecol");
            xesub3.InnerText = filenamecol_textBox.Text;
            xe1.AppendChild(xesub3);
            XmlElement xesub4 = xmldoc.CreateElement("namecol");
            xesub4.InnerText = namecol_textBox.Text;
            xe1.AppendChild(xesub4);
            XmlElement xesub5 = xmldoc.CreateElement("numcol");
            xesub5.InnerText = numcol_textBox.Text;
            xe1.AppendChild(xesub5);
            XmlElement xesub6 = xmldoc.CreateElement("batchcol");
            xesub6.InnerText = batchcol_textBox.Text;
            xe1.AppendChild(xesub6);
            XmlElement xesub7 = xmldoc.CreateElement("idencol");
            xesub7.InnerText = idencol_textBox.Text;
            xe1.AppendChild(xesub7);
            XmlElement xesub8 = xmldoc.CreateElement("idenmsg");
            xesub8.InnerText = idenmsg_textBox.Text;
            xe1.AppendChild(xesub8);
            XmlElement xesub9 = xmldoc.CreateElement("notequcol");
            xesub9.InnerText = notequcol_textBox.Text;
            xe1.AppendChild(xesub9);
            XmlElement xesub10 = xmldoc.CreateElement("notfiltercol");
            xesub10.InnerText = notfiltercol_textBox.Text;
            xe1.AppendChild(xesub10);
            XmlElement xesub11 = xmldoc.CreateElement("reasoncol");
            xesub11.InnerText = reasoncol_textBox.Text;
            xe1.AppendChild(xesub11);
            XmlElement xesub12 = xmldoc.CreateElement("modecol");
            xesub12.InnerText = modecol_textBox.Text;
            xe1.AppendChild(xesub12);
            XmlElement xesub13 = xmldoc.CreateElement("m1col");
            xesub13.InnerText = m1col_textBox.Text;
            xe1.AppendChild(xesub13);
            XmlElement xesub14 = xmldoc.CreateElement("m2col");
            xesub14.InnerText = m2col_textBox.Text;
            xe1.AppendChild(xesub14);
            XmlElement xesub15 = xmldoc.CreateElement("m3col");
            xesub15.InnerText = m3col_textBox.Text;
            xe1.AppendChild(xesub15);
            XmlElement xesub16 = xmldoc.CreateElement("m4col");
            xesub16.InnerText = m4col_textBox.Text;
            xe1.AppendChild(xesub16);

            root.AppendChild(xe1);  //添加到<Config>节点中

            //xmldoc.Save(System.IO.Directory.GetCurrentDirectory() + "\\" + "config.xml");   //保存创建好的XML文档
            xmldoc.Save(System.Windows.Forms.Application.StartupPath + "\\" + "config.xml");   //保存创建好的XML文档
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            if (current_row > 1)
            {
                current_row--;
            } 
            data_process(current_row, 0);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                xmldoc = new XmlDocument();
                xmldoc.Load(System.Windows.Forms.Application.StartupPath + "\\Config.xml");
                pdfdir_textBox.Text = xmldoc.GetElementsByTagName("pdfdir")[0].InnerText;
                exceldir_textBox.Text = xmldoc.GetElementsByTagName("exceldir")[0].InnerText;
                filenamecol_textBox.Text = xmldoc.GetElementsByTagName("filenamecol")[0].InnerText;
                namecol_textBox.Text = xmldoc.GetElementsByTagName("namecol")[0].InnerText;
                numcol_textBox.Text = xmldoc.GetElementsByTagName("numcol")[0].InnerText;
                batchcol_textBox.Text = xmldoc.GetElementsByTagName("batchcol")[0].InnerText;
                idencol_textBox.Text = xmldoc.GetElementsByTagName("idencol")[0].InnerText;
                idenmsg_textBox.Text = xmldoc.GetElementsByTagName("idenmsg")[0].InnerText;
                notequcol_textBox.Text = xmldoc.GetElementsByTagName("notequcol")[0].InnerText;
                notfiltercol_textBox.Text = xmldoc.GetElementsByTagName("notfiltercol")[0].InnerText;
                reasoncol_textBox.Text = xmldoc.GetElementsByTagName("reasoncol")[0].InnerText;
                modecol_textBox.Text = xmldoc.GetElementsByTagName("modecol")[0].InnerText;
                m1col_textBox.Text = xmldoc.GetElementsByTagName("m1col")[0].InnerText;
                m2col_textBox.Text = xmldoc.GetElementsByTagName("m2col")[0].InnerText;
                m3col_textBox.Text = xmldoc.GetElementsByTagName("m3col")[0].InnerText;
                m4col_textBox.Text = xmldoc.GetElementsByTagName("m4col")[0].InnerText;

                iscopypdf_checkBox.Checked = false;
                copypdf_button.Enabled = false;
                copypdf_textBox.Text = "";
                copypdf_textBox.Enabled = false;

                wordtonum = new Dictionary<string, int>();  //生成字典
                wordtonum.Add("A", 1);
                wordtonum.Add("B", 2);
                wordtonum.Add("C", 3);
                wordtonum.Add("D", 4);
                wordtonum.Add("E", 5);
                wordtonum.Add("F", 6);
                wordtonum.Add("G", 7);
                wordtonum.Add("H", 8);
                wordtonum.Add("I", 9);
                wordtonum.Add("J", 10);
                wordtonum.Add("K", 11);
                wordtonum.Add("L", 12);
                wordtonum.Add("M", 13);
                wordtonum.Add("N", 14);
                wordtonum.Add("O", 15);
                wordtonum.Add("P", 16);
                wordtonum.Add("Q", 17);
                wordtonum.Add("R", 18);
                wordtonum.Add("S", 19);
                wordtonum.Add("T", 20);
                wordtonum.Add("U", 21);
                wordtonum.Add("V", 22);
                wordtonum.Add("W", 23);
                wordtonum.Add("X", 24);
                wordtonum.Add("Y", 25);
                wordtonum.Add("Z", 26);
                wordtonum.Add("AA", 27);
                wordtonum.Add("AB", 28);
                wordtonum.Add("AC", 29);
                wordtonum.Add("AD", 30);
                wordtonum.Add("AE", 31);
                wordtonum.Add("AF", 32);
                wordtonum.Add("AG", 33);
                wordtonum.Add("AH", 34);
                wordtonum.Add("AI", 35);
                wordtonum.Add("AJ", 36);
                wordtonum.Add("AK", 37);
                wordtonum.Add("AL", 38);
                wordtonum.Add("AM", 39);
                wordtonum.Add("AN", 40);
                wordtonum.Add("AO", 41);
                wordtonum.Add("AP", 42);
                wordtonum.Add("AQ", 43);
                wordtonum.Add("AR", 44);
                wordtonum.Add("AS", 45);
                wordtonum.Add("AT", 46);
                wordtonum.Add("AU", 47);
                wordtonum.Add("AV", 48);
                wordtonum.Add("AW", 49);
                wordtonum.Add("AX", 50);
                wordtonum.Add("AY", 51);
                wordtonum.Add("AZ", 52);

                idencolor = Color.White;
            }
            catch (Exception start_e)
            {
                MessageBox.Show(start_e.Message);
            }
            msg_richTextBox.Text = "设置好相关参数后点击【加载文档】";
        }

        private void idenmsg_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (excelApp != null)
                {
                    QuitExcel(ref excelApp);
                }

                excelApp = new MSEXCEL.Application();

                object oMissiong = System.Reflection.Missing.Value;
                excelWorkbook = null;

                excelWorkbook = excelApp.Workbooks.Open(exceldir_textBox.Text, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                excelSheets = excelWorkbook.Worksheets;

                worksheet = (MSEXCEL.Worksheet)excelSheets.get_Item(1);

                iRowCount = worksheet.UsedRange.Rows.Count; //获取excel中的行数


                ((MSEXCEL.Range)worksheet.Cells[current_row, iden_int]).Value = idenmsg_textBox.Text;
                ((MSEXCEL.Range)worksheet.Cells[current_row, iden_int]).Interior.Color = idencolor;
                ((MSEXCEL.Range)worksheet.Cells[current_row, iden_int]).Font.Color = Color.Black;
                excelWorkbook.Save();
                MessageBox.Show("标识成功！");
            }
            catch (Exception idenmsg_e)
            {
                MessageBox.Show(idenmsg_e.Message);
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            pdf_pictureBox.Height = this.Height - 137;
            pdf_pictureBox.Width = this.Width - 402;

            msg_richTextBox.Location = new System.Drawing.Point(pdf_pictureBox.Width / 2 - msg_richTextBox.Width / 2, pdf_pictureBox.Height / 2 - msg_richTextBox.Height / 2);

            check_groupBox.Location = new System.Drawing.Point(pdf_pictureBox.Location.X + pdf_pictureBox.Width + 7, check_groupBox.Location.Y);
        }

        private void pdfpageup_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pdfpage > 0)
                {
                    image = ListImage[pdfpage - 1];
                    pdf_pictureBox.Image = image;
                    pdfpage--;
                }
            }
            catch
            {
            }
        }

        private void pdfpagedown_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pdfpage < ListImage.Count - 1)
                {
                    image = ListImage[pdfpage + 1];
                    pdf_pictureBox.Image = image;
                    pdfpage++;
                }
            }
            catch
            {
            }
        }

        private void pdfpagerot_button_Click(object sender, EventArgs e)
        {
            try
            {
                pdf_pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pdf_pictureBox.Refresh();
            }
            catch
            {
            }
        }

        public void data_process(int current_row,int pdfpage)
        {
            pageredirect_button.Enabled = false;
            previous_button.Enabled = false;
            next_button.Enabled = false;
            idenmsg_button.Enabled = false;
            pdf_pictureBox.Image = null;
            msg_richTextBox.Visible = true;
            msg_richTextBox.Text = "正在处理，请稍等...";

            name_textBox.Text = "";
            num_textBox.Text = "";
            batch_textBox.Text = "";
            //idenmsg_textBox.Text = "";
            notequ_textBox.Text = "";
            notfilter_textBox.Text = "";
            mode_textBox.Text = "";
            m1_textBox.Text = "";
            m2_textBox.Text = "";
            m3_textBox.Text = "";
            m4_textBox.Text = "";
            
            try
            {
                if (excelApp != null)
                {
                    QuitExcel(ref excelApp);
                }

                excelApp = new MSEXCEL.Application();

                object oMissiong = System.Reflection.Missing.Value;
                excelWorkbook = null;

                excelWorkbook = excelApp.Workbooks.Open(exceldir_textBox.Text, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                excelSheets = excelWorkbook.Worksheets;

                worksheet = (MSEXCEL.Worksheet)excelSheets.get_Item(1);

                iRowCount = worksheet.UsedRange.Rows.Count; //获取excel中的行数
            }
            catch (Exception e_load)
            {
                MessageBox.Show(e_load.Message);
            }
                     
            row_textBox.Text = current_row.ToString() + " / " + iRowCount.ToString();
            name_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, name_int]).Text;
            try
            {
                num_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, num_int]).Value.ToString();
            }
            catch
            {
            }
            batch_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, batch_int]).Text;

            if (File.Exists(pdfdir_textBox.Text + "\\" + ((MSEXCEL.Range)worksheet.Cells[current_row, pdffilename_int]).Text + ".pdf"))
            {
                current_pdffilename = pdfdir_textBox.Text + "\\" + ((MSEXCEL.Range)worksheet.Cells[current_row, pdffilename_int]).Text + ".pdf";
            }
            else
            {
                current_pdffilename = pdfdir_textBox.Text + "\\" + ((MSEXCEL.Range)worksheet.Cells[current_row, notfilter_int]).Text + ".pdf";
            }
            //idenmsg_textBox.Text = name_textBox.Text;
            notequ_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, notequ_int]).Text;
            notfilter_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, notfilter_int]).Text;
            reason_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, reason_int]).Text;
            mode_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, mode_int]).Text;
            m1_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, m1_int]).Text;
            m2_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, m2_int]).Text;
            m3_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, m3_int]).Text;
            m4_textBox.Text = ((MSEXCEL.Range)worksheet.Cells[current_row, m4_int]).Text;
            
            try
            {
                //处理pdf
                PdfDocument pdfdoc = new PdfDocument(); //创建一个PdfDocument类对象，加载PDF文档
                pdfdoc.LoadFromFile(current_pdffilename);
                ListImage = new List<Image>();  //声明List类对象

                for (int i = 0; i < pdfdoc.Pages.Count; i++)    //遍历PDF文档所有页面，获取文档所有页，并提取页面中的所有图片
                {
                    Image images;
                    images = pdfdoc.SaveAsImage(i);
                    ListImage.Add(images);
                }
                pdfdoc.Close();
                image = ListImage[pdfpage];
                pdf_pictureBox.Image = image;   //将获取到的图片显示出来

                if (iscopypdf_checkBox.Checked == true)
                {
                    FileInfo file = new FileInfo(current_pdffilename);
                    if (file.Exists)
                    {
                        file.CopyTo(copypdf_textBox.Text + "\\" + file.Name + ".pdf",true);
                    }
                }
                msg_richTextBox.Visible = false;
            }
            catch (Exception file_e)
            {
                msg_richTextBox.Text = file_e.Message;
                msg_richTextBox.Text = "文件不存在或错误！";
                msg_richTextBox.Visible = true;
            }
            pageredirect_button.Enabled = true;
            previous_button.Enabled = true;
            next_button.Enabled = true;
            idenmsg_button.Enabled = true;

            if (excelApp != null)
            {
                QuitExcel(ref excelApp);
            }
        }

        private void pageredirect_button_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pageredirect_textBox.Text) >= 1 && Convert.ToInt32(pageredirect_textBox.Text) <= iRowCount)
            {
                current_row = Convert.ToInt32(pageredirect_textBox.Text);
                data_process(Convert.ToInt32(pageredirect_textBox.Text), 0);
            }
        }

        private void copypdf_button_Click(object sender, EventArgs e)
        {
            if (copypdf_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                copypdf_textBox.Text = copypdf_folderBrowserDialog.SelectedPath;
            }
        }

        private void iscopypdf_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (iscopypdf_checkBox.Checked == true)
            {
                copypdf_button.Enabled = true;
                copypdf_textBox.Enabled = true;
            }
            else
            {
                copypdf_button.Enabled = false;
                copypdf_textBox.Enabled = false;
            }
        }

        private void idencolor_button_Click(object sender, EventArgs e)
        {
            if (iden_colorDialog.ShowDialog() == DialogResult.OK)
            {
                idencolor = iden_colorDialog.Color;
                idencolor_textBox.BackColor = idencolor;
            }
        }

        private void pdf_pictureBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            //System.Drawing.Size t = pdf_pictureBox.Size;
            //t.Width += e.Delta;
            //t.Height += e.Delta;
            //pdf_pictureBox.Width = t.Width;
            //pdf_pictureBox.Height = t.Height;
            if (e.Delta > 0)
            {
                pdf_pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pdf_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pdf_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (pdf_pictureBox.Image != null)
            {
                M_pot_p = e.Location;
                M_int_maxX = pdf_pictureBox.Width - pdf_pictureBox.Image.Width;
                M_int_maxY = pdf_pictureBox.Height - pdf_pictureBox.Image.Height;
                Cursor = Cursors.Hand;
            }
        }

        private void pdf_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pdf_pictureBox.Image != null)//当按左键的时候
            {
                //算差值
                M_int_mx = M_int_mx - M_pot_p.X + e.X;
                M_int_my = M_int_my - M_pot_p.Y + e.Y;
                //锁定范围
                M_int_mx = Math.Min(0, Math.Max(M_int_maxX, M_int_mx));
                M_int_my = Math.Min(0, Math.Max(M_int_maxY, M_int_my));
                Graphics g = pdf_pictureBox.CreateGraphics();
                g.DrawImage(pdf_pictureBox.Image, new Rectangle(0, 0, pdf_pictureBox.Width, pdf_pictureBox.Height), new Rectangle(-M_int_mx, -M_int_my, pdf_pictureBox.Width, pdf_pictureBox.Height), GraphicsUnit.Pixel);

                M_pot_p = e.Location;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        public void QuitExcel(ref Microsoft.Office.Interop.Excel.Application application)
        {
            application.Quit();
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                application = null;
                GC.Collect();
            }
        }

    }
}
