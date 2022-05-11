namespace Logger
{
    public class Actions
    {

        WriteMethod writeMethod = new WriteMethod();
        Result objectResult = new Result();
        Logger logger = new Logger();

        string str = string.Empty;

        public void WriteInConsole(string str)
        {

            writeMethod.WriteText(str);
            writeMethod.Save();
            Console.WriteLine(str);

        }

        public void Status(bool status)
        {
            if (status == true)
            {
                objectResult.MessageError = string.Empty;
            }
            else if (status == false)
            {
                objectResult.MessageError = "I broke a logic";
            }
        }

        public Result StartMethod()
        {
            Status(objectResult.Status);
            var massageError = LogType.LogTypes.Info;
            str = $"{DateTime.Now:H:mm:ss} {massageError}";
            WriteInConsole(str);

            return objectResult;
        }

        public Result SkippedLogicInMethod()
        {
            Status(objectResult.Status);
            var massageError = LogType.LogTypes.Warning;
            str = $"{DateTime.Now:H:mm:ss} {massageError}";
            WriteInConsole(str);

            return objectResult;
        }

        public Result Method()
        {
            Status(objectResult.Status = false);
            var resultMassage = logger.MessageLogger + objectResult.MessageError;
            var massageError = LogType.LogTypes.Error;
            str = $"{DateTime.Now:H:mm:ss} {massageError} {resultMassage}";
            WriteInConsole(str);

            return objectResult;
        }
    }
}
