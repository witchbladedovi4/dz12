using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public struct Bow : IWeapon
    {
        public readonly string WeaponType() => "Лук";
        public int WeaponPower { get; set; }
        public string SpecialAbility { get; set; }
        public int Range { get; set; }       
        public int Accuracy { get; set; }    
    }
}
