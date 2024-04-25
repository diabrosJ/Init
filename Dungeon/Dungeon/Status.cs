using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Status
    {

        public string Name;
        public int Lv;
        public int Str;
        public int Def;
        public int Hp;
        public int Gold;
        public int menu;

        public Status(string name, int lv, int str, int def, int hp, int gold)
        { //생성자 < 

            Name = name;
            //이름
            Lv = lv;
            //레벨
            Str = str;
            //공격력
            Def = def;
            //방어력
            Hp = hp;
            //체력
            Gold = gold;
            //골드
        }
        public void MyStatus()
        {
            Console.Clear();

            while (true)
            {

                Console.WriteLine("캐릭터 정보");
                Console.WriteLine($"Lv : {Lv}");
                Console.WriteLine($"공격력 : {Str}");
                Console.WriteLine($"방어력 : {Def}");
                Console.WriteLine($"체력 : {Hp}");
                Console.WriteLine($"골드 : {Gold}");
                Console.WriteLine("");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("원하시는 행동을 입력해주세요.");

                string input = Console.ReadLine();
                int.TryParse(input, out menu);
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n지정된 값이 아닙니다.\n");
                        break;
                }
            }

        }
    }
}
