namespace MongoDbChatClient
{
    using System;

    using MongoDB.Driver;

    public class Program
    {
        static void Main(string[] args)
        {
            string connectionDb = "mongodb://telerik:chat@ds035300.mongolab.com:35300/mongochat";
            var dbContext = GetMongoDatabase(connectionDb);
            var chat = new Chat(dbContext);

            chat.Start();
        }

        private static MongoDatabase GetMongoDatabase(string connection)
        {
            var client = new MongoClient(connection);
            var server = client.GetServer();
            var dbContext = server.GetDatabase("mongochat");

            return dbContext;
        }
    }
}