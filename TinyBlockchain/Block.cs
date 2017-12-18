﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace TinyBlockchain
{
    public struct Block
    {
        public int Index { get; }
        public DateTime Timestamp { get; }
        public string Data { get; }
        public string PreviousHashCode { get; }

        public Block(int index, DateTime timestamp, string data, string previousHashCode)
        {
            Index = index;
            Timestamp = timestamp;
            Data = data;
            PreviousHashCode = previousHashCode;
        }

        public string HashValue()
        {
            return Hasher.GetHash(this);
        }
    }
}


//class Block :
//    def __init__(self, index, timestamp, data, previous_hash):
//    self.index = index
//    self.timestamp = timestamp
//    self.data = data
//    self.previous_hash = previous_hash
//    self.hash = self.hash_block()


//    def hash_block(self):
//    sha = hasher.sha256()
//    sha.update(str(self.index) + 
//    str(self.timestamp) + 
//    str(self.data) + 
//    str(self.previous_hash))
//    return sha.hexdigest(