using System;
namespace evalucion_bayteq.Models
{
    public class PetModel
    {
        public Int64 id { get; set; }
        public Category? category { get; set; }
        public string name { get; set; }
        public List<string>? photoUrls { get; set; }
        public List<Tags>? tags { get; set; }
        public string status { get; set; }

        public PetModel()
        {
            id = 0;
            name = "";
            status = "";
        }


    }

    public class Category
    {
        public Int64 id { get; set; }
        public string name { get; set; }
    }

    public class Tags
    {
        public Int64 id { get; set; }
        public string name { get; set; }
    }
}

