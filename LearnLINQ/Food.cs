namespace LearnLINQ
{
    class Food(int id, string name, FoodType foodType, decimal price)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public FoodType FoodType { get; set; } = foodType;
        public decimal Price { get; set; } = price;

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {FoodType}, Price: {Price}";
        }
    }
}
