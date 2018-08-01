using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityScript;

namespace AntiSpray
{
    public class AntiSpray : BaseScript
    {

        public AntiSpray()
            : base()
        {
            PlayerConnected += new Action<Entity>(entity =>
            {

                entity.OnNotify("weapon_fired", (dude, weaponName) =>
                {
                    if (weaponName.ToString().Contains("dragunov") || weaponName.ToString().Contains("rsas") || weaponName.ToString().Contains("rsass") || weaponName.ToString().Contains("barrett") || weaponName.ToString().Contains("as50"))
                    {
                        dude.Call("stunplayer", 1);
                        AfterDelay(500, () =>
                        {
                            dude.Call("stunplayer", 0);
                        });
                        
                    }
                });
            });
        }

    }
}
