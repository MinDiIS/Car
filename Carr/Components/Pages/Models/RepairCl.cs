namespace Carr.Services;
using Carr;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

public class RepairCl
{
    public IList<Client?> ClientPage { get; private set; } = new List<Client?>();
    public Client NewClient { get; set; } = new Client();
    private const string FilePath = "ClientPage.json";
    
    public void OpenFile()
    {
        if (!File.Exists(FilePath))
        {
            SaveFile();
            return;
        }

        string jsonData = File.ReadAllText(FilePath);
        ClientPage = JsonConvert.DeserializeObject<List<Client>>(jsonData) ?? new List<Client?>();
    }

    public void SaveFile()
    {
        string jsonData = JsonConvert.SerializeObject(ClientPage);
        File.WriteAllText(FilePath, jsonData);
    }

    public void AddClient()
    {
        NewClient.Id = ClientPage.Count == 0 ? 1 : ClientPage.Max(c => c.Id) + 1;
        ClientPage.Add(NewClient);
        NewClient = new Client();
        SaveFile();
    }
    
    public void RemoveClient(Client? client)
    {
        if (client != null && ClientPage.Contains(client))
        {
            ClientPage.Remove(client);
            SaveFile();
        }
    }
}