using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Modules;

namespace FileManager.Classes
{
    internal class File
    {
        public File(int key, string name, string link, string hash)
        {
            Key = key;
            Name = name;
            Link = link;
            Hash = hash;
        }

        public int Key { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Hash { get; set; }

        public bool Last(File file, int p)
        {
            List<Classes.File> files = new List<Classes.File>();
            DataBase dataBase = new DataBase();
            bool last = false;
            files = dataBase.LoadBD();
            for (int i = 0; i < files.Count; i++)
            {
                if (file.Link == files[i].Link && p == i)
                {
                    last = true;
                }
                if (file.Link == files[i].Link && p != i)
                {
                    last = false;
                    break;
                }
            }

            return last;
        }
    }
}
