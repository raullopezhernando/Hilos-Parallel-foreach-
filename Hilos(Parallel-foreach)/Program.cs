using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hilos_Parallel_foreach_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\RaúlLópez\Desktop\ArchivosdeTrabajo\Hilos\ImagenesPrueba\Fotos1\";
            string path2 = @"C:\Users\RaúlLópez\Desktop\ArchivosdeTrabajo\Hilos\ImagenesPrueba\Fotos2\";

            string[] lst = Directory.GetFiles(path1);

            //int a = 1;

            ////foreach (var archivo in lst) 
            ////{

            ////    File.Copy(archivo, path2 + "a" + a + ".jpg");
            ////    a++;
            ////}

            Random r = new Random(1000000);
            Parallel.ForEach(lst, (archivo) => { 
                int a = r.Next();
                File.Copy(archivo, path2 + "a" + a + ".jpg");

            });





        }
    }
}
