using System.Net.Configuration;
using System.Diagnostics;
using System.Resources;
using System.Security.Authentication.ExtendedProtection;
using System.Drawing;
using Aimtec;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Events;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.TargetSelector;
using Aimtec.SDK.Extensions;
using Aimtec.SDK.Damage;
using System.Linq;
using Aimtec.SDK.Menu;
using spell = Aimtec.SDK.Spell;


namespace Stoic_Gnar_by_Cyla
{  

    class Program
    {
        static void Main(string[] args)
        {
            GameEvents.GameStart += GameEvents_GameStart;
        }

        private static void GameEvents_GameStart()
        {
            //            if (ObjectManager.GetLocalPlayer().c)
            var Gnar = new Gnar();
        }
    }
}
