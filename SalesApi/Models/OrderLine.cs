

using System.Text.Json.Serialization;

namespace SalesApi.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        public int OrderId { get; set; }
        [JsonIgnore] public virtual Order? order { get; set; } 
        public int ItemId { get; set; }
        public virtual Item? Item { get; set; } 
    }
}
