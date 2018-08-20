using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartGroupChallenge.Models
{
    public class Product
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GameImage { get; set; }
        public float GamePrice { get; set; }
    }
}
