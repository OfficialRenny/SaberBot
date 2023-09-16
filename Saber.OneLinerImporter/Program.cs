using Saber.Common;
using Saber.Database;
using Saber.Database.Models;
using Saber.Database.Providers;
using Newtonsoft.Json;

namespace Saber.OneLinerImporter
{
    internal class Program
    {
        static Db Db { get; set; }
        static GenericProvider<OneLinerQuote> Provider { get; set; }

        static Dictionary<OneLinerSource, List<OneLinerQuote>> OneLiners = new();

        static Program()
        {
            Db = new DbFactory().CreateDbContext();
            Provider = new GenericProvider<OneLinerQuote>(Db);
        }

        static void Main(string[] args)
        {
            string basePath = @"G:\OneLinerInputs";
            FileInfo[] files = new DirectoryInfo(basePath).GetFiles();

            foreach (var file in files)
            {
                var source = FileNameToSource(file.Name.Replace(".json", ""));
                var json = File.ReadAllText(file.FullName);
                var data = JsonConvert.DeserializeObject<OneLinerImport>(json);

                if (data == null)
                {
                    Console.WriteLine($"No data found in {file.Name}");
                    continue;
                }

                foreach (var oneLiner in data.Data)
                {
                    var gxt = oneLiner[0];
                    var imgurLink = oneLiner[1];
                    var discordLink = oneLiner[2];
                    var quote = oneLiner[3];

                    // add to OneLiners dict
                    if (!OneLiners.ContainsKey(source))
                        OneLiners.Add(source, new List<OneLinerQuote>());

                    OneLiners[source].Add(new OneLinerQuote { GXT = gxt, ImgurLink = imgurLink, DiscordLink = discordLink, Quote = quote, Source = source });
                }

            }

            foreach (var oneLiner in OneLiners.SelectMany(x => x.Value))
            {
                Console.WriteLine($"\"{oneLiner.GXT}\" - {oneLiner.Quote}");
                Provider.Add(oneLiner);
            }

            var changes = Provider.Save();
            Console.WriteLine($"Saved {changes} changes to the database.");

            Console.WriteLine("Press the enter key to exit...");
            Console.ReadLine();
        }

        static OneLinerSource FileNameToSource(string filename) => filename switch
        {
            "alien" => OneLinerSource.ALIEN,
            "aliens" => OneLinerSource.ALIENS,
            "avengersendgame" => OneLinerSource.AVENGERSENDGAME,
            "avengersinfinitywar" => OneLinerSource.AVENGERSINFINITYWAR,
            "bullywd" => OneLinerSource.BULLY,
            "diehard1" => OneLinerSource.DIEHARD1,
            "diehard2" => OneLinerSource.DIEHARD2,
            "goodfellas" => OneLinerSource.GOODFELLAS,
            "gta1wd" => OneLinerSource.GTA1,
            "gta2wd" => OneLinerSource.GTA2,
            "gta3wd" => OneLinerSource.GTAIII,
            "gtaadvancewd" => OneLinerSource.GTAADVANCE,
            "gtactwwd" => OneLinerSource.GTACTW,
            "gtaivtbogtwd" => OneLinerSource.GTAIVTBOGT,
            "gtaivtladwd" => OneLinerSource.GTAIVTLAD,
            "gtaivwd" => OneLinerSource.GTAIV,
            "gtalcswd" => OneLinerSource.GTALCS,
            "gtasawd" => OneLinerSource.GTASA,
            "gtavcdewd" => OneLinerSource.GTAVCDE,
            "gtavcwd" => OneLinerSource.GTAVC,
            "gtavcswd" => OneLinerSource.GTAVCS,
            "gtavwd" => OneLinerSource.GTAV,
            "lanoirewd" => OneLinerSource.LANOIRE,
            "mafiawd" => OneLinerSource.MAFIA,
            "mafia2wd" => OneLinerSource.MAFIA2,
            "mafia3wd" => OneLinerSource.MAFIA3,
            "mafiadewd" => OneLinerSource.MAFIADE,
            "manhuntwd" => OneLinerSource.MANHUNT,
            "manhunt2wd" => OneLinerSource.MANHUNT2,
            "maxpayne3wd" => OneLinerSource.MAXPAYNE3,
            "mclawd" => OneLinerSource.MCLA,
            "rdrwd" => OneLinerSource.RDR,
            "rdr2wd" => OneLinerSource.RDR2,
            "scarface" => OneLinerSource.SCARFACE,
            "sopranos" => OneLinerSource.SOPRANOS,
            "sopranoswd" => OneLinerSource.THESOPRANOSGAME,
            "terminator2" => OneLinerSource.TERMINATOR2,
            "thegodfather" => OneLinerSource.THEGODFATHER,
            "thegodfather2" => OneLinerSource.THEGODFATHER2,
            "thegodfather3" => OneLinerSource.THEGODFATHER3,
            "themanysaintsofnewark" => OneLinerSource.THEMANYSAINTSOFNEWARK,
            "theterminator" => OneLinerSource.THETERMINATOR,
            "thewarriorswd" => OneLinerSource.THEWARRIORS,
            "tlouwd" => OneLinerSource.TLOU,
            _ => OneLinerSource.NONE
        };
        
    }

    internal class OneLinerImport
    {
        public List<List<string>> Data { get; set; } = new();
    }
}