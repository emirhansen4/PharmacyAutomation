using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Services
{
    public class RecipeData
    {
        public int RecipeNumber { get; set; }
        public string Name { get; set; }
        public string DoctorName { get; set; }
        public string TC { get; set; }
        public bool SGK { get; set; }
    }

    public class MedicineData
    {
        public string Name { get; set; }
        public int count { get; set; }
    }

    public class RandonDataGenerator
    {
        string[] randomNames = { "Ali", "Ayşe", "Mehmet", "Zeynep", "Mustafa", "Fatma", "Emre", "Ceren", "Eren", "Elif", "Ahmet", "Melis", "Selin", "Can", "Deniz", "Gizem", "Burak", "Aslı", "Tolga", "Aylin", "Oğuz", "Gamze", "Kerem", "Esra", "Hakan", "Nazlı", "Berk", "Derya", "Ege" };
        string[] randomSurnames = { "Yılmaz", "Kaya", "Demir", "Şahin", "Aydın", "Yıldırım", "Koç", "Çelik", "Aksoy", "Özdemir", "Arslan", "Kara", "Güneş", "Erdoğan", "Kurt", "Kaplan", "Türk", "Aslan", "Güzel", "Öztürk", "Eren", "Erdem", "Avcı", "Aksu", "Yavuz", "Taş", "Sarı", "Tekin", "Şen" };
        string[] medicine = { "Ciprofloxacin", "Ibuprofen", "Paracetamol","Aspirin","Dolerex", "Parol", "Ventolin", "Amoklavin", "Nurofen", "Cipro", "Voltaren"};

        Random rnd = new Random();

        public RecipeData GetPatientDetail()
        {
            string Tc = "";
            for (int i = 0; i < 11; i++)
            {
                Tc += rnd.Next(0, 10);
            }
            RecipeData recipe = new RecipeData()
            {
                
                Name = randomNames[rnd.Next(randomNames.Length)] + " " + randomSurnames[rnd.Next(randomNames.Length)],
                DoctorName = randomNames[rnd.Next(randomNames.Length)] + " " + randomSurnames[rnd.Next(randomNames.Length)],
                TC = Tc,
                SGK = rnd.Next(1, 10) % 2 == 0
            };
                return recipe;
        }

        public List<MedicineData> GetMedicine()
        {
            List<MedicineData> medicineDatas = new List<MedicineData>();

            for (int i = 0; i < rnd.Next(1, 6); i++)
            {
                
                MedicineData medicineValue = new MedicineData()
                {
                    Name = medicine[rnd.Next(medicine.Length)],
                    count = 1,

                };
                if (rnd.Next(1, 6) == 3)
                {
                    medicineValue.count = rnd.Next(1, 3);
                }
                if (medicineDatas.Find(x => x.Name == medicineValue.Name) == null)
                { medicineDatas.Add(medicineValue); }
                

            }

            return medicineDatas;

        }
    }

}

