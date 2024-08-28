using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace LeetCode.AzureRedis
{
    public class RedisSample
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("");
        public void AddToSet(string key,string value) {
            IDatabase db = redis.GetDatabase();
            db.SetAdd(new RedisKey(key), new RedisValue(value));
        }
        public string GetValueFromSet(string key)
        {
            IDatabase db = redis.GetDatabase();
            //return db.SetPop(new RedisKey(key));
            RedisValue[] values =  db.SetMembers(new RedisKey(key));
            return values[0].ToString();
        }
        public bool SetContains(string key,string value)
        {
            IDatabase db = redis.GetDatabase();
            //return db.SetPop(new RedisKey(key));
            bool result =db.SetContains(new RedisKey(key),new RedisValue(value));
            return result;
        }
    }
}
