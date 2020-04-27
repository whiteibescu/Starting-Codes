using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }        
        }
    }
class Product
{
    public string Title { get; set; }
    public string Star { get; set; }
}

class Mainapp
{
    static void Main(string[] args)
    {
        Profile[] arrProfile =
        {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 },
        };

        Product[] arrProduct
    }
}
