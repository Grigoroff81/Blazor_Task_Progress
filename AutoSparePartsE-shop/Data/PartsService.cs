using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSparePartsE_shop.Data
{
    public class PartsService
    {
        public Task<Product[]> GetAllPartsService()
        {
            //1. get the file and read it
            var path = @"C:\Users\Ivo\Desktop\GITFolders\Blazor_Task_Progress\AutoSparePartsE-shop\Data\Database.json";
            string jsonFile = File.ReadAllText(path);
            //2. Access Model class and deserialize
            var p = JsonConvert.DeserializeObject<Product[]>(jsonFile);
            return Task.FromResult(p);
        }
    }
}
