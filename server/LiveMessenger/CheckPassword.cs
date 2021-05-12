using Microsoft.AspNetCore.Http;
using System;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace LiveMessenger
{
    public class CheckPassword
    {
        public static bool isCorrect(string password, string roomID)
        {
            BsonDocument document = GetRoom.RetrieveOneRoom(roomID);
            if (password != null && password == document.GetElement("Password").Value) return true;
            return false;
        }
    }
}