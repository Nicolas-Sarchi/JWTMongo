using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace JWTMongo.Models
{
    [CollectionName("roles")]
    public class Role : MongoIdentityRole<Guid>
    {
        
    }
}