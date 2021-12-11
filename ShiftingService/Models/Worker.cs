namespace ShiftingService.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }

    }
    public class ShiftDetail
    {
        public int WorkerID { get; set; }
        public ShiftType ShiftType { get; set; }

        public DateTime Shiftdate { get; set; }
    }

    public class Data
    {
        public static List<ShiftDetail> lst = new List<ShiftDetail>();
    }

    public enum ShiftType
    {
        Shift1 ,
        Shift2 ,
        Shift3 
    }
}
