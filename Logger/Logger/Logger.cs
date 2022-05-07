namespace Logger
{
    public class Logger
    {
        public string MassageLogger { get; } = "Action failed by a reson: ";

        public enum TypeOfSmth
        {
            Error,
            Warning,
            Info
        }
    }
}
