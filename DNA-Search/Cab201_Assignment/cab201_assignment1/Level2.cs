using System;
using System.IO;
using System.Linq;

namespace cab201_assignment1
{
    public class Level2
    {
        public void Level2_search(string flag, string file_name, string search_text)
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
                        if (line.StartsWith(">"))
                        {
                            string Sequence = File.ReadLines(file_name).Skip(line_no).First();// Part 2 of the sequence
                            Console.WriteLine(line + Environment.NewLine + Sequence);
                            contains_text = true;
                            //line_no = 0; //reset line count
                            



                        }
                        else
                        {
                            string Name = File.ReadLines(file_name).Skip(line_no - 2).First();// Part 1 of the sequence
                            Console.WriteLine(Name + Environment.NewLine + line);
                            contains_text = true;
                            //line_no = 0; //reset line count
                            


                        }

                    }

                }
                if (contains_text == false)
                {
                    Console.WriteLine("Error, sequence {0} does not exist", search_text);
                    
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