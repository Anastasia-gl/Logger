namespace Logger
{
    public class Result
    {
        public bool Status { get; set; }

        public string MassageError { get; } = "I broke a logic";

        public Result()
        {
        }

        public Result(bool status)
        {
            Status = status;
        }
    }
}
