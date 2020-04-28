// 1. 다음과 같은 배열이 있다고 할 때, Cost는 50 이상, MaxSpeed는 150 이상인 레코드만 조회하는 LINQ를 작성하세요.

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

class Car
{
    public int Cost { get; set; }
    public int MaxSpeed { get; set; }
}
class MainApp
{
    static void Main(string[]args)
    { 
Car[] cars =
{
    new Car(){Cost=  56, MaxSpeed= 120},
    new Car(){Cost=  70, MaxSpeed= 150},
    new Car(){Cost=  45, MaxSpeed= 180},
    new Car(){Cost=  32, MaxSpeed= 200},
    new Car(){Cost=  82, MaxSpeed= 280},
};

    var selected =
        from car in cars
        where car.Cost >= 50 && 
        car.MaxSpeed >= 150
        select new
        {
            cost = car.Cost,
            maxspeed = car.MaxSpeed
        };

foreach (var car in selected)
    WriteLine($"Cost={0}, MaxSpeed={1}", car.cost, car.maxspeed);
}
}



    /* Cost가 50 이상, MaxSpeed는 150 이상인 레코드를 조회하는 LINQ */;