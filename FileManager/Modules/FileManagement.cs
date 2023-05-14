using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Classes;

namespace FileManager.Modules
{
    internal class FileManagement
    {
        public void SaveFiles(string name, string value)
        {
            try 
            { 
            System.IO.File.AppendAllText(StoragePlace.PlacePath+name+".txt", value);
            MessageBox.Show("Файл добавлен в память!");
            
            }
            catch (Exception)
            {

                MessageBox.Show("Файл не попал в бд"); 
            }
        }
        public string LoadFiles(string path)
        {
            string text;
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();

            }
            return text;               
        }
        public void DeleteFiles(string path)
        {
            System.IO.File.Delete(path);
            MessageBox.Show("Файл удалён из памяти!");
        }
    }
}       

