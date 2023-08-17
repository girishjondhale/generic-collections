using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genaric_collections
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public int price { set; get; }


        public string PrintDetails()
        {
            return ($"product id {id}, name={name}, price={price}");
        }

    }
}
