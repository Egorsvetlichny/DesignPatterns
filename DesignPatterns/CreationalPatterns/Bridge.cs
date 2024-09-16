using System;

namespace DesignPatterns.CreationalPatterns
{
    public interface IDataSource
    {
        object GetData();
    }

    public class DataBaseSource : IDataSource
    {
        public object GetData()
        {
            return "Данные из базы данных";
        }
    }

    public class FileSource : IDataSource
    {
        public object GetData()
        {
            return "Данные из файла";
        }
    }

    public abstract class DataSender
    {
        public IDataSource DataSource { get; private set; }

        protected DataSender(IDataSource dataSource)
        {
            DataSource = dataSource;
        }

        public void SetDataSource(IDataSource dataSource)
        {
            DataSource = dataSource;
        }

        public abstract void SendData();
    }

    public class TelegramSender : DataSender
    {
        public TelegramSender(IDataSource dataSource = null) : base(dataSource) { }

        public override void SendData()
        {
            Console.WriteLine($"Используем - {DataSource.GetData()}");
            Console.WriteLine("Отправляем данные в телеграм\n");
            //-----Реализация отправки полученных данных в телеграм-----
        }
    }

    public class EmailSender : DataSender
    {
        public EmailSender(IDataSource dataSource = null) : base(dataSource) { }

        public override void SendData()
        {
            Console.WriteLine($"Используем - {DataSource.GetData()}");
            Console.WriteLine("Отправляем данные по email\n");
            //-----Реализация отправки полученных данных по почте-----
        }
    }

    public class FaxSender : DataSender
    {
        public FaxSender(IDataSource dataSource = null) : base(dataSource) { }

        public override void SendData()
        {
            Console.WriteLine($"Используем - {DataSource.GetData()}");
            Console.WriteLine("Отправляем данные по факсу\n");
            //-----Реализация отправки полученных данных по факсу-----
        }
    }
}
