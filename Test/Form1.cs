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
using Test.Modules;
using Test.Moduls;

namespace Test
{
    public partial class Form1 : Form
    {
        string status = "Load";

        
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
            DataBase dataBaseOpen = new DataBase();
            files = dataBaseOpen.LoadBD();
            for (int i = 0; i < files.Count; i++)
            {
                if (textBoxFileName.Text == files[i].Name)
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
            button_FindFile_Load.Visible = true;
        }
        private void OpenInvisible()
        {
            label_Key.Visible = false;
            textBox_Key.Visible = false;
            button_Key.Visible = false;
            button_FindFile_Load.Visible = false;
        }
        private void Clear()
        {
            textBoxFileName.Clear();
            textBoxValue.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash()
            DataBase dataBase;
            FileManagement fileManagement; 
            switch (status)
            {
                case "Load":
                    bool ItsValue = true;
                    dataBase = new DataBase();
                    fileManagement = new FileManagement();
                    files = dataBase.LoadBD();
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (textBoxValue.Text == fileManagement.LoadFiles(files[i].Link) && textBoxFileName.Text != files[i].Name)
                        {
                            if (dataBase.SaveBD(files[i].Key, textBoxFileName.Text, files[i].Link, ))
                            {
                                ItsValue = false;
                                MessageBox.Show($"Содержимое этого файла уже имеется в файле под номером {files[i].Key}");
                            }
                            break;
                        }

                    }
                    if(ItsValue)
                    {
                        if (dataBase.SaveBD(textBoxFileName.Text))
                        {
                            fileManagement.SaveFiles(textBoxFileName.Text, textBoxValue.Text);
                        }
                    }
                break;

                case "Delete":

                    dataBase = new DataBase();
                    fileManagement = new FileManagement();
                    files = dataBase.LoadBD();
                    try
                    {
                        for (int i = 0; i < files.Count; i++)
                        {
                            if (textBoxFileName.Text == files[i].Name)
                            {
                                
                                if (files[i].Last(files[i],i))
                                {
                                    fileManagement.DeleteFiles(files[i].Link);
                                }
                                dataBase.DeleteBD(files[i].Name);

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
                DataBase bdOpen = new DataBase();
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
