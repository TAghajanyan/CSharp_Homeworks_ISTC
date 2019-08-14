namespace ThirdStage.Collections
{
    public class Custom 
    {
        public Custom Next { get; set; } 
        public string Value { get; }

        public Custom(object value)
        {
            Value = value as string;
        }
    }
}
