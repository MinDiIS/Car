// RepairSE.cs
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Carr.Services
{
    public class RepairSE
    {
        public IList<Repair> ServicesPage { get; private set; } = new List<Repair>();
        public Repair NewService { get; set; } = new Repair();
        private const string FilePath = "ServicesPage.json";
        
        public void OpenFile()
        {
            string jsonData = File.ReadAllText(FilePath);
            ServicesPage = JsonConvert.DeserializeObject<List<Repair>>(jsonData) ?? new List<Repair>();
        }

        public void SaveFile()
        {
            string jsonData = JsonConvert.SerializeObject(ServicesPage);
            File.WriteAllText(FilePath, jsonData);
        }

        public void AddService()
        {
            NewService.Id = ServicesPage.Count == 0 ? 1 : ServicesPage.Max(s => s.Id) + 1;
            ServicesPage.Add(NewService);
            NewService = new Repair();
            SaveFile();
        }

        public void RemoveService(Repair service)
        {
            if (ServicesPage.Contains(service))
            {
                ServicesPage.Remove(service);
                SaveFile();
            }
        }

        public void LoadServices()
        {
            throw new NotImplementedException();
        }
    }
}