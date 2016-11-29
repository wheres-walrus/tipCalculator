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
            FullyAssociative();
        }

        private static void FullyAssociative()
        {
            int bytesPerRow = 8; //8 byte block size
            int rowCount = 8;    // 8 rows

            // The instructions to be executed
            int[] instructions = { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140};


            // Make a new cache with the specified number of rows.
            Cache cache = new Cache(rowCount);

            //Number of times to iterate through the instructions
            int iterations = 5;


            for (int j = 0; j < iterations; j++)
            {
                for (int i = 0; i < instructions.Length; i++)
                {
                    // int row = instructions[i] / bytesPerRow % rowCount;
                    int row = 0;
                    int tag = instructions[i] / (bytesPerRow * rowCount);
                    int offset = instructions[i] % bytesPerRow;

                    // Print the common case.
                    if (j == 3)
                    {
                        if (cache.getData(row, tag)) // If there is a tag in the specified row that matches the provided tag
                        {
                            Console.WriteLine("Accessing " + instructions[i] + "(tag " + tag + ") : hit");
                        }
                        else
                        {
                            Console.WriteLine("Accessing " + instructions[i] + "(tag " + tag + ") : miss");
                            
                            cache.miss(row, tag);

                        }

                    }
                    

                }

            }
            Console.Read();
        }
    }

    /// <summary>
    /// Represents a cache.
    /// </summary>
    class Cache
    {
        public CacheRow[] cache;
        public int numberOfCacheRows;
        public int currentLRU;

        public Cache(int _numberOfCacheRows)
        {
            numberOfCacheRows = _numberOfCacheRows;
            cache = new CacheRow[numberOfCacheRows];
            currentLRU = 0;
        }

        internal bool getData(int row, int tag)
        {
            
            for(int i = 0; i < cache.Length; i++)
            {
                if (cache[i] != null && cache[i].tag == tag)
                    return true;
            
            }
            return false;
        }

        internal void replace(int row, int tag)
        {
            // No need for the row right now, don't even use it


            int lowestLRU = currentLRU;
            
            int indexOfLowestLRU = -1; // This assumes there is alrady something in the cache
            for(int i = 0; i < cache.Length; i++)
            {
                if (cache[i] != null && cache[i].LRU < lowestLRU) // Find the lowest LRU and its index.
                {
                    lowestLRU = cache[i].LRU;
                    indexOfLowestLRU = i;
                }
            }

            // Replace the tag of the element with the lowest LRU, and reset the LRU.
            cache[indexOfLowestLRU].tag = tag;
            cache[indexOfLowestLRU].LRU = ++currentLRU;
        }

        internal void add(int row, int tag)
        {
            // Find an index that is null, and place tag there
            for(int i = 0; i < cache.Length; i++)
            {
                if(cache[i] == null)
                    cache[row] = new CacheRow(tag, ++currentLRU);
            }
            // If it gets to this point something is wrong
            //throw new InvalidOperationException();
        }

        internal void miss(int row, int tag)
        {
            bool hasEmptySpot = false;
            for(int i = 0; i < cache.Length; i++)
            {
                if (cache[i] == null)
                    hasEmptySpot = true;
            }
            if (hasEmptySpot)
                add(row, tag);
            else
                replace(row, tag);
        }



        /// <summary>
        /// Represents one row in a cache.
        /// </summary>
        public class CacheRow
        {
            public int tag;
            public int LRU;

            public CacheRow(int _tag, int _LRU)
            {
                tag = _tag;
                LRU = _LRU;
            }

        }
    }
}
