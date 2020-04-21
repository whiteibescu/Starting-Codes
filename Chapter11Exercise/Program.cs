/*

1. 다음 코드에서 문제를 찾고, 그 원인을 설명하세요.

using System.Collections.Generic;

Queue queue = new Queue();
queue.Enqueue(10);
queue.Enqueue("한글");
Queue.Enqueue(3.14);

Queue<int> queue2 = new Queue<int>();
queue2.Enqueue(10);
queue2.Enqueue("한글");
queue2.Enqueue(3.14);


정답 ====== 첫번째 Queue는 모든형에 대한 값을 받을수있다.

            두번째는 int 형으로 할당했기 때문에 10이라는 값을 제외한 나머지 변수들은 int형이 아니라서 불가합니다.


2.다음 코드에서 1)에 들어갈 내용은 무엇입니까?

Dictionary<string> dic = new Dictionary<string>();

dic["하나"] = "one"
dic["둘"] = "two"
dic["셋"] = "three"
dic["넷"] = "four"
dic["다섯"] = "five"

Console.WriteLine(Dictionary["하나"]);
Console.WriteLine(Dictionary["둘"]);
Console.WriteLine(Dictionary["셋"]);
Console.WriteLine(Dictionary["넷"]);
Console.WriteLine(Dictionary["다섯"]);

*/