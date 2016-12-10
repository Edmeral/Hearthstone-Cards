using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context) { GetCategories().ForEach(c => context.Categories.Add(c)); GetProducts().ForEach(p => context.Products.Add(p)); }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Legendary"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Epic"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Rare"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Common"
                },

            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Alexstrasza",
                    Description = "Battlecry: Set a hero's remaining Health to 15.",
                    ImagePath ="Alexstrasza.png",
                    UnitPrice = 1600,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Arcane Giant",
                    Description = "Costs (1) less for each spell you've cast this game.",
                    ImagePath ="Arcane Giant.png",
                    UnitPrice = 800,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Azure Drake",                    
                    Description = "Spell Damage +1. Battlecry: Draw a card.",
                    ImagePath ="Azure Drake.png",
                    UnitPrice = 100,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "C'thun",
                    Description = "Battlecry: Deal damage equal to this minion's Attack randomly split among all enemies.",
                    ImagePath ="C'thun.png",
                    UnitPrice = 1600,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Deathwing",
                    Description = "Battlecry: Destroy all other minions and discard your hand.",
                    ImagePath ="Deathwing.png",
                    UnitPrice = 1600,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Fossilized Devilsaur",
                    Description = "Battlecry: If you control a Beast, gain Taunt.",
                    ImagePath ="Fossilized Devilsaur.png",
                    UnitPrice = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Gadgetzan Auctioneer",
                    Description = "Whenever you cast a spell, draw a card.",
                    ImagePath ="Gadgetzan Auctioneer.png",
                    UnitPrice = 100,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "North Sea Kraken",
                    Description = "Battlecry: Deal 4 damage.",
                    ImagePath = "Kraken.png",
                    UnitPrice = 40,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "N'Zoth, the Corruptor",
                    Description = "Battlecry: Summon your Deathrattle minions that died this game.",
                    ImagePath ="Nztoh.png",
                    UnitPrice = 1600,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Piloted Sky Golem",
                    Description = "Deathrattle: Summon a random 4-Cost minion.",
                    ImagePath ="Piloted Golem.png",
                    UnitPrice = 800,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Sea Giant",
                    Description = "Costs (1) less for each other minion on the battlefield.",
                    ImagePath ="Sea Giant.png",
                    UnitPrice = 800,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Sunwalker",
                    Description = "Taunt Divine Shield",
                    ImagePath ="Sunwalker.png",
                    UnitPrice = 100,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Yogg-Saron, Hope's End",
                    Description = "Battlecry: Cast a random spell for each spell you've cast this game (targets chosen randomly).",
                    ImagePath ="Yogg-saron.png",
                    UnitPrice = 1600,
                    CategoryID = 1
                },

            };

            return products;
        }
    }
}