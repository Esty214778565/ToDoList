using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarRental.Data
{
    public class DataContext
    {
        public List<CarEntity>Cars { get; set; }
        public List<UserEntity>Users { get; set; }
        public List<CollectionPointEntity>CollectionPoints { get; set; }
        public List<InvitationEntity>Invitations { get; set; }
      
        public DataContext()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = File.ReadAllText(path);
            Users = JsonSerializer.Deserialize<List<UserEntity>>(jsonString);
            //add

        }

        public void LoadData()
        {
           

        }

        public void SaveData()
        {
            
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                string jsonString = JsonSerializer.Serialize(Users);
                File.WriteAllText(path, jsonString);
        }

    }
}
