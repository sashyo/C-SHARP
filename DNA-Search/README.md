# Genomic Sequence Retrieval Program

#### Run program in command line
* Download and unzip files
* locate "Search16s.exe", will be the bin\debug folder
* Open command prompt  , input
  * Cd {file path to "Search16s.exe"}
    * input queries

#### Current queries
> Note: 16S.fasta is the file that contains the DNA sequence to be scanned
  * Sequential access using a starting position in the file (-level1)
    * Example: **Search16s -level1 16S.fasta 273 10**
      * 273 is the line number to start output from and 10 is the number of sequences to output
  
  * Sequential access to a specific sequence by sequence-id (-level2)
    * Example: **Search16s -level2 16S.fasta NR_115365.1**
      * NR_115365.1 is the sequence-id to look for, if ID does not exist an error message will be outputed
  
  * Sequential access to find a set of sequence-ids given in a query file, and
writing the output to a specified result file
    * Example: **Search16s -level3 16S.fasta query.txt results.txt**
      * query.txt contains a list of sequence-ids to search for
      * results.txt contains result of all matching sequences between query.txt and 16S.fasta
      * for each sequence-id that is not found, a message should appear on console and not the result.txt file
 
 * Search for an exact match of a DNA query string (-level5)
    * Example: **Search16s -level5 16S.fasta CTGGTACGGTCAACTTGCTCTAAG**
      * "CTGGTACGGTCAACTTGCTCTAAG" sequence to scan for
      * output sequence-ids that contains the sequence
  
  * Search for a sequence meta-data containing a given word (-level6)
    * Example: **Search16s -level6 16S.fasta Streptomyces**
      * "Streptomyces" word to scan for
      * Outputs sequence-ids that correspond to sequences that match the word Streptomyces



