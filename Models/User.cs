using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace JWTMongo.Models
{
    [CollectionName("users")]
    public class User : MongoIdentityUser<Guid>
    {
        public string FullName { get; set; }  = string.Empty;
    }
}