using System;
using System.IO;
using System.Linq;

namespace cab201_assignment1
{
    public class Level3
    {
        public string query_text { get; set; }


        public void Level3_search(string flag, string file_name, string query_file, string output_file)
        {
            try
            {
                StreamWriter results = new StreamWriter(output_file);
                var query = File.ReadLines(query_file);
                var fasta = File.ReadLines(file_name);
                int line_no = 0;
                bool contains_text = false;


                foreach (var query_line in query)
                {
                    query_text = query_line;

                    foreach (var line in fasta)
                    {

                        line_no++;

                        if (line.Contains(query_line))
                        {

                            string Sequence = File.ReadLines(file_name).Skip(line_no).First();// Part 2 of the sequence
                            results.WriteLine(line + Environment.NewLine + Sequence);


                            contains_text = true;

                            //line_no = 0;// result line count for next loop
                            break;

                        }

                        else
                        {
                            contains_text = false;
                        }

                    }

                    if (contains_text == false)
                    {
                        Console.WriteLine("Error, sequence {0} does not exist", query_text);


                    }
                    //line_no = 0; // results line count
                }
                results.Close();
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot find File, please try again");
            }


        }
    }
}
