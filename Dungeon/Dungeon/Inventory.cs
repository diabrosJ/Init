using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Inventory
    {
        public int menu;
        Status status;
        Item equipItem;
        List<Item> getitems = new List<Item>();


        public Inventory(Status _status)
        {
            status = _status;
        }

        public void Render()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("\n보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]\n");
                Console.WriteLine();
                foreach (Item item in getitems)
                {
                    Console.WriteLine($"{item.itName} 공격력+{item.itAbility}, {item.itInfo}");
                }
                Console.WriteLine("\n1. 장착 관리");
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.");

                string input = Console.ReadLine();
                int.TryParse(input, out menu);
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1:
                        Console.Clear();
                        Euip();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                }

            }

        }
        public void Euip()
        {
            Console.WriteLine("장착 가능한 아이템");
            int i = 1;

            while (true)
            {
                foreach (Item item in getitems)
                {
                    string equippedMark = (item == equipItem) ? "[E]" : ""; // 장착된 아이템에는 [E] 추가
                    Console.WriteLine($"{i}. {item.itName} 공격력+{item.itAbility}, {item.itInfo}");
                    i++;
                }
                Console.Clear();
                Console.WriteLine("장착할 아이템을 선택하세요 (취소: 0):");
                string input = Console.ReadLine();
                int.TryParse(input, out int menu);
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1:
                        if (getitems.Count == 6)
                        {
                            bool quik = menu > 1;
                            if (quik && getitems[menu - 6].Equip) // 선택한 아이템이 장착 가능하면
                            {
                                Console.WriteLine("[E]"); // "[E]" 출력
                            }
                        }
                        break;
                }

            }
        }
         public void Myinventory(Item item)
        {
            getitems.Add(item);
                Console.WriteLine($"{item.itName} 공격력+{item.itAbility}, {item.itInfo}");
        }
    }
}
