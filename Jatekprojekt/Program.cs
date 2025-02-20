using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatekprojekt
{
    internal class Program
    {
        public class Character
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Strength { get; set; }
            public int Defense { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        static void Main(string[] args)
        {
            string DnD = @" 
                                ____                                             ___        ____                                       ______                            _            
                               / __ \__  ______  ____ ____  ____  ____  _____   ( _ )      / __ \_________ _____ _____  ____  _____   / ____/___ _____ ___  ____  ____ _(_)___  ____ _
                              / / / / / / / __ \/ __ `/ _ \/ __ \/ __ \/ ___/  / __ \/|   / / / / ___/ __ `/ __ `/ __ \/ __ \/ ___/  / /   / __ `/ __ `__ \/ __ \/ __ `/ / __ \/ __ `/
                             / /_/ / /_/ / / / / /_/ /  __/ /_/ / / / (__  )  / /_/  <   / /_/ / /  / /_/ / /_/ / /_/ / / / (__  )  / /___/ /_/ / / / / / / /_/ / /_/ / / / / / /_/ / 
                            /_____/\__,_/_/ /_/\__, /\___/\____/_/ /_/____/   \____/\/  /_____/_/   \__,_/\__, /\____/_/ /_/____/   \____/\__,_/_/ /_/ /_/ .___/\__,_/_/_/ /_/\__, /  
                                              /____/                                                     /____/                                         /_/                  /____/   ";
            string Jatek = @"
                                                                  _   __  _    __ _       __  _____ _   _ _____ _____ ____   __  
                                                                 | | /_/_| |_ /_/| | __  / / | ____| \ | |_   _| ____|  _ \  \ \ 
                                                              _  | |/ _` | __/ _ \ |/ / | |  |  _| |  \| | | | |  _| | |_) |  | |
                                                             | |_| | (_| | ||  __/   <  | |  | |___| |\  | | | | |___|  _ <   | |
                                                              \___/ \__,_|\__\___|_|\_\ | |  |_____|_| \_| |_| |_____|_| \_\  | |
                                                                                         \_\                                 /_/ ";
            string Kilepes = @"
                                                                  _  ___ _   __         __         __  _____ ____   ____  __  
                                                                 | |/ (_) | /_/ _ __   /_/  ___   / / | ____/ ___| / ___| \ \ 
                                                                 | ' /| | |/ _ \ '_ \ / _ \/ __| | |  |  _| \___ \| |      | |
                                                                 | . \| | |  __/ |_) |  __/\__ \ | |  | |___ ___) | |___   | |
                                                                 |_|\_\_|_|\___| .__/ \___||___/ | |  |_____|____/ \____|  | |
                                                                               |_|                \_\                     /_/ ";
            string Karakter = @"
                                      _  _                             _           _              _                         _     _                          _   _ 
                                     | \| |  ___  __ __  ___   ___  __| |    ___  | |    __ _    | |__  __ _   _ _   __ _  | |__ | |_   ___   _ _   ___   __| | (_)
                                     | .` | / -_) \ V / / -_) |_ / / _` |   / -_) | |   / _` |   | / / / _` | | '_| / _` | | / / |  _| / -_) | '_| / -_) / _` |  _ 
                                     |_|\_| \___|  \_/  \___| /__| \__,_|   \___| |_|   \__,_|   |_\_\ \__,_| |_|   \__,_| |_\_\  \__| \___| |_|   \___| \__,_| (_)";
            Console.WriteLine(DnD);
            Console.WriteLine(Jatek);
            Console.WriteLine(Kilepes);
            ConsoleKey billentyu;
                billentyu = Console.ReadKey(true).Key;
       
                if(billentyu != ConsoleKey.Escape) 
            {
                Console.Clear();
                Console.WriteLine(Karakter + " ");
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t");
                Character karakter = new Character();
                karakter.Name = Console.ReadLine();
                Console.Clear();
            osztalyvalaszt:
                Console.WriteLine("Válaszd ki a classed: (Warrior | Archer | Mage | Jester)");
                string war1 = @"
                            1. Warrior (Harcos)
                            A harcos egy erőteljes közelharci karakter, aki a fizikai erejére és a védekezésre összpontosít. Képes nagy mennyiségű sérülést okozni, és jól bírja a csatákat.
                            Strength (Erő): A harcos fizikai ereje, amely meghatározza a támadások erejét és a súlyos páncéllal való mozgás képességét.
                            Defense (Védelem): A harcos képessége, hogy elkerülje vagy csökkentse a támadások hatását. Minél magasabb, annál jobban képes ellenállni a sérüléseknek.
                            Dexterity (Ügyesség): A harcos gyorsasága és mozgékonysága. Ez befolyásolja a támadások sebességét, valamint a csapdák és a támadások elkerülésének esélyét.";
                string ar1 = @"
                            2. Archer (Íjász)
                            Az íjász távolsági harcra specializálódott, és nagy hangsúlyt fektet a kitartásra, az erőre és a védekezésre. Ő egy pontos és gyors támadó, aki a harc távolabbi aspektusait uralja.
                            Strength (Erő): Az íjász fizikai ereje, amely befolyásolja a távolsági támadásokat (pl. nyílzápor) és a súlyosabb íjak használatát.
                            Defense (Védelem): Az íjász is képes elkerülni vagy csökkenteni a támadások hatását, de a hangsúly inkább a mozgékonyságon van, mint a páncél viselésén.
                            Constitution (Állóképesség): Az íjász állóképessége és kitartása a hosszú távú küzdelmekhez. Ez befolyásolja az életpontok számát és a sérülésekhez való ellenállást.";
                string mag1 = @"
                            3. Mage (Mágus)
                            A mágus a varázslásra összpontosít, és a tudása és bölcsessége révén irányítja az elemeket.
                            A mágus a legkevésbé védett a közelharci támadások ellen, de rendkívül erős varázslatokkal rendelkezik.
                            Strength(Erő): A mágus erője viszonylag alacsony, mivel ő inkább a varázslatokra épít. 
                            Az erő befolyásolja a fizikai támadásokat, de nem jellemző a mágusra.
                            Defense(Védelem): A mágus védelme alapvetően a varázslataiban rejlik, és a varázslatok által elkerült támadásokban. 
                            Nincs nagy fizikai védelme, de a varázslatok segítenek neki.
                            Intelligence(Intelligencia): A mágus intelligenciája meghatározza, hogy milyen erős varázslatokat képes használni,
                            valamint a varázslatok hatékonyságát és azok tanulásának gyorsaságát.
                            Wisdom(Bölcsesség): A mágus bölcsessége befolyásolja a varázslatok előrejelzését, az érzékelési képességeit és azt, hogy hogyan reagál a mágikus hatásokra. 
                            Segít a varázslatok pontosabb végrehajtásában és a mágikus világ megértésében.";
                string jest1 = @"
                            4.Jester(Bolond):
                            Charisma (Karizma):
                            A jester legerősebb tulajdonsága, mivel a karizma segíti őt a szórakoztatásban, manipulációban és társas kapcsolatokban.
                            Dexterity (Ügyesség):
                            Az ügyesség segíti a jester mozgékonyságát, hogy gyorsan reagáljon, elkerülje a támadásokat és végrehajtsa a trükköket.
                            Strength (Erő):
                            Mivel a jester nem harcos, az erő nem annyira hangsúlyos nála. Alacsonyabb érték, de még mindig szükséges némi fizikai erő, ha valamilyen támadásra vagy közelharcra kerülne sor.
                            Defense (Védelem):
                            A jester nem rendelkezik komoly páncéllal, de az ügyessége és trükkjei segíthetnek abban, hogy elkerülje a támadásokat. A védekezés mérsékelten fontos számára.";

                Console.WriteLine(war1);
                Console.WriteLine(ar1);
                Console.WriteLine(mag1);
                Console.WriteLine(jest1);
                string osztaly = Console.ReadLine();
                if (osztaly.ToLower() == "warrior" || osztaly.ToLower() == "archer" || osztaly.ToLower() == "mage" || osztaly.ToLower() == "jester")
                {
                    Console.Clear();
                    if (osztaly.ToLower() == "warrior")
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tWarrior kiválasztva.");
                        karakter.Class = "Harcos";
                        karakter.Strength = 16;  
                        karakter.Defense = 14;  
                        karakter.Dexterity = 12;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tNév: {karakter.Name}");
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tOsztály: {karakter.Class}");
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tStrength: {karakter.Strength}");
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tDefense: {karakter.Defense}");
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tDexterity: {karakter.Dexterity}");
                    }
                }

                else
                {
                    Console.WriteLine("Helytelen karakter!");
                    goto osztalyvalaszt;
                }



            }

            else
            {
                Console.WriteLine("Kilépés a játékból.");
            }


















            Console.ReadKey();
        }
    }
}
