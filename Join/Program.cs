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

        Product[] arrProduct =
        {
            new Product(){Titile="비트", Star="정우성"},
            new Product(){Title="CF 다수", Star="김태희"},
            new Product(){Title="아이리스", Star="김태희"},
            new Product(){Title="모래시계", Star="고현정"},
            new Product(){Title="Solo 예찬", Star="이문새"},
        };

        var listProfile = 
            from Profile in arrProfile
            join product in arrProduct on Profile.Name equals product.Star select new
    }
}
