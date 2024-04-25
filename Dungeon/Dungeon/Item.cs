using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Item
    {
        public string itName { get; }
        public int itAbility { get; }
        public string itType { get; }
        public string itInfo { get; }
        public int Gold { get; }
        public bool Equip { get; set; }

        public Item(string itName, int itAbility, string itType, string itInfo, int gold, bool Equip)
        {
            this.itName = itName;
            this.itAbility = itAbility;
            this.itType = itType;
            this.itInfo = itInfo;
            this.Gold = gold;
            this.Equip = Equip;
        }

    }
}
