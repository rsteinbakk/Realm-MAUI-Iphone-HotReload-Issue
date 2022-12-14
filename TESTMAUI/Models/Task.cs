using MongoDB.Bson;
using Realms.Sync;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTMAUI.Models
{
    public class TaskObj : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        [MapTo("_partition")]
        [Required]
        public string Partition { get; set; }
        [MapTo("name")]
        public string Name { get; set; }
    }
}