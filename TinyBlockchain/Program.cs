using System;

namespace TinyBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRST BLOCK
            var block1 = new Block(0, DateTime.Now, "Hello World!", "0");
            Blockchain.AddBlock(block1);

            //BLOCK #2
            var block2 = new Block(1, DateTime.Now, "This is the second block", block1.HashValue());
            Blockchain.AddBlock(block2);

            //BLOCK #3
            var block3 = new Block(1, DateTime.Now, "Now we have three blocks in our blockchain", block2.HashValue());
            Blockchain.AddBlock(block3);

            //BLOCK #4
            var block4 = new Block(1, DateTime.Now, "Hey! what a blockchain!", block3.HashValue());
            Blockchain.AddBlock(block4);


        }
    }
}
