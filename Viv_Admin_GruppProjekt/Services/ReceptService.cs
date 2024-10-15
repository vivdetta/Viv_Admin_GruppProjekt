using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Viv_Admin_GruppProjekt.Models;
using Viv_Admin_GruppProjekt.Utils;

namespace Viv_Admin_GruppProjekt.Services
{
    public class ReceptService
    {
        private readonly List<Recept> _receipts = new List<Recept>();
        private readonly string _receiptMasterPath = DirectoriesHelper.GetJsonReceptPath();

        public void OpenReceptsAndWriteToList()
        {
            var json = File.ReadAllText(_receiptMasterPath);
            var receptsFromFile = JsonSerializer.Deserialize<List<Recept>>(json);

            if (receptsFromFile != null)
            {
                foreach (var recept in receptsFromFile)
                {
                    // Ensure each Recept has an Id; generate a new one if it's missing
                    if (recept.Id == Guid.Empty)
                    {
                        recept.Id = Guid.NewGuid();
                    }

                    _receipts.Add(recept);
                }
                SaveReceptsToFile();
            }
        }

        public void SaveReceptsToFile()
        {
            var json = JsonSerializer.Serialize(_receipts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_receiptMasterPath, json);
        }

        public List<Recept> GetRecepts()
        {
            return _receipts;
        }

        public void CreateRecept(Recept newRecept)
        {
            _receipts.Add(newRecept);
            SaveReceptsToFile();
        }

        public void UpdateRecept(Recept oldRecept, Recept newRecept)
        {
            var existingRecept = _receipts.FirstOrDefault(recept => recept.Id == oldRecept.Id);

            if (existingRecept != null)
            {
                existingRecept.Name = newRecept.Name;
                existingRecept.Description = newRecept.Description;
                existingRecept.TypeOfRecept = newRecept.TypeOfRecept;
                SaveReceptsToFile();
            }
        }

        public void DeleteRecept(Recept receptToDelete)
        {
            var recept = _receipts.FirstOrDefault(r => r.Id == receptToDelete.Id);
            if (recept != null)
            {
                _receipts.Remove(recept);
                SaveReceptsToFile();
            }
        }

        public Recept FromStringToObject(string searchChoice)
        {
            var splitString = searchChoice.Split('|');
            if (splitString.Length == 2)
            {
                string namePart = splitString[0].Trim();
                string typePart = splitString[1].Trim();

                // Extract the name (removing the "Name: " prefix)
                string name = namePart.Replace("Name: ", "").Trim();

                // Extract the type (removing the "Type of Receipt: " prefix)
                string type = typePart.Replace("Type of Receipt:", "").Trim();

                return _receipts.FirstOrDefault(recept => recept.Name == name && recept.TypeOfRecept == type);
            }
            return null;
        }

        public List<Recept> SearchRecepts(string searchTerm, bool searchByName, bool searchByType)
        {
            searchTerm = searchTerm.ToLower();

            if (searchByName && searchByType)
            {
                return _receipts.Where(recept => recept.Name.ToLower().Contains(searchTerm)
                                              || recept.TypeOfRecept.ToLower().Contains(searchTerm)).ToList();
            }
            else if (searchByName)
            {
                return _receipts.Where(recept => recept.Name.ToLower().Contains(searchTerm)).ToList();
            }
            else if (searchByType)
            {
                return _receipts.Where(recept => recept.TypeOfRecept.ToLower().Contains(searchTerm)).ToList();
            }
            else
            {
                return new List<Recept>();
            }
        }
    }



}
