namespace RestApiModelDDD.Domain.Entities
{
    public class Produto : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsAvailable { get; set; }
    }
}
