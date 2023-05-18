using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //string companyMail = "info@code.edu.az";
            //string userMail = "info@code.edu.a";
            //int result = userMail.CompareTo(companyMail);

            //string message = result switch
            //{
            //    -1 => "Worng Mail character",
            //    0 => "Correct mail address",
            //    _ => "Incorrect, many character"
            //};
            //Console.WriteLine(message);

            //string text = "admin";
            //string test = "dmin";
            //bool result=  text.Contains(test);
            //Console.WriteLine($"Bu yazi bizde {(result?"vardir":"yoxdur")}");

            //string text = "Admin";
            //bool result=text.StartsWith("m");
            //bool result=text.StartsWith("a",StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine($"Bu yazi bizde {(result ? "vardir" : "yoxdur")}");

            //string text = "Admin";
            //bool result=text.EndsWith("n");
            //Console.WriteLine($"Bu yazi bizde {(result ? "vardir" : "yoxdur")}");

            //string text = "Admin";
            //int result = text.IndexOf("n");
            //int res = text.LastIndexOf("n");
            //Console.WriteLine($"Bu yazi bizde {result}");
            //Console.WriteLine($"Bu yazi bizde {res}");

            //string text = "Admin";
            //text=text.Remove(3);
            //Console.WriteLine(text);

            //string text = "Admin";
            //text = text.Remove(4,1);
            //Console.WriteLine(text);

            //string text = "Admin";
            //string value=Console.ReadLine();
            //text = text.Replace(text, value);
            //Console.WriteLine(text);

            //string[] mail = { "Admin@code.az",
            //"Ali@code.az",
            // "Veli@code.az",
            // "Sefteli@code.az"};
            //string newMail;
            //foreach (var item in mail)
            //{
            //    int index = item.LastIndexOf('.');
            //    newMail = item.Insert(index, ".edu");
            //    mail[index++] = item.Insert(index+1, ".edu");

            //    Console.WriteLine(item);
            //}


            //foreach (var data in mail.Select((m, i) => (m, i)))
            //{
            //    int index = data.m.LastIndexOf('.');
            //    mail[data.i] = data.m.Insert(index + 1, "edu.");
               
            //}
            //foreach (var item in mail)
            //{
            //    Console.WriteLine(item);
            //}

            //string metin = "admin";
            //Console.WriteLine(metin.ToLower());
            //Console.WriteLine(metin.ToUpper());

            //string text = "admin";
            //Console.WriteLine(text.Substring(2));
            //Console.WriteLine(text.Remove(2));


            #endregion
            #region Task-StringFunc
            //char[] semantic = { '*', '-', '+', ',', ':', ';', '/','_' };
            //Console.WriteLine(new String('-',25));
            //Console.WriteLine("Yazi daxil edin:");
            //string value= Console.ReadLine();
            //foreach (var sem in semantic)
            //{
            //    value=value.Replace(sem.ToString(),"");

            //}
            //Console.WriteLine(value);

            //string text=Console.ReadLine();
            //var result = text.Split(".");
            //foreach (var item in result ) 
            //{
            //    Console.WriteLine(item);
            //}

            //char[] semantic = { '*', '-', '+', ',', ':', ';', '/', '_','%',' ' };
            //Console.WriteLine(new String('-',25));
            //Console.WriteLine("Yazi daxil edin:");
            //string value= Console.ReadLine();
            //var res= value.Split(semantic, StringSplitOptions.RemoveEmptyEntries);

            #endregion
            #region Task-mail
            string[] mails = 
            {
                "lilly_hilll47@hotmail.com       ",
                "kamron.wilderman@gmail.com      ",
                "annabell16@yahoo.com            ",
                "robb85@hotmail.com              ",
                "dayana.hickle37@hotmail.com     ",
                "angela45@yahoo.com              ",
                "mossie_sipes80@yahoo.com        ",
                "sylvester.kozey@hotmail.com     ",
                "carli77@hotmail.com             ",
                "gloria38@yahoo.com              ",
                "sheldon45@yahoo.com             ",
                "trevor_sipes@yahoo.com          ",
                "adella_mann26@yahoo.com         ",
                "tyson_heller10@gmail.com        ",
                "tamia_ledner@hotmail.com        ",
                "remington35@gmail.com           ",
                "cullen39@hotmail.com            ",
                "demario.larson59@gmail.com      ",
                "macy_barrows@gmail.com          ",
                "pearlie31@gmail.com             ",
                "karson_halvorson@hotmail.com    ",
                "kasandra_carroll17@gmail.com    ",
                "makenna.crona69@yahoo.com       ",
                "toby.keebler@hotmail.com        ",
                "velma_marquardt@gmail.com       ",
                "joseph.haag60@gmail.com         ",
                "daisy44@hotmail.com             ",
                "jules.ward3@hotmail.com         ",
                "ethan.senger6@hotmail.com       ",
                "lily98@hotmail.com              ",
                "zoe.fay35@yahoo.com             ",
                "glen.walter87@yahoo.com         ",
                "priscilla.langworth44@gmail.com ",
                "rubie97@yahoo.com               ",
                "luther.reilly@gmail.com         ",
                "hollie59@gmail.com              ",
                "alex_hane95@hotmail.com         ",
                "pablo_yost68@gmail.com          ",
                "clementine.heathcote@yahoo.com  ",
                "ewald78@gmail.com               ",
                "deon96@hotmail.com              ",
                "lexie.lindgren40@yahoo.com      ",
                "allan10@gmail.com               ",
                "muhammad_hessel63@yahoo.com     ",
                "jadyn_paucek@hotmail.com        ",
                "maud58@gmail.com                ",
                "aryanna_zboncak@yahoo.com       ",
                "kiel_emard@yahoo.com            ",
                "rodger.bartoletti@hotmail.com   ",
                "rosario.schowalter43@hotmail.com",
                "meta_kozey@yahoo.com            ",
                "louvenia13@yahoo.com            ",
                "jon47@gmail.com                 ",
                "emelia44@hotmail.com            ",
                "preston.zboncak@yahoo.com       ",
                "hassie52@gmail.com              ",
                "reta.okeefe@gmail.com           ",
                "karianne_parisian@yahoo.com     ",
                "daphnee.doyle@gmail.com         ",
                "aubrey.bahringer@yahoo.com      ",
                "karley_buckridge@gmail.com      ",
                "rosalind.weimann@gmail.com      ",
                "bailey41@gmail.com              ",
                "merl78@hotmail.com              ",
                "iva59@yahoo.com                 ",
                "maiya.roberts@yahoo.com         ",
                "floy15@gmail.com                ",
                "billie.terry6@gmail.com         ",
                "alf_rau15@gmail.com             ",
                "gordon_goyette90@yahoo.com      ",
                "terrance.auer88@hotmail.com     ",
                "shaniya.reynolds@gmail.com      ",
                "ben.muller67@hotmail.com        ",
                "sibyl_okuneva@yahoo.com         ",
                "jayce_abernathy@hotmail.com     ",
                "serenity_mccullough77@gmail.com ",
                "gerardo8@yahoo.com              ",
                "samir.vandervort@gmail.com      ",
                "brenden7@gmail.com              ",
                "celia.schneider2@gmail.com      ",
                "makenzie.ondricka@hotmail.com   ",
                "ulises27@hotmail.com            ",
                "kailee45@hotmail.com            ",
                "geoffrey_aufderhar39@hotmail.com",
                "cayla15@yahoo.com               ",
                "jarvis.johnston@gmail.com       ",
                "roosevelt65@hotmail.com         ",
                "eula.swift39@hotmail.com        ",
                "callie.lemke71@yahoo.com        ",
                "burdette6@hotmail.com           ",
                "remington45@yahoo.com           ",
                "ted65@gmail.com                 ",
                "anibal_kuhic@yahoo.com          ",
                "tommie_stroman@gmail.com        ",
                "edna42@hotmail.com              ",
                "katarina.kuhic86@hotmail.com    ",
                "kenyatta_gorczany58@yahoo.com   ",
                "jensen57@yahoo.com              ",
                "cameron8@hotmail.com            ",
                "brown_rutherford2@hotmail.com   ",
                "vivienne_fritsch92@yahoo.com    ",
                "vanessa_swift@gmail.com         ",
                "kody_gibson@hotmail.com         ",
                "dell.hudson@yahoo.com           ",
                "thalia.greenholt@yahoo.com      ",
                "marlin43@yahoo.com              ",
                "doug_king9@gmail.com            ",
                "quinten.dietrich31@gmail.com    ",
                "enos.torphy@gmail.com           ",
                "aurelia.ryan@yahoo.com          ",
                "judah84@gmail.com               ",
                "joshua.konopelski@hotmail.com   ",
                "esperanza_olson93@hotmail.com   ",
                "isidro_kassulke13@hotmail.com   ",
                "jamal80@gmail.com               ",
                "polly35@gmail.com               ",
                "juliana.rolfson22@hotmail.com   ",
                "tabitha90@gmail.com             ",
                "adolph46@gmail.com              ",
                "gustave52@gmail.com             ",
                "camden63@gmail.com              ",
                "camren.macejkovic@hotmail.com   ",
                "lavina_kuhic@yahoo.com          ",
                "micaela_stoltenberg6@yahoo.com  ",
                "bradly.kessler96@hotmail.com    ",
                "juwan_kessler0@gmail.com        ",
                "dorcas30@hotmail.com            ",
                "otis4@hotmail.com               ",
                "victoria36@yahoo.com            ",
                "javier65@yahoo.com              ",
                "sterling68@hotmail.com          ",
                "beau.zieme@hotmail.com          ",
                "clare92@yahoo.com               ",
                "shirley.lehner20@gmail.com      ",
                "kelton.stokes90@gmail.com       ",
                "mossie.smith29@yahoo.com        ",
                "lynn.balistreri@hotmail.com     ",
                "harold.langworth@gmail.com      ",
                "reinhold11@gmail.com            ",
                "alycia_greenfelder@gmail.com    ",
                "doyle_stanton@yahoo.com         ",
                "sandra.kuhn74@yahoo.com         ",
                "ayana.schuppe40@gmail.com       ",
                "cecelia.homenick90@hotmail.com  ",
                "johnathon.bayer76@gmail.com     ",
                "rene_schmeler16@gmail.com       ",
                "kolby.bruen@hotmail.com         ",
                "ana_dubuque12@yahoo.com         ",
                "hilda.okeefe@hotmail.com        ",
                "dewayne.schuster49@hotmail.com  ",
                "chad84@hotmail.com              ",
                "laury_langosh37@yahoo.com       ",
                "rahsaan51@gmail.com             ",
                "lavon.keebler@gmail.com         ",
                "jeffery.johnson@gmail.com       ",
                "gayle93@hotmail.com             ",
                "maybelle_stracke@yahoo.com      ",
                "madelyn_waters82@gmail.com      ",
                "asia58@yahoo.com                ",
                "cortney.paucek33@hotmail.com    ",
                "delbert.turner@yahoo.com        ",
                "dorcas63@hotmail.com            ",
                "junius.dicki22@yahoo.com        ",
                "lesly_upton99@hotmail.com       ",
                "joany71@gmail.com               ",
                "carlie59@hotmail.com            ",
                "damaris44@yahoo.com             ",
                "andy_moen6@hotmail.com          ",
                "vernie_gulgowski57@yahoo.com    ",
                "gaylord_hessel@yahoo.com        ",
                "willis86@hotmail.com            ",
                "heber_gleason@gmail.com         ",
                "jalon_osinski@hotmail.com       ",
                "sylvia_bogan49@gmail.com        ",
                "wendell70@yahoo.com             ",
                "charlie.becker@gmail.com        ",
                "lera.shanahan49@yahoo.com       ",
                "evelyn80@hotmail.com            ",
                "tod_schiller@yahoo.com          ",
                "alice.wisozk@hotmail.com        ",
                "neil63@hotmail.com              ",
                "quinton49@gmail.com             ",
                "florence.corkery41@hotmail.com  ",
                "earnest.vonrueden@gmail.com     ",
                "mia.crona14@gmail.com           ",
                "aisha.murray90@hotmail.com      ",
                "trey.beatty10@gmail.com         ",
                "london.nikolaus@hotmail.com     ",
                "buck_nienow@yahoo.com           ",
                "haylie52@gmail.com              ",
                "cole_miller@gmail.com           ",
                "wilfrid99@hotmail.com           ",
                "emiliano.rau@hotmail.com        ",
                "bonnie4@yahoo.com               ",
                "floy.king@hotmail.com           ",
                "magnolia57@yahoo.com            ",
                "ryan_bernhard@yahoo.com         ",
                "elenora92@hotmail.com           ",
                "jamal.murazik@yahoo.com         ",
                "brenden33@hotmail.com           "
            };

            //foreach (var mail in mails)
            //{
                //string[] res = mail.Remove(mail.IndexOf('@')).Split('.');
                //string name = res[res.Length - 1];
                //string domain=mail.Substring(mail.IndexOf("@")+1);
                //string extension= mail.Substring(mail.LastIndexOf(".")+1);
                //Console.WriteLine(extension);
            //}





            //string[] items =
            //{
            //    "bir",
            //    "iki",
            //    "uc",
            //    "dort",
            //    "besh"
            //};
            //string nm= string.Join(',',items);
            //Console.WriteLine(nm);

            //string text = "code.edu";
            //Console.WriteLine("baku"  +text.PadLeft(40).PadRight(40)+  "azerbaycan");
            #endregion
            #region PracticeeTask
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(-i);
            //    Console.ResetColor();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(i);
            //    Console.ResetColor();
            //}

            //Console.WriteLine(new String('-',30));
            //Console.WriteLine("Bir yazi daxil edin:");
            //string value=Console.ReadLine().Trim();
            //for (int i = value.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(value[i]);
            //}

            //Console.WriteLine(new String('-', 30));
            //int[] numbers = new int[0];
            //char choise;
            //do
            //{

            //    Console.WriteLine("Secim edin");
            //    Console.WriteLine("y-eded daxil etmek ucun");
            //    Console.WriteLine("n-eded arasindaki ferqler ucun");
            //    //Console.WriteLine("s-ededlerin hamisi gormek ucun");
            //    Console.WriteLine("e-cixis ucun");
            //    choise= Convert.ToChar(Console.ReadLine().Trim().ToLower()); 
            //    switch (choise)
            //    {
            //        case 'y':
            //            {
            //                Console.WriteLine("Eded daxil edin:");
            //                int num=int.Parse(Console.ReadLine());
            //                Array.Resize(ref numbers, numbers.Length+1);
            //                numbers= numbers.Append(num).ToArray();
            //                break;
            //            }
            //        case 'n':
            //            {
            //                int big = int.MaxValue;
            //                int small = int.MinValue;
            //                foreach (var item in numbers)
            //                {
            //                    if (item%2!=0)
            //                    {

            //                        for (int i = 0; i < numbers.Length; i++)
            //                        {
            //                            int n = numbers[i];
            //                            if (big<n) big = n;
            //                            if (small > n) small = n;
            //                        }
            //                    }

            //                }
            //                Console.WriteLine($"En Boyuk ve En kicik say arasindaki ferq {big-small} dur");
            //                break;
            //            }
            //        case 'e':
            //            {
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                Console.WriteLine("Good Bye!");
            //                Console.ResetColor();
            //                break;
            //            }
            //        default:
            //            Console.ForegroundColor= ConsoleColor.Red;
            //            Console.WriteLine("Bele secim yoxdur");
            //            Console.ResetColor();
            //            break;
            //    }
            //} while (choise !='e');
            #endregion

        }

    }
}