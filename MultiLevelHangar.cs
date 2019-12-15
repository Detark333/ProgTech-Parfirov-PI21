using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    public class MultiLevelHangar
    {
        List<Hangar<ITransport>> hangarStages;        private const int countPlaces = 20;        private int pictureWidth, pictureHeight;        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Hangar<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }        public void SaveData(string filename)
        {

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter fs = new StreamWriter(filename))
            {

                fs.WriteLine("CountLeveles:" + hangarStages.Count);
                foreach (var level in hangarStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var plain = level[i];
                            if (plain != null)
                            {

                                if (plain.GetType().Name == "Plain")
                                {
                                    fs.Write(i + ":Plain:");
                                }
                                if (plain.GetType().Name == "Bomber")
                                {
                                    fs.Write(i + ":Bomber:");
                                }
                                fs.WriteLine(plain);
                            }
                        }
                        finally { }
                    }
                }

            }
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (hangarStages != null)
                    {
                        hangarStages.Clear();
                    }
                    hangarStages = new List<Hangar<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport plain = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        hangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Plain")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        plain = new Plain(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "Bomber")
                    {
                        plain = new Bomber(buffer.Split(':')[2]);
                    }
                    hangarStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = plain;
                }
            }
            return true;
        }
        public void Sort()
        {
            hangarStages.Sort();
        }
    }
}
