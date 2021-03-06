﻿namespace MongoDbChatClient
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;
    using System.Linq;

    public class Chat
    {
        private readonly MongoDatabase db;

        public Chat(MongoDatabase database)
        {
            this.db = database;
        }

        public void Start()
        {
            var messages = this.db.GetCollection<BsonDocument>("Messages");
            string username = "";

            do
            {
                Console.Write("Please inter your username: ");
                username = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(username));
            
            while (true)
            {
                Console.Write("Enter your message: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    var newMessage = new BsonDocument
                    {
                        { "Author", username },
                        { "Text", input },
                        { "Time", DateTime.Now }
                    };

                    // Adding the new message to database
                    messages.Insert(newMessage);
                }

                // Get all messages from database
                var formattedMessages = messages
                                                .FindAll()
                                                .Select(m => string.Format("[{0}] {1}: {2}",
                                                    m["Time"].ToLocalTime(),
                                                    m["Author"],
                                                    m["Text"]));

                string output = string.Join(Environment.NewLine, formattedMessages);
                Console.WriteLine(output);
            }
        }
    }
}