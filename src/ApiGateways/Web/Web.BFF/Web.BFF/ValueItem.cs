namespace Web.BFF
{
    public class ValueItem
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public ValueItem(int id, string value)
        {
            Id = id;
            Value = value;
        }
    }
}
