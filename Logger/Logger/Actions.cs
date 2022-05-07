namespace Logger
{
    public class Actions
    {
        Starter starter = new Starter();

        string str = string.Empty;

        public Result StartMethod()
        {
            Result objectResult = new Result(true);

            var massageError = Logger.TypeOfSmth.Info;

            str = $"{DateTime.Now:H:mm:ss} {massageError}";
            starter.WriteText(str);
            starter.Save();

            Console.WriteLine(str);
            return objectResult;
        }

        public Result SkippedLogicInMethod()
        {
            Result objectResult = new Result(true);

            var massageError = Logger.TypeOfSmth.Warning;

            str = $"{DateTime.Now:H:mm:ss} {massageError}";
            starter.WriteText(str);
            starter.Save();

            Console.WriteLine(str);
            return objectResult;
        }

        public Result Method()
        {
            Result objectResult = new Result(false);
            Logger logger = new Logger();

            var resultMassage = logger.MassageLogger + objectResult.MassageError;
            var massageError = Logger.TypeOfSmth.Error;

            str = $"{DateTime.Now:H:mm:ss} {massageError} {resultMassage}";
            starter.WriteText(str);
            starter.Save();

            Console.WriteLine(str);
            return objectResult;
        }
    }
}
