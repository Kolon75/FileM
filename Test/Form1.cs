using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Classes;
using Test.Moduls;

namespace Test
{
    public partial class Form1 : Form
    {
        string status = "Load";
        string path;
        string[] strings;
        string fileName;
        string fileValue;
        
        List<Classes.File> files = new List<Classes.File>();
        public Form1()
        {
            InitializeComponent();
            label_Name.Text = "Загрузить";
            
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Load";
            buttonLoad.Visible = true;
            buttonLoad.Text = "Загрузить";
            label_Name.Text = "Загрузить";
            OpenInvisible();
            Clear();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Open";
            buttonLoad.Visible = false;
            label_Name.Text = "Открыть";
            OpenVisible();
            Clear();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Delete";
            buttonLoad.Visible = true;
            buttonLoad.Text = "Удалить";
            label_Name.Text = "Удалить";
            label_Key.Visible = false;
            textBox_Key.Visible = false;
            button_Key.Visible = false;
            OpenInvisible();
            Clear();

        }
        private void button_FindFile_Load_Click(object sender, EventArgs e)
        {
            bool ItsUnic = true;
            fileName = textBoxFileName.Text;
            fileValue = textBoxValue.Text;
            BD bdOpen = new BD();
            FileMenegment fileMenegmentOpen = new FileMenegment();
            files = bdOpen.LoadBD();
            for (int i = 0; i < files.Count; i++)
            {
                if (fileName == files[i].Name)
                {
                    MessageBox.Show($"Файл с таким именем имеет ключ {files[i].Key}");
                    textBox_Key.Text = files[i].Key.ToString();
                    ItsUnic = false;
                }

            }
            if (ItsUnic)
            {
                MessageBox.Show($"Файла с таким именем имеет нет");
            }
            
        }
        private void OpenVisible()
        {
            label_Key.Visible = true;
            textBox_Key.Visible = true;
            button_Key.Visible = true;
            button_FindFile_Load.Text = "Найти ключ";
        }
        private void OpenInvisible()
        {
            label_Key.Visible = false;
            textBox_Key.Visible = false;
            button_Key.Visible = false;
            button_FindFile_Load.Text = "Выйбрать файл";
        }
        private void Clear()
        {
            textBoxFileName.Clear();
            textBoxValue.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            BD bd;
            FileMenegment fileMenegment; 
            fileName = textBoxFileName.Text;
            fileValue = textBoxValue.Text;
            switch (status)
            {
                case "Load":
                    bool ItsName = true;
                    bool ItsValue = true;
                    bd = new BD();
                    fileMenegment = new FileMenegment();
                    files = bd.LoadBD();
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (fileName == files[i].Name)
                        {
                            ItsName = false;
                            MessageBox.Show($"Такое название файла уже используется");
                        }

                    }
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (fileValue == fileMenegment.LoadFiles(files[i].Link) && ItsName)
                        {   
                            ItsValue = false;
                            MessageBox.Show($"Содержимое этого файла уже имеется в файле под номером {files[i].Key}");
                            bd.SaveBD(files[i].Key, fileName, files[i].Link);
                            break;
                        }

                    }
                    if(ItsName && ItsValue)
                    {
                        bd.SaveBD(fileName);
                        fileMenegment.SaveFiles(fileName, fileValue);
                    }
                break;

                case "Delete":
                    
                    bd = new BD();
                    fileMenegment = new FileMenegment();
                    files = bd.LoadBD();
                    try
                    {
                        for (int i = 0; i < files.Count; i++)
                        {
                            if (fileName == files[i].Name)
                            {
                                
                                if (files[i].Last(files[i],i))
                                {
                                    fileMenegment.DeleteFiles(files[i].Link);
                                }
                                bd.DeleteBD(files[i].Name);

                            }

                        }
                    }
                    catch
                    {

                    }
                    break;

            }
            
        }

        private void button_Key_Click(object sender, EventArgs e)
        {
            try
            {
                BD bdOpen = new BD();
                files = bdOpen.LoadBD();
                using (StreamReader reader = new StreamReader(bdOpen.LoadPath(int.Parse(textBox_Key.Text))))
                {
                    textBoxValue.Text = reader.ReadToEnd();
                }  
            }
            catch (Exception)
            {
                MessageBox.Show("Файла с таким ключём не сушествует");
            }
            
        }
    }
}
