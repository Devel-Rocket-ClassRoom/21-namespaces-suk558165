using System;
using FormalMsg = Formal.Message;
using CasualMsg = Casual.Message;

Console.WriteLine("=== 인사 테스트 ===");

// 2. 격식체 테스트
Console.WriteLine("[격식체]");
FormalMsg f = new FormalMsg(); // 별칭을 사용해 객체 생성
f.SayHello("홍길동");
f.SayBye("홍길동");


Console.WriteLine("\n[비격식체]");
CasualMsg M = new CasualMsg();
M.SayHello("홍길동");
M.SayBye("홍길동");

namespace Formal
{

    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕하십니까!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕히 가십시오!");
        }
    }
}
namespace Casual
{ 

    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, [{name}]!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, [{name}]!");
        }
    }
}

