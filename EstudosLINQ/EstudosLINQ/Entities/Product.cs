using System.Globalization;

namespace EstudosLINQ.Entities {
    class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString() {
            return Id + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InstalledUICulture) + ", " + Category.Name + ", " + Category.Tier;
        }
    }

}
