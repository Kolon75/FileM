﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Moduls;

namespace Test.Classes
{
    internal class File
    {
        public File(int key, string name, string link)
        {
            Key = key;
            Name = name;
            Link = link;
        }

        public int Key { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public bool Last(File file, int p)
        {
            List<Classes.File> files = new List<Classes.File>();
            BD bd = new BD();
            bool last = false;
            files = bd.LoadBD();
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
            bool aa = last;

            return last;
        }
    }
}