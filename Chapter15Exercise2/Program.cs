//2.다음코드에서 car.Where(c => c.Cost < 60).OrderBy(c => c.Cost)와 동일한 결과를 반환하는 LINQ를 작성하세요.

class Car
{
    public int Cost { get; set; }
    public int MaxSpeed { get; set; }
}

Car[] cars =
{
    new Car(){Cost=  56, MaxSpeed= 120},
    new Car(){Cost=  70, MaxSpeed= 150},
    new Car(){Cost=  45, MaxSpeed= 180},
    new Car(){Cost=  32, MaxSpeed= 200},
    new Car(){Cost=  82, MaxSpeed= 280},
};

var selected = cars.Where(class => c.Cost < 60).OrderBy(class => c.Cost);