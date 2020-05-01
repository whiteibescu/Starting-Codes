using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializingCollection
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }

        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp
        static void Main(string[] args)
    {
        Stream ws = new FileStream("a.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter().;
    }
}
