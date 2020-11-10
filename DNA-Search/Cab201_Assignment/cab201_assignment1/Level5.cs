using System;
using System.IO;
using System.Linq;
namespace cab201_assignment1
{
    public class Level5
    {
        public void Level5_search(string flag, string file_name, string search_text)
        {
            int line_no = 0;
            bool contains_text = false;
            


            try
            {


                var lines = File.ReadLines(file_name);
                foreach (var line in lines)
                {
                    
                    line_no++;
                    
                    


                    if (line.Contains(search_text))
                    {

                        {
                            string Name = File.ReadLines(file_name).Skip(line_no - 2).First();// Part 1 of the sequence
                            string ID = Name.Split(' ')[0];
                            if(ID.StartsWith(">"))
                            {
                                ID = ID.Substring(1);
                            }
                            Console.WriteLine(ID);
                            contains_text = true;
                            




                        }
                       

                    }
                    
                }
                if (contains_text == false)
                {
                    Console.WriteLine("Error, DNA sequence {0} does not exist", search_text);

                }

                contains_text = false; // reset   

            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot find File, please try again");
            }

        }

    }
}
