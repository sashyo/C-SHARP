using System;

namespace cab201_assignment1
{
    class Search16s
    {
        static void Main(string[] args)
        {
            cab201_assignment1.Level1 s1 = new Level1();
            cab201_assignment1.Level2 s2 = new Level2();
            cab201_assignment1.Level3 s3 = new Level3();
            cab201_assignment1.Level5 s5 = new Level5();
            cab201_assignment1.Level6 s6 = new Level6();

            //start search according to flag level also tests for user input
            try
            {
                if (args[0] == ("-level1"))
                {
                    try
                    {
                        s1.Level1_search(args[0], args[1], Convert.ToInt32(args[2]), Convert.ToInt32(args[3]));
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please try again" + Environment.NewLine + "E.g. Search16s -level1 filename.fasta 273 10 ");
                    }


                }

                else if (args[0] == ("-level2"))
                {
                    try
                    {
                        s2.Level2_search(args[0], args[1], args[2]);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please try again" + Environment.NewLine + "E.g. Search16s -level2 16S.fasta NR_115365.1");
                    }
                }
                else if (args[0] == ("-level3"))
                {
                    try
                    {
                        s3.Level3_search(args[0], args[1], args[2], args[3]);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please try again" + Environment.NewLine + "E.g. Search16s -level3 16S.fasta query.txt results.txt");
                    }

                }
                else if (args[0] == ("-level5"))
                {
                    try
                    {
                        s5.Level5_search(args[0], args[1], args[2]);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please try again" + Environment.NewLine + "E.g. Search16s -level5 16S.fasta CTGGTACGGTCAACTTGCTCTAAG ");
                    }
                }
                else if (args[0] == ("-level6"))
                {
                    try
                    {
                        s6.Level6_search(args[0], args[1], args[2]);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please try again" + Environment.NewLine + "E.g. Search16s -level6 16S.fasta Streptomyces ");
                    }
                }
                else if (args[0] != "-level1" || args[0] != "-level2" || args[0] != "-level3" || args[0] != "-level5" || args[0] != "-level6")
                {
                    Console.WriteLine(" Flag search level invalid, please input search levels from 1 - 3" + Environment.NewLine + " E.g. -level2");
                }
            }
            catch(System.SystemException)
            {
                Console.WriteLine("Invalid input, please enter search level" + Environment.NewLine + "E.g. -level1 , -level2 , -level3 , -level5 or -level6 ");
            }

        }

    }

}
