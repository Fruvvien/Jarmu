using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu
{
    internal class Orszagut
    {
        List<Jarmu> array = new List<Jarmu>();

        public void jarmuvekJonne(string fajlnev)
        {

            try {
                    StreamReader sr = new StreamReader(fajlnev);

                    while (!sr.EndOfStream)
                    {
                        
                        string[] lines = sr.ReadLine().Split(';');

                        if (lines[3] == "true" || lines[3] == "false")
                        {
                            this.array.Add(new AudiS8(lines[1], int.Parse(lines[2]), bool.Parse(lines[3])));
                        }
                        else
                        {
                            this.array.Add(new Robogo(lines[1], int.Parse(lines[2]), int.Parse(lines[3])));
                        }
                        
                    }


                } catch (IOException ex) {
                Console.WriteLine(ex);
            }

            

        }
        public void kiketMerunkBe()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("buntetes.txt"))
                {
                    foreach (var item in array)
                    {
                        if (item.GyorshajtottE(90))
                        {
                            sw.WriteLine(item.ToString() + " gyorshajtott");
                        }
                        if (!item.HaladahatItt(90))
                        {
                            sw.WriteLine(item.ToString() + " haladhat itt");
                        }
                    }
                    sw.Close();
                }
            }catch(IOException ex) 
            {
                Console.WriteLine(ex);
             }

            
        }

    }
}
