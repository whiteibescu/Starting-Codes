﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialiaztion
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
           Stream ws = new FileStream("a.data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            NameCard nc = new NameCard();
            nc.Name = "박상현";
            nc.Phone = "010-123-4567";
            nc.Age = 33;

            serializer.Serialize(ws, nc);
            ws.Close();

            Stream rs = new FileStream("a.data", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            Console.WriteLine($"Name: {nc2.Name}");
            Console.WriteLine($"Name: {nc2.Phone}");
            Console.WriteLine($"Name: {nc2.Age}");
        }
    }
}