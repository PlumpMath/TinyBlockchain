using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TinyBlockchain
{
    public static class Blockchain
    {
        public static SortedList<int, Block> Value = new SortedList<int, Block>();

        public static void AddBlock(Block block)
        {
            int index = Value.Keys.Count + 1;
            Value.Add(index, block);

            Console.WriteLine("[New bloc added] - Index : " + index);
            Console.WriteLine("[Previous Hash]: " + block.PreviousHashCode);
            Console.WriteLine("[Current Hash]:  " + block.HashValue());
            Console.WriteLine();
        }
    }
}