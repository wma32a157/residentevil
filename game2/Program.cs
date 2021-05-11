using System;
using System.Collections.Generic;

namespace game2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 환영한다.
            Console.WriteLine("환영한다..이방인이여..");


            // 플레이어 이름 무작위 생성
            // 숫자 무작위만 배웠다. -> 지정된 문자 내에서 무작위로 생성하자
            // 1. 문자열 여러개를 미리 설장
            // 2. 거기서 무작위로 지정하자...
            List<string> names = new List<string>();  // 90% List, 10 : Dictionary, ,......
            //Dictionary<string, string> nameMap = new Dictionary<string, string>(); // 사전
               //nameMap["레온"] = "GDI 책임 사령관";
            //nameMap["크리스"] = "운 빨 드럽게 없는 BSAA 말년 대장";
            //nameMap["에단"] = "운빨 드럽게 없는 민간인";
            //nameMap.Add("레온", "크리스");


            names.Add("에단 윈터스"); // 0
            names.Add("크리스 레드필드");  // 1
            names.Add("알버트 웨스커"); // 2
            names.Add("미아 윈터스"); // 3
            names.Add("레온 케네디"); // 4
            names.Add("헝크 케네디"); // 5
            names.Add("김두한"); // 5
            names.Add("카나메 마도카"); // 6
            names.Add("미키 사야카"); // 7
            names.Add("아케미 호무라"); // 8


            Random random = new Random();

            // 0부터 시작한다.

            int index = random.Next(names.Count);
            string PlayerName = names[index];


            // 플레이어 능력치를 입력하라...Power, hp
            string PowerString = Console.ReadLine(); // 힘
            string hpString = Console.ReadLine(); // hp

            int iPower;
            int nPower;
            int _Power;
            int mPower;

            int Power = int.Parse(PowerString);
            int hp = int.Parse(hpString);

            Player player = new Player(PlayerName, Power, hp);


            //Console.Read();
            //Console.ReadKey();


            //적 한마리를 만들어서 죽이자!

            Enemy enemy = new Enemy();
            enemy.hp -= player.power;


        }
    }
}
