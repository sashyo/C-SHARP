using System;
using System.IO;
using System.Linq;
namespace cab201_assignment1
{
    public class Level6
    {
        public void Level6_search(string flag, string file_name, string search_text)
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
                            //string Sequence = File.ReadLines(file_name).Skip(line_no).First();// DNA 
                            string ID = line.Split(' ')[0];
                            if (ID.StartsWith(">"))
                            {
                                ID = ID.Substring(1);
                            }
                            Console.WriteLine(ID);
                            contains_text = true;
                            
                            





                        }
                        else
                        {
                            string Name = File.ReadLines(file_name).Skip(line_no - 2).First();// Part 1 of the sequence
                            
                            Console.WriteLine("Error, level 6 does not search for DNA query string, please try searching for a word instead. E.g Streptomyces ");
                            contains_text = true;
                            break;



                        }

                    }

                }
                if (contains_text == false)
                {
                    Console.WriteLine("Error,word {0} does not exist", search_text);

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
