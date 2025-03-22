using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Saber.Database.Models
{
    [Index(nameof(Source))]
    public class OneLinerQuote
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string GXT { get; set; } = string.Empty;
        
        [MaxLength(50)]
        public string ImgurLink { get; set; } = string.Empty;
        
        [MaxLength(255)]
        public string DiscordLink { get; set; } = string.Empty;
        
        [MaxLength(4000)]
        public string Quote { get; set; } = string.Empty;
        
        public OneLinerSource Source { get; set; } = OneLinerSource.NONE;
    }

    public enum OneLinerSource
    {
        [Display(Name = "None")]
        NONE,
        [Display(Name = "GTA 1")]
        GTA1,
        [Display(Name = "GTA 2")]
        GTA2,
        [Display(Name = "GTA Advance")]
        GTAADVANCE,
        [Display(Name = "GTA Chinatown Wars")]
        GTACTW,
        [Display(Name = "GTA III")]
        GTAIII,
        [Display(Name = "GTA IV")]
        GTAIV,
        [Display(Name = "GTA IV - The Ballad of Gay Tony")]
        GTAIVTBOGT,
        [Display(Name = "GTA IV - The Lost and Damned")]
        GTAIVTLAD,
        [Display(Name = "GTA Liberty City Stories")]
        GTALCS,
        [Display(Name = "GTA San Andreas")]
        GTASA,
        [Display(Name = "GTA V")]
        GTAV,
        [Display(Name = "GTA Vice City")]
        GTAVC,
        [Display(Name = "GTA Vice City Definitive Edition")]
        GTAVCDE,
        [Display(Name = "GTA Vice City Stories")]
        GTAVCS,
        [Display(Name = "LA Noire")]
        LANOIRE,
        [Display(Name = "Mafia")]
        MAFIA,
        [Display(Name = "Mafia 2")]
        MAFIA2,
        [Display(Name = "Mafia 3")]
        MAFIA3,
        [Display(Name = "Mafia Definitive Edition")]
        MAFIADE,
        [Display(Name = "Manhunt")]
        MANHUNT,
        [Display(Name = "Manhunt 2")]
        MANHUNT2,
        [Display(Name = "Max Payne 3")]
        MAXPAYNE3,
        [Display(Name = "Midnight Club LA")]
        MCLA,
        [Display(Name = "Red Dead Redemption")]
        RDR,
        [Display(Name = "Red Dead Redemption 2")]
        RDR2,
        [Display(Name = "Bully")]
        BULLY,
        [Display(Name = "The Sopranos: Road to Respect")]
        THESOPRANOSGAME,
        [Display(Name = "The Warriors")]
        THEWARRIORS,
        [Display(Name = "The Last of Us")]
        TLOU,

        // MOVIES & TV
        [Display(Name = "Alien")]
        ALIEN,
        [Display(Name = "Aliens")]
        ALIENS,
        [Display(Name = "Avengers: Endgame")]
        AVENGERSENDGAME,
        [Display(Name = "Avengers: Infinity War")]
        AVENGERSINFINITYWAR,
        [Display(Name = "Die Hard 1")]
        DIEHARD1,
        [Display(Name = "Die Hard 2")]
        DIEHARD2,
        [Display(Name = "Goodfellas")]
        GOODFELLAS,
        [Display(Name = "Scarface")]
        SCARFACE,
        [Display(Name = "The Sopranos")]
        SOPRANOS,
        [Display(Name = "The Terminator 2")]
        TERMINATOR2,
        [Display(Name = "The Godfather")]
        THEGODFATHER,
        [Display(Name = "The Godfather 2")]
        THEGODFATHER2,
        [Display(Name = "The Godfather 3")]
        THEGODFATHER3,
        [Display(Name = "The Many Saints of Newark")]
        THEMANYSAINTSOFNEWARK,
        [Display(Name = "The Terminator")]
        THETERMINATOR,
    }
}
