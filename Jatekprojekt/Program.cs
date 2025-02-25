using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jatekprojekt
{
    internal class Program
    {
        public class Karakter
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
            public int Health { get; set; }
        }

        class Osztalyok
        {
            public string Class { get; set; }
            public int Strength { get; set; }
            public int Defense { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
            public int Health { get; set; }

        }

        Osztalyok warrior = new Osztalyok
        {
            Class = "Warrior",
            Health = 100,
            Strength = 16,
            Defense = 14,
            Dexterity = 12,
            Constitution = 0,
            Intelligence = 0,
            Wisdom = 0,
            Charisma = 0
        };

        // Más osztályok, mint Archer, Mage stb. szintén hasonlóan definiálhatók:
        Osztalyok archer = new Osztalyok
        {
            Class = "Archer",
            Health = 100,
            Strength = 14,
            Defense = 12,
            Dexterity = 0,
            Constitution = 16,
            Intelligence = 0,
            Wisdom = 0,
            Charisma = 0
        };

        Osztalyok mage = new Osztalyok
        {
            Class = "Mage",
            Health = 100,
            Strength = 8,
            Defense = 10,
            Dexterity = 0,
            Constitution = 0,
            Intelligence = 18,
            Wisdom = 14,
            Charisma = 0
        };

        Osztalyok jester = new Osztalyok
        {
            Class = "Jester",
            Health = 100,
            Strength = 15,
            Defense = 12,
            Dexterity = 14,
            Constitution = 0,
            Intelligence = 0,
            Wisdom = 0,
            Charisma = 16
        };

        public class Enemy
        {
            public string Name { get; set; }
            public int Health { set; get; }
            public int Strength { get; set; }
            public int Defense { get; set; }


        }

        public class TrickPerformer
        {
            public void PerformTrick()
            {
                string[] beszolasok = new string[3];
                beszolasok[0] = "Akkora paraszt vagy hogy vízummal jöttél ki a dinszóólból!";
                beszolasok[1] = "Rakd sebességbe az agyad, mielőtt megszólalnál!";
                beszolasok[2] = "Olyan sötét vagy mint az ágy alatt!";
                Console.WriteLine("A hős megpróbálja beoltani az ellenséget");
                Random succesChance = new Random();
                Random r = new Random();
                int g = r.Next(0, 3);
                int kocka = succesChance.Next(1, 21);

                if (kocka > 9)
                {
                    Console.WriteLine(beszolasok[g]);
                    Console.WriteLine("Siker! Az ellenség elszégyelte magát...");

                }
                else
                {
                    Console.WriteLine(beszolasok[g]);
                    Console.WriteLine("Cirip... Cirip...");
                }
            }
        }








        static void Main(string[] args)
        {
            TrickPerformer performer = new TrickPerformer();





            string DnD = @" 
    ________                                                              ____    ________                                                     _________                                   .__                  
    \______ \   __ __   ____     ____    ____    ____    ____    ______  /  _ \   \______ \  _______ _____      ____    ____    ____    ______ \_   ___ \ _____     _____  ______  _____   |__|   ____    ____  
     |    |  \ |  |  \ /    \   / ___\ _/ __ \  /  _ \  /    \  /  ___/  >  _ </\  |    |  \ \_  __ \\__  \    / ___\  /  _ \  /    \  /  ___/ /    \  \/ \__  \   /     \ \____ \ \__  \  |  |  / ___\  /    \ 
     |    `   \|  |  /|   |  \ / /_/  >\  ___/ (  <_> )|   |  \ \___ \  /  <_\ \/  |    `   \ |  | \/ / __ \_ / /_/  >(  <_> )|   |  \ \___ \  \     \____ / __ \_|  Y Y  \|  |_> > / __ \_|  | / /_/  >|   |  \
    /_______  /|____/ |___|  / \___  /  \___  > \____/ |___|  //____  > \_____\ \ /_______  / |__|   (____  / \___  /  \____/ |___|  //____  >  \______  /(____  /|__|_|  /|   __/ (____  /|__| \___  / |___|  /
            \/             \/ /_____/       \/              \/      \/         \/         \/              \/ /_____/               \/      \/          \/      \/       \/ |__|         \/     /_____/       \/ ";
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
            string jest = @"
                                                                                                      ___
                                                                                                     /\  \
                                                                                                    /  \/ \
                                                                                               ___  \   O /  ___
                                                                                              /    \ \   / /    \
                                                                                             /   __ -    -  __   \
                                                                                            /___/ | <>   <> | \___\
                                                                                            O  ___|    ^    |___  O
                                                                                             /     \  -^-  /    \
                                                                                            /   /\  \_____/ /\   \
                                                                                            \_ / /          \ \_ /
                                                                                            O   /   /\   /\  \  O
                                                                                                 \ /  \ /  \ /
                                                                                                  O    O    O";
            string wizard = @"
                                                                                                      ____ 
                                                                                                  .'* *.'
                                                                                               __/_*_*(_
                                                                                              / _______ \
                                                                                             _\_)/___\(_/_ 
                                                                                            / _((\- -/))_ \
                                                                                            \ \())(-)(()/ /
                                                                                             ' \(((()))/ '
                                                                                            / ' \)).))/ ' \
                                                                                           / _ \ - | - /_  \
                                                                                          (   ( .;''';. .'  )
                                                                                          _\ __ /    )\ __ /_
                                                                                            \/  \   ' /  \/
                                                                                             .'  '...' ' )
                                                                                              / /  |  \ \
                                                                                             / .   .   . \
                                                                                            /   .     .   \
                                                                                           /   /   |   \   \
                                                                                         .'   /    b    '.  '.
                                                                                     _.-'    /     Bb     '-. '-._ 
                                                                                 _.-'       |      BBb       '-.  '-. 
                                                                                (________mrf\____.dBBBb.________)____)  ";
            string arch = @"
                                                                                                                               |
                                                                                                                                \.
                                                                                                                                /|.
                                                                                                                              /  `|.
                                                                                                                            /     |.
                                                                                                                          /       |.
                                                                                                                        /         `|.
                                                                                                                      /            |.
                                                                                                                    /              |.
                                                                                                                  /                |.
                                                                             __                                 /                  `|.
                                                                              -\                              /                     |.
                                                                                \\                          /                       |.
                                                                                  \\                      /                         |.
                                                                                   \|                   /                           |\
                                                                                     \#####\          /                             ||
                                                                                 ==###########>     /                               ||
                                                                                  \##==      \    /                                 ||
                                                                             ______ =       =|__/___                                ||
                                                                         ,--' ,----`-,__ ___/'  --,-`-==============================##==========>
                                                                        \               '        ##_______ ______   ______,--,____,=##,__
                                                                         `,    __==    ___,-,__,--'#'  ==='      `-'              | ##,-/
                                                                           `-,____,---'       \####\              |        ____,--\_##,/
                                                                               #_              |##   \  _____,---==,__,---'         ##
                                                                                #              ]===--==\                            ||
                                                                                #,             ]         \                          ||
                                                                                 #_            |           \                        ||
                                                                                  ##_       __/'             \                      ||
                                                                                   ####='     |                \                    |/
                                                                                    ###       |                  \                  |.
                                                                                    ##       _'                    \                |.
                                                                                   ###=======]                       \              |.
                                                                                  ///        |                         \           ,|.
                                                                                  //         |                           \         |.
                                                                                                                           \      ,|.
                                                                                                                             \    |.
                                                                                                                               \  |.
                                                                                                                                 \|.
                                                                                                                                 /.
                                                                                                                                |";
            string bers = @"

                                                                                                      {}
                                                                                                     {{}}
                                                                                                     {{}}
                                                                                                      {}
                                                                                                    .-''-.
                                                                                                   /  __  \
                                                                                                  /.-'  '-.\
                                                                                                  \::.  .::/
                                                                                                   \'    '/
                                                                                              __ ___)    (___ __
                                                                                            .'   \\        //   `.
                                                                                           /     | '-.__.-' |     \
                                                                                           |     |  '::::'  |     |
                                                                                           |    /    '::'    \    |
                                                                                           |_.-;\     __     /;-._|
                                                                                           \.'^`\\    \/    //`^'./
                                                                                           /   _.-._ _||_ _.-._   \
                                                                                          `\___\    '-..-'    /___/`
                                                                                               /'---.  `\.---'\
                                                                                              ||    |`\\\|    ||
                                                                                              ||    | || |    ||
                                                                                              |;.__.' || '.__.;|
                                                                                              |       ||       |
                                                                                              {{{{{{{{||}}}}}}}}
                                                                                               |      ||      |
                                                                                               |.-==-.||.-==-.|
                                                                                               <.    .||.    .>
                                                                                                \'=='/||\'=='/
                                                                                                |   / || \   |
                                                                                                |   | || |   |
                                                                                                |   | || |   |
                                                                                                /^^\| || |/^^\
                                                                                               /   .' || '.   \
                                                                                              /   /   ||   \   \
                                                                                             (__.'    \/    '.__)";
            string attack = @"
                                                                                  _____ __                      _   __      
                                                                                 |_   _/_/_ _ __ ___   __ _  __| | /_/_ ___ 
                                                                                   | |/ _` | '_ ` _ \ / _` |/ _` |/ _` / __|
                                                                                   | | (_| | | | | | | (_| | (_| | (_| \__ \
                                                                                   |_|\__,_|_| |_| |_|\__,_|\__,_|\__,_|___/";
            string ability = @"
                                                                                    _  __ __                       __       
                                                                                   | |/ //_/ _ __   ___  ___ ___  /_/  __ _ 
                                                                                   | ' // _ \ '_ \ / _ \/ __/ __|/ _ \/ _` |
                                                                                   | . \  __/ |_) |  __/\__ \__ \  __/ (_| |
                                                                                   |_|\_\___| .__/ \___||___/___/\___|\__, |
                                                                                            |_|                       |___/";

            Enemy Lupus = new Enemy();
            Lupus.Name = "Lupus";
            Lupus.Health = 100;
            Lupus.Strength = 10;
            Lupus.Defense = 10;
            Enemy Vorlath = new Enemy();
            Vorlath.Name = "Vorlath";
            Vorlath.Health = 200;
            Vorlath.Strength = 25;
            Vorlath.Defense = 20;
            Karakter karakter = new Karakter();

            // Osztályok létrehozása
            Osztalyok warrior = new Osztalyok
            {
                Class = "Warrior",
                Health = 100,
                Strength = 16,
                Defense = 14,
                Dexterity = 12,
                Constitution = 0,
                Intelligence = 0,
                Wisdom = 0,
                Charisma = 0
            };

            Osztalyok archer = new Osztalyok
            {
                Class = "Archer",
                Health= 100,
                Strength = 14,
                Defense = 12,
                Dexterity = 0,
                Constitution = 16,
                Intelligence = 0,
                Wisdom = 0,
                Charisma = 0
            };

            Osztalyok mage = new Osztalyok
            {
                Class = "Mage",
                Health=100,
                Strength = 8,
                Defense = 10,
                Dexterity = 0,
                Constitution = 0,
                Intelligence = 18,
                Wisdom = 14,
                Charisma = 0
            };

            Osztalyok jester = new Osztalyok
            {
                Class = "Jester",
                Health=100,
                Strength = 15,
                Defense = 8,
                Dexterity = 5,
                Constitution = 0,
                Intelligence = 0,
                Wisdom = 0,
                Charisma = 0,

            };

            


































        Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(DnD);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Jatek);
            Console.WriteLine(Kilepes);


            ConsoleKey billentyu;
            billentyu = Console.ReadKey(true).Key;

            if (billentyu != ConsoleKey.Escape)
            {

                Console.Clear();
                Console.WriteLine(Karakter + " ");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t");

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
                        karakter.Class = warrior.Class;
                        karakter.Health = warrior.Health;
                        karakter.Strength = warrior.Strength;
                        karakter.Defense = warrior.Defense;
                        karakter.Dexterity = warrior.Dexterity;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tNév: ");
                        Console.ResetColor();
                        Console.WriteLine($"{karakter.Name}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tOsztály: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Class);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tStrength: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Strength);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDefense: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Defense);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDexterity: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Dexterity);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(bers);
                        Console.ResetColor();
                        Console.WriteLine("Folytatás( ENTER )");
                    }
                    else if (osztaly.ToLower() == "archer")
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tArcher kiválasztva.");
                        karakter.Class = archer.Class;
                        karakter.Health = archer.Health;
                        karakter.Strength = archer.Strength;
                        karakter.Defense = archer.Defense;
                        karakter.Constitution = archer.Constitution;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tNév: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Name);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tOsztály: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Class);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tStrength: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Strength);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDefense: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Defense);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tConstitution: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Constitution);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(arch);
                        Console.ResetColor();
                        Console.WriteLine("Folytatás( ENTER )");
                    }
                    else if (osztaly.ToLower() == "mage")
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tMage kiválasztva.");
                        karakter.Class = mage.Class;
                        karakter.Health = mage.Health;
                        karakter.Strength = mage.Strength;
                        karakter.Defense = mage.Defense;
                        karakter.Intelligence = mage.Intelligence;
                        karakter.Wisdom = 14;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\tNév: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tOsztály: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Class);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tStrength: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Strength);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDefense: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Defense);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tIntelligence: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Intelligence);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tWisdom: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Wisdom);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(wizard);
                        Console.ResetColor();
                        Console.WriteLine("Folytatás( ENTER )");
                    }
                    else if (osztaly.ToLower() == "jester")
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tJester kiválasztva.");
                        karakter.Class = jester.Class;
                        karakter.Health = jester.Health;
                        karakter.Strength = jester.Strength;
                        karakter.Defense = 12;
                        karakter.Dexterity = 14;
                        karakter.Charisma = 16;

                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tNév: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Name);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tOsztály: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Class);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tStrength: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Strength);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDefense: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Defense);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tDexterity: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Dexterity);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\t\t\t\t\t\t\t\t\t\t\t\tCharisma: ");
                        Console.ResetColor();
                        Console.WriteLine(karakter.Charisma);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(jest);
                        Console.ResetColor();
                        Console.WriteLine("Folytatás( ENTER )");
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

            ConsoleKey billentyu1;
            billentyu1 = Console.ReadKey(true).Key;

            if (billentyu1 == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("A hősök egy ismeretlen, ködbe burkolózott völgy szélén találkoznak egy sebesült küldönccel, \naki azt mondja, hogy a völgyben egy sötét varázsló, Vorlath, egy hatalmas rituálét végez, hogy megszerezze az ősi Fénykő erejét.");
                Console.WriteLine("Ez a kő képes elnyelni a világ fényét, és a varázsló hatalmával szörnyű dolgokat tehet. A küldönc arra kér, hogy a hősök találják meg és semmisítsék meg Vorlathot, mielőtt túl késő lenne.");
                Console.WriteLine();
                Console.WriteLine("Cél:");
                Console.WriteLine("Küzdj meg Vorlath varázsló szolgáival, tisztítsd meg a völgyet, és akadályozd meg a rituálét.");
                Console.WriteLine();
                Console.WriteLine("Térkép:\n A völgy bejárata – A ködös erdő szélén egy ódon, omladozó hídon kell átkelniük a hősöknek.Az út elején egy lupusz(vad farkas) támadja meg őket.\n Ködös erdő – A fák között a köd elnyeli a fényt.Különböző csapdák és támadások várják a hősöket, de egy titkos ösvény is létezik, amelyet ha megtalálnak, elkerülhetik a veszélyeket.\n Varázsló tanyája – A völgy közepén egy nagy, elhagyatott kastély található, ahol Vorlath végzi a rituálét.Itt találkoznak a hősök a végső ellenséggel.\n");
                Console.WriteLine("Az erdő szélén állsz és két irányba tudsz menni, mit választasz? (Jobb | Bal)");
                string valasz1 = Console.ReadLine();
                if (valasz1.ToLower() == "jobb")
                {
                    Console.Clear();
                    Console.WriteLine("Egy vad farkas rád támadott!");
                    harc1:
                    Console.WriteLine($"{attack}\n{ability}");
                    Console.WriteLine($"Név:{karakter.Name}\nHealth:{karakter.Health}\nStrength:{karakter.Strength}\nDefense:{karakter.Defense}\nDexterity:{karakter.Dexterity}\nConstitution:{karakter.Constitution}\nIntelligence:{karakter.Intelligence}\nWisdom:{karakter.Wisdom}\nCharisma:{karakter.Charisma}");
                    Console.WriteLine();
                    Console.WriteLine($"Ellenség:\nNév:{Lupus.Name}\nHealth:{Lupus.Health}\nStrength:{ Lupus.Strength}\nDefense:{ Lupus.Defense}");
                    Console.WriteLine();
                    Console.WriteLine("Válassz: (Támadás(1) | Képesség(2) )");
                    int valasz4 = int.Parse(Console.ReadLine());



                    do
                    {
                        if (valasz4 == 1)
                        {
                            Random kockadob = new Random();
                            int kockalandol = kockadob.Next(1, 21);
                            if (kockalandol > 9)
                            {
                                Console.WriteLine("Támadás sikeres");
                                Lupus.Health = Lupus.Health - karakter.Strength;
                                Console.WriteLine($"Lupus health:{Lupus.Health}");

                            }
                            else
                            {
                                Console.WriteLine("A támadás nem talált");
                            }
                        }

                        else if (valasz4 == 2)
                        {
                            performer.PerformTrick();
                        }
                        Console.WriteLine("Lupus támad!");
                        Random kockadob2 = new Random();
                        int kockalandol2 = kockadob2.Next(1, 21);
                        if (kockalandol2 > 9)
                        {
                            
                            Console.WriteLine("Támadás sikeres");
                            karakter.Health = karakter.Health - Lupus.Strength;
                            Console.WriteLine($"{karakter.Name} health:{karakter.Health}");

                        }
                        else
                        {
                            Console.WriteLine("A támadás nem talált");
                        }


                        if (karakter.Health > 0 && Lupus.Health > 0)
                        {
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto harc1;
                        }
                        
                        


                    } while (karakter.Health > 0 && Lupus.Health > 0);

                    if(Lupus.Health < 0)
                    {
                        Console.WriteLine("Győztél");
                        Console.WriteLine("Folytatás...");
                        karakter.Health = 150;
                        karakter.Strength = karakter.Strength + 7;
                        
                    }
                    else
                    {
                        Console.WriteLine("Vesztettél.");
                        goto jatekveg;
                    }

                



                    //Játékos az erdő szélén áll ahol 2 irányba tud menni:
                    //1.Jobbra: Vad farkas -harc
                    //- archer: több előnye van itt("túl közel kerülnek hozzá, megsebezheti a hősöket")
                    //-mage: közel marad a warriorhoz: mage->heal + lassítja a farkast || warrior gyors mozdulatokkal támad
                    //Dexterity = 0,
                    //Constitution = 0,
                    //Intelligence = 18,
                    //Wisdom = 14,
                    //Charisma = 0

                }

                else if(valasz1.ToLower() == "bal")
                {
                    
                    Console.WriteLine("Semmi csak sűrű köd...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Console.WriteLine("Tövább haladsz az erdőben és egy elhagyatott kastélyhoz érsz");
                    Console.WriteLine("Ahogy belépsz egy rituális szobára találsz");
                    Console.WriteLine("A szobábn egy tárgyat fellöksz és elindítasz egy rituálét...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    harc2:
                    Console.WriteLine("Vorlath a rohadt szellem rád támad!");           
                    Console.WriteLine($"{attack}\n{ability}");
                    Console.WriteLine($"Név:{karakter.Name}\nHealth:{karakter.Health}\nStrength:{karakter.Strength}\nDefense:{karakter.Defense}\nDexterity:{karakter.Dexterity}\nConstitution:{karakter.Constitution}\nIntelligence:{karakter.Intelligence}\nWisdom:{karakter.Wisdom}\nCharisma:{karakter.Charisma}");
                    Console.WriteLine();
                    Console.WriteLine($"Ellenség:\nNév:{Vorlath.Name}\nHealth:{Vorlath.Health}\nStrength:{ Vorlath.Strength}\nDefense:{ Vorlath.Defense}");
                    Console.WriteLine();
                    Console.WriteLine("Válassz: (Támadás(1) | Képesség(2) )");
                    int valasz3 = int.Parse(Console.ReadLine());



                    do
                    {
                        if (valasz3 == 1)
                        {
                            Random kockadob = new Random();
                            int kockalandol = kockadob.Next(1, 21);
                            if (kockalandol > 9)
                            {
                                Console.WriteLine("Támadás sikeres");
                                Vorlath.Health = Vorlath.Health - karakter.Strength;
                                Console.WriteLine($"Vorlath health:{Vorlath.Health}");

                            }
                            else
                            {
                                Console.WriteLine("A támadás nem talált");
                            }
                        }

                        else if (valasz3 == 2)
                        {
                            performer.PerformTrick();
                        }
                        Console.WriteLine("Vorlath támad!");
                        Random kockadob2 = new Random();
                        int kockalandol2 = kockadob2.Next(1, 21);
                        if (kockalandol2 > 9)
                        {

                            Console.WriteLine("Támadás sikeres");
                            karakter.Health = karakter.Health - Vorlath.Strength;
                            Console.WriteLine($"{karakter.Name} health:{karakter.Health}");

                        }
                        else
                        {
                            Console.WriteLine("A támadás nem talált");
                        }


                        if (karakter.Health > 0 && Vorlath.Health > 0)
                        {
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto harc2;
                        }




                    } while (karakter.Health > 0 && Vorlath.Health > 0);

                    if (Vorlath.Health < 0)
                    {
                        Console.WriteLine("Győztél");
                        karakter.Health = 150;
                        
                        goto jatekveg;

                    }
                    else
                    {
                        Console.WriteLine("Vesztettél.");
                        goto jatekveg;
                    }
                }

           
                Console.Clear();
                Console.WriteLine("Semmi csak sűrű köd...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Tövább haladsz az erdőben és egy elhagyatott kastélyhoz érsz");
                Console.WriteLine("Ahogy belépsz egy rituális szobára találsz");
                Console.WriteLine("A szobábn egy tárgyat fellöksz és elindítasz egy rituálét...");
                Thread.Sleep(3000);
                Console.Clear();
                harc3:
                Console.WriteLine("Vorlath a rohadt szellem rád támad!");
                Console.WriteLine($"{attack}\n{ability}");
                Console.WriteLine($"Név:{karakter.Name}\nHealth:{karakter.Health}\nStrength:{karakter.Strength}\nDefense:{karakter.Defense}\nDexterity:{karakter.Dexterity}\nConstitution:{karakter.Constitution}\nIntelligence:{karakter.Intelligence}\nWisdom:{karakter.Wisdom}\nCharisma:{karakter.Charisma}");
                Console.WriteLine();
                Console.WriteLine($"Ellenség:\nNév:{Vorlath.Name}\nHealth:{Vorlath.Health}\nStrength:{ Vorlath.Strength}\nDefense:{ Vorlath.Defense}");
                Console.WriteLine();
                Console.WriteLine("Válassz: (Támadás(1) | Képesség(2) )");
                int valasz2 = int.Parse(Console.ReadLine());



                do
                {
                    if (valasz2 == 1)
                    {
                        Random kockadob = new Random();
                        int kockalandol = kockadob.Next(1, 21);
                        if (kockalandol > 9)
                        {
                            Console.WriteLine("Támadás sikeres");
                            Vorlath.Health = Vorlath.Health - karakter.Strength;
                            Console.WriteLine($"Vorlath health:{Vorlath.Health}");

                        }
                        else
                        {
                            Console.WriteLine("A támadás nem talált");
                        }
                    }

                    else if (valasz2 == 2)
                    {
                        performer.PerformTrick();
                    }
                    Console.WriteLine("Vorlath támad!");
                    Random kockadob2 = new Random();
                    int kockalandol2 = kockadob2.Next(1, 21);
                    if (kockalandol2 > 9)
                    {

                        Console.WriteLine("Támadás sikeres");
                        karakter.Health = karakter.Health - (Vorlath.Strength-karakter.Defense);
                        Console.WriteLine($"{karakter.Name} health:{karakter.Health}");

                    }
                    else
                    {
                        Console.WriteLine("A támadás nem talált");
                    }


                    if (karakter.Health > 0 && Vorlath.Health > 0)
                    {
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto harc3;
                    }




                } while (karakter.Health > 0 && Vorlath.Health > 0);

                if (Vorlath.Health < 0)
                {
                    Console.Clear();
                    Console.WriteLine("A szellem elűzve!");
                    Console.WriteLine("Az erdőből a köd felszáll...");
                    karakter.Health = 100;
                    goto jatekveg;

                }
                else
                {
                    Console.WriteLine("Vesztettél.");
                    goto jatekveg;
                }













            jatekveg:
                Console.WriteLine("A játéknak vége");



                Console.ReadKey();
            }
        }
    }
}
