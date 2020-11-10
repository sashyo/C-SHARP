using System;
using System.IO;
using System.Linq;


namespace cab201_assignment1
{
    public class Level1
    {
        // Level1 search, finding a sequence by ordinal position
        public void Level1_search(string flag, string file_name, int start_line, int sequence_no)
        {
            if (start_line % 2 == 0)
            {
                Console.WriteLine("Input invalid, line number must be odd");
                return;
            }
            else
            {

                try
                {

                    for (int i = 0; i < sequence_no; i++)
                    {
                        string Name = File.ReadLines(file_name).Skip(start_line - 1).First(); // Part one of the sequence
                        string Sequence = File.ReadLines(file_name).Skip(start_line).First();// Part 2 of the sequence 

                        String DNA_sequence = Name + Environment.NewLine + Sequence;

                        Console.WriteLine(DNA_sequence);

                        start_line = start_line + 2; // to get to the next whole sequence (part one and two), one sequence takes up two lines
                    }

                }

                catch (FileNotFoundException)
                {
                    Console.WriteLine("Cannot find File, please try again");
                }
                catch(System.InvalidOperationException)
                {
                    Console.WriteLine("End of search, there are no more sequences");
                }

            }

        }

    }

}
