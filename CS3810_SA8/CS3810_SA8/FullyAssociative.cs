using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3810_SA8
{
    class Program
    {
        static void Main(string[] args)
        {
            //FullyAssociative();
            //DirectMapped();
            SetAssociative();
        }


        private static void SetAssociative()
        {
            int bytesPerBlock = 8;  // 8 byte block size
            int rowCount = 4;       // 4 rows
            int ways = 2;           // 2 ways

            // The instructions to be executed
            //int[] instructions = { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140 };
            int[] instructions = { 16, 20, 24, 28, 32, 36, 60, 64, 56, 60, 64, 68, 56, 60, 64, 72, 76, 92, 96, 100, 104, 108, 112, 120, 124, 128, 144, 148 };

            // Make a new cache with the specified number of ways for each row, and put it in the array.
            // Make an array of FullyAssociative caches.
            Cache[] cache = new Cache[rowCount];
            for(int k = 0; k < rowCount; k++)
            {
                cache[k] = new Cache(ways);     //Each cache should be a (way) row fully associative
            }

            //Number of times to iterate through the instructions
            int iterations = 5;

            for (int j = 0; j < iterations; j++)
            {
                for (int i = 0; i < instructions.Length; i++)
                {
                    int tag = instructions[i] / (bytesPerBlock * rowCount);
                    int row = instructions[i] / bytesPerBlock % rowCount;


                    Cache CurrentRowCache = cache[row];
                    
                    // Print the data
                    if (true)
                    {
                        //Get the data from the row in each way, and store it. Compare if the tag is in them
                        if (CurrentRowCache.GetDataFullyAssoc(tag)) // If there is a tag in the specified row that matches the provided tag
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tRow: \t" + row + "\tHit");
                        }
                        else
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tRow: \t" + row + "\tMiss");
                        }
                    }
                }
                Console.WriteLine("Iteration " + j + " completed.");
            }
            Console.Read(); //Let the console stop so we can see the output.
        }


        private static void DirectMapped()
        {
            int bytesPerBlock = 16;//4; //4 byte block size
            int rowCount = 4;//16;      // 16 rows

            // The instructions to be executed
            //int[] instructions = { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140 };
            int[] instructions = { 16, 20, 24, 28, 32, 36, 60, 64, 56, 60, 64, 68, 56, 60, 64, 72, 76, 92, 96, 100, 104, 108, 112, 120, 124, 128, 144, 148 };

            // Make a new cache with the specified number of rows.
            Cache cache = new Cache(rowCount);

            //Number of times to iterate through the instructions
            int iterations = 5;

            for (int j = 0; j < iterations; j++)
            {
                for (int i = 0; i < instructions.Length; i++)
                {
                    int tag = instructions[i] / (bytesPerBlock * rowCount);
                    int row = instructions[i] / bytesPerBlock % rowCount;

                    // Print the data
                    if (true)
                    {
                        if (cache.GetDataDirectMapped(row, tag)) // If there is a tag in the specified row that matches the provided tag
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tRow: \t" + row + "\tHit");
                        }
                        else
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tRow: \t" + row + "\tMiss");
                        }
                    }
                }
                Console.WriteLine("Iteration " + j + " completed.");
            }
            Console.Read(); //Let the console stop so we can see the output.
        }


        private static void FullyAssociative()
        {
            int bytesPerBlock = 8; //8 byte block size
            int rowCount = 8;    // 8 rows

            // The instructions to be executed
            //int[] instructions = { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140};
            int[] instructions = { 16, 20, 24, 28, 32, 36, 60, 64, 56, 60, 64, 68, 56, 60, 64, 72, 76, 92, 96, 100, 104, 108, 112, 120, 124, 128, 144, 148 };

            // Make a new cache with the specified number of rows.
            Cache cache = new Cache(rowCount);

            //Number of times to iterate through the instructions
            int iterations = 5;
            
            for (int j = 0; j < iterations; j++)
            {
                for (int i = 0; i < instructions.Length; i++)
                {
                    int tag = instructions[i] / bytesPerBlock;


                    // Print the data
                    if (true)
                    {
                        if (cache.GetDataFullyAssoc(tag)) // If there is a tag in the specified row that matches the provided tag
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tHit");
                        }
                        else
                        {
                            Console.WriteLine("Accessing instruction: \t" + instructions[i] + "\tTag: \t" + tag + "\tMiss");
                        }
                    }                   
                }
                Console.WriteLine("Iteration " + j + " completed.");
            }
            Console.Read(); //Let the console stop so we can see the output.
        }
    }




    /// <summary>
    /// Represents a cache.
    /// </summary>
    class Cache
    {
        public CacheRow[] cache;
        public int currentLRU;

        public Cache(int _numberOfCacheRows)
        {
            cache = new CacheRow[_numberOfCacheRows];
            currentLRU = 0;

            // Fill the cache with invalid rows
            for(int i = 0; i < cache.Length; i++)
            {
                cache[i] = new CacheRow(-1, -1, false);
            }
        }


        /// <summary>
        /// Try to access data with the given tag.
        /// If the tag matches, update the LRU then return true.
        /// if the tag does not match, then add the tag to the cache and return false.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns>If it matches return true; if not return false.</returns>
        public bool GetDataFullyAssoc(int tag)
        {
            int leastRecentlyUsed = currentLRU;
            int indexofLRU = -1;
            // Search the cache for the tag. If its there return true.
            // At the same time find the Least Recently Used 
            for(int i = 0; i < cache.Length; i++)
            {
                // Find the index of the LRU
                if(cache[i].LRU < leastRecentlyUsed)
                {
                    leastRecentlyUsed = cache[i].LRU;
                    indexofLRU = i;
                }

                // Check if the current element matches the tag
                // If it does, update the LRU
                if (cache[i].valid == true && cache[i].tag == tag)
                {
                    cache[i].LRU = ++currentLRU;
                    return true;
                }
            }

            // At this point its a cache miss. Replace the Least Recently Used cache entry with the new tag.
            // Set the valid bit to valid, and update the LRU.
            cache[indexofLRU].tag = tag;
            cache[indexofLRU].LRU = ++currentLRU;
            cache[indexofLRU].valid = true;
            return false;

        }

        /// <summary>
        /// Try to access data with the given row.
        /// If the tag matches, return true.
        /// if the tag does not match, then replace the old tag with the new tag in the row and return false.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns>If it matches return true; if not return false.</returns>
        public bool GetDataDirectMapped(int row, int tag)
        {
            if (cache[row].valid == true && cache[row].tag == tag)
                return true;
            
            // At this point its a cache miss. Replace the old tag with the new tag.
            // Return false;
            cache[row].tag = tag;
            cache[row].valid = true;
            return false;

        }




        /// <summary>
        /// Represents one row in a cache.
        /// </summary>
        public class CacheRow
        {
            public int tag;
            public int LRU;
            public bool valid;

            public CacheRow(int _tag, int _LRU, bool _valid)
            {
                tag = _tag;
                LRU = _LRU;
                valid = _valid;
            }

        }
    }
}
