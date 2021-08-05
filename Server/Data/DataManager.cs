namespace Server.Data
{
    using Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataManager : DbContext
    {
        // Контекст настроен для использования строки подключения "DataManager" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Server.Data.DataManager" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataManager" 
        // в файле конфигурации приложения.
        public DataManager()
            : base("name=MyData")
        {
            
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Chat> Chats{ get; set; }
        public virtual DbSet<Message> Messages{ get; set; }
        public virtual DbSet<Group> Groups{ get; set; }
        public virtual DbSet<User> Users{ get; set; }
        public virtual DbSet<Server> Servers{ get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}