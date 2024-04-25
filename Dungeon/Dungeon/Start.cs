using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Start//필드
    {
        Status status;
        Inventory inventory;
        Shop shop;
        string keyInput;
        int numint;
        public Start()//메서드(멤버함수)
        {
            status = new Status("Rtan", 1, 10, 5, 100, 15000);
            inventory = new Inventory(status);
            shop = new Shop(status, inventory);
        }
        public void Update()
        {

            while (true)
            {
                int num = 0;

                Console.WriteLine("\n스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.");

                keyInput = Console.ReadLine();
                int.TryParse(keyInput, out numint);
                switch (numint)
                {
                    case 1:
                        status.MyStatus();
                        break;
                    case 2:
                        inventory.Render();
                        break;
                    case 3:
                        shop.Store();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n지정된 값이 아닙니다.\n");
                        break;
                }
            }

        }
    }
}
