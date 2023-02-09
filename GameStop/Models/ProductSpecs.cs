using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class ProductSpecs : BaseEntity
    {
        public string UPC { get; set; }

        [MaxLength(255)]
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }

        [DisplayName("GameStop Exclusive")]
        public bool IsExclusive { get; set; }
        [DisplayName("Number of Players")]
        public string NumberOfPlayers{ get; set; }
        
        [DisplayName("Number of Online Players")]
        public string OnlinePlayers { get; set; }

        [MaxLength(60)]
        public string Perspective { get; set; }

        [MaxLength(60)]
        public string Genre { get; set; }
        [DisplayName("Online Multiplayer")]
        public string IsOnline { get; set; }

        public string Franchise { get; set; }
        [DisplayName("Publisher Name")]
        public string PublisherName { get; set; }
        [DisplayName("Developer Name")]
        public string DeveloperName { get; set; }
        public string Manufacturer { get; set; }

        // DIMENSION 
        [DisplayName("Product Length")]
        public string ProdLength  { get; set; }
        [DisplayName("Product Width")]
        public string ProdWidth  { get; set; }
        [DisplayName("Product Height")]
        public string ProdHeight  { get; set; }
        [DisplayName("Product Unit of Measure")]
        public string UnitOfMeasure  { get; set; }
        [DisplayName("Product Weight")]
        public string ProdWeight  { get; set; }
        [DisplayName("Product Weight Unit of Measure")]
        public string WeightUntOfMeasure  { get; set; }




    }
}
