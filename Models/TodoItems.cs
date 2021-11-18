namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string PickUpPoint { get; set; }
        public string Destination { get; set; }
        public long Current_Location_Latitude { get; set; }
        public long Current_Location_Longitude { get; set; }
        public bool IsComplete { get; set; }
    }
}