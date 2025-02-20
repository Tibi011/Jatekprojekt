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

                                                                                               __.--|~|--.__                               ,,;/;
                                                                                             /~     | |    ;~\                          ,;;;/;;'
                                                                                            /|      | |    ;~\\                      ,;;;;/;;;'
                                                                                           |/|      \_/   ;;;|\                    ,;;;;/;;;;'
                                                                                           |/ \          ;;;/  )                 ,;;;;/;;;;;'
                                                                                       ___ | ______     ;_____ |___....__      ,;;;;/;;;;;'
                                                                                 ___.-~ \\(| \  \.\ \__/ /./ /:|)~   ~   \   ,;;;;/;;;;;'
                                                                             /~~~    ~\    |  ~-.     |   .-~: |//  _.-~~--,;;;;/;;;;;'
                                                                            (.-~___     \.'|    | /-.__.-\|::::| //~     ,;;;;/;;;;;'
                                                                            /      ~~--._ \|   /          `\:: |/      ,;;;;/;;;;;'
                                                                         .-|             ~~|   |  /V   V\ |:  |     ,;;;;/;;;;;' \
                                                                        /                   \  |  ~`^~~^'~ |  /    ,;;;;/;;;;;'    ;
                                                                       (        \             \|`\._____./'|/    ,;;;;/;;;;;'      '\
                                                                      / \        \                             ,;;;;/;;;;;'     /    |
                                                                     |            |                          ,;;;;/;;;;;'      |     |
                                                                    |`-._          |                       ,;;;;/;;;;;'              \
                                                                    |             /                      ,;;;;/;;;;;'  \              \__________
                                                                    (             )                 |  ,;;;;/;;;;;'      |        _.--~
                                                                     \          \/ \              ,  ;;;;;/;;;;;'       /(     .-~_..--~~~~~~~~~~
                                                                     \__         '  `       ,     ,;;;;;/;;;;;'    .   /  \   / /~
                                                                     /          \'  |`._______ ,;;;;;;/;;;;;;'    /   :    \/'/'       /|_/|   ``|
                                                                    | _.-~~~~-._ |   \ __   .,;;;;;;/;;;;;;' ~~~~'   .'    | |       /~ (/\/    ||
                                                                    /~ _.-~~~-._\    /~/   ;;;;;;;/;;;;;;;'          |    | |       / ~/_-'|-   /|
                                                                    (/~         \| /' |   ;;;;;;/;;;;;;;;            ;   | |       (.-~;  /-   / |
                                                                    |            /___ `-,;;;;;/;;;;;;;;'            |   | |      ,/)  /  /-   /  |
                                                                     \            \  `-.`---/;;;;;;;;;' |          _'   | |    /'('  /  /|- _/  //
                                                                       \           /~~/ `-. |;;;;;''    ______.--~~ ~\  | |  ,~)')  /   | \~-==//
                                                                         \      /~(   `-\  `-.`-;   /|    ))   __-####\ | |   (,   /|    |  \
                                                                           \  /~.  `-.   `-.( `-.`~~ /##############'~~)| |   '   / |    |   ~\
                                                                            \(   \    `-._ /~)_/|  /############'       | |      /  \     \_\  `\
                                                                            ,~`\  `-._  / )#####|/############'   /     | |  _--~ _/ | .-~~____--'
                                                                           ,'\  `-._  ~)~~ `################'           | | ((~>/~   \ (((' -_
                                                                         ,'   `-.___)~~      `#############             | |           ~-_     ~\_
                                                                     _.,'        ,'           `###########              | |            _-~-__    (
                                                                    |  `-.     ,'              `#########       \       | |          ((.-~~~-~_--~
                                                                    `\    `-.;'                  `######                | |                 ((.-~~
                                                                      `-._   )               \     |   |        .       |  \                  
                                                                          `~~  _/                  |    \               |   `---------------------
                                                                            |/~                `.  |     \        .     |  O    __.---------------
                                                                             |                   \ ;      \             |   _.-~
                                                                             |                    |        |            |  /  |
                                                                              |                   |         |           |/'  |";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(DnD);
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(Jatek);
            Console.WriteLine(Kilepes);
            
            ConsoleKey billentyu;
                billentyu = Console.ReadKey(true).Key;
       
                if(billentyu != ConsoleKey.Escape) 
            {
                
                Console.Clear();
                Console.WriteLine(Karakter + " ");
                Console.ResetColor();
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
                    else if(osztaly.ToLower() == "archer")
                            {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\tArcher kiválasztva.");
                        karakter.Class = "Archer";
                        karakter.Strength = 14;
                        karakter.Defense = 12;
                        karakter.Constitution = 16;
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
                        karakter.Class = "Mágus";
                        karakter.Strength = 8;
                        karakter.Defense = 10;
                        karakter.Intelligence = 18;
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
                        karakter.Class = "Jester";
                        karakter.Strength = 10;
                        karakter.Defense = 12;
                        karakter.Dexterity = 14;
                        karakter.Charisma=16;
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tA karaktered létrejött!");
                        Console.ForegroundColor= ConsoleColor.Red;
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

            if(billentyu1 == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("A hősök egy ismeretlen, ködbe burkolózott völgy szélén találkoznak egy sebesült küldönccel, \naki azt mondja, hogy a völgyben egy sötét varázsló, Vorlath, egy hatalmas rituálét végez, hogy megszerezze az ősi Fénykő erejét.");
                Console.WriteLine("Ez a kő képes elnyelni a világ fényét, és a varázsló hatalmával szörnyű dolgokat tehet. A küldönc arra kér, hogy a hősök találják meg és semmisítsék meg Vorlathot, mielőtt túl késő lenne.");
                Console.WriteLine("Cél:");
                Console.WriteLine("Küzdj meg Vorlath varázsló szolgáival, tisztítsd meg a völgyet, és akadályozd meg a rituálét.");

            }
















            Console.ReadKey();
        }
    }
}
