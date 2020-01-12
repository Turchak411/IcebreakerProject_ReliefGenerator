using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliefGenerator
{
    public class FileManager
    {
        private string _path;

        private FileManager() { }

        public FileManager(string path)
        {
            _path = path;
        }

        public void SaveMap(int[,] mapDepths)
        {
            using (StreamWriter fileWriter = new StreamWriter(_path))
            {
                // Save map Y-dimention:
                fileWriter.WriteLine(mapDepths.GetLength(0));

                // Save map X-dimention:
                fileWriter.WriteLine(mapDepths.GetLength(1));

                for (int i = 0; i < mapDepths.GetLength(0); i++)
                {
                    for (int k = 0; k < mapDepths.GetLength(1); k++)
                    {
                        fileWriter.WriteLine(mapDepths[i, k]);
                    }

                    fileWriter.WriteLine(";");
                }
            }
        }
    }
}
