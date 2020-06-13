using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_print_all_subsequences_of_the_sequence_cs
{
    class Program
    {
        public static List<string> generate_all_subsequences(string sequence)
        {
            if (sequence.Length == 0)
            {
                // null string 
                List<string> empty = new List<string> { };
                empty.Add(sequence);
                return empty;
            }

            List<string> subsequences = new List<string> { };
            char current_char = sequence[0];
            subsequences = generate_all_subsequences(sequence.Substring(1));

            // generate all possible sub-sequences by adding the current current_char
            // step :1 dump all the previously generated sub-sequences from subsequences into all_subsequences list 
            // step :2 generate new sub-sequences  by adding current_char to all the previously generated sub-sequences.

            List<string> all_subsequences = new List<string> { } ; 

            foreach( string subsequence in subsequences )
            {
                all_subsequences.Add(subsequence);
                all_subsequences.Add(subsequence + current_char);
            }
            return all_subsequences ;
        }

        public static void print_all_subsequences(List<string> subsequences)
        {
            // print all the sub-sequences in the list 

            foreach (string subsequence in subsequences)
            {
                Console.WriteLine(subsequence + ",");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string sequence;
            List<string> subsequences = new List<string> { };
            Console.Write("enter a string sequence :");
            sequence = Console.ReadLine();

            //Console.WriteLine("entered sequence is :" + sequence);

            // pass the sequence to function to calculate the sub-sequences 
            subsequences = generate_all_subsequences(sequence);
            Console.WriteLine("all sub-sequences of the entered sequence : "+ sequence + " are " );
            print_all_subsequences(subsequences);
            Console.ReadLine();
        }
    }
}
