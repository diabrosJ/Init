using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Shop
    {
        public int menu;
        Status status;
        Inventory inventory;
        List<Item> items = new List<Item>();

        public Shop(Status _status, Inventory _inventory)
        {

            status = _status;
            inventory = _inventory;
            items.Add(new Item("낡은 검", 2, "무기", "쉽게 볼 수 있는 낡은 검 입니다.", 1000, false));
            items.Add(new Item("청동 도끼", 5, "무기", "어디선가 사용됐던거 같은 도끼입니다. ", 2000, false));
            items.Add(new Item("스파르타의 창", 7, "무기", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 3500, false));
            items.Add(new Item("수련자 갑옷", 5, "방어구", "수련에 도움을 주는 갑옷입니다.  ", 600, false));
            items.Add(new Item("무쇠 갑옷", 9, "방어구", "무쇠로 만들어져 튼튼한 갑옷입니다. ", 1500, false));
            items.Add(new Item("스파르타의 갑옷", 15, "방어구", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다", 3500, false));

        }

        public void Store()
        {
            Console.Clear();

            while (true)
            {

                Console.WriteLine("\n어서오세요, 스파르타 상점 입니다.\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine(status.Gold);
                Console.WriteLine();
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.\n");
                Console.WriteLine("[아이템 목록]");

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{items[i].itName}],{items[i].itAbility},{items[i].itType},{items[i].itInfo},{items[i].Gold}");
                }
                string input = Console.ReadLine();
                Console.Clear();
                int.TryParse(input, out menu);
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1:
                        
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;
                    case 2:
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;
                    case 3:
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;
                    case 4:
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;
                    case 5:
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;
                    case 6:
                        if (status.Gold < items[menu - 1].Gold)
                        {
                            Console.WriteLine("금액이 부족 합니다.");
                        }
                        else
                        {
                            if (status.Gold >= items[menu - 1].Gold)
                            {
                                status.Gold -= items[menu - 1].Gold;
                                Console.WriteLine("========================");
                                Console.WriteLine("아이템을 구매 했습니다!");
                                inventory.Myinventory(items[menu - 1]);
                                items.RemoveAt(menu - 1);
                                Console.WriteLine("========================");
                            }
                        }
                        break;

                }
            }
        }

    }
}

// 플레이어 소지 골드와 비교해서 items를 Myinventory로 넘긴다
//Console.Clear();