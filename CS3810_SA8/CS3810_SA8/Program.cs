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
            int rowCount = 8;  // 8 rows

            int[] instructions = { 4, 8, 20, 24, 28, 36, 44, 20, 24, 28, 36, 40, 44, 68, 72, 92, 96, 100, 104, 108, 112, 100, 112, 116, 120, 128, 140};

            //Number of times to iterate through the instructions
            int iterations = 5;

            for (int j = 0; j < iterations; j++)
            {
                for (int i = 0; i < instructions.Length; i++)
                {
                    int row = instructions[i] / bytesPerRow % rowCount;
                    int tag = instructions[i] / (bytesPerRow * rowCount);


                }

            }
        }
    }

    /// <summary>
    /// Represents a cache.
    /// </summary>
    class Cache
    {
        public List<CacheRow> cache;
        public int numberOfCacheRows;

        Cache(int _numberOfCacheRows)
        {
            cache = new List<CacheRow>();
            numberOfCacheRows = _numberOfCacheRows;
        }



        /// <summary>
        /// Represents one row in a cache.
        /// </summary>
        public class CacheRow
        {
            public int tag;
            public bool valid;
            public int LRU;

            CacheRow(int _tag, bool _valid, int _LRU)
            {
                tag = _tag;
                valid = _valid;
                LRU = _LRU;
            }

        }
    }
}
