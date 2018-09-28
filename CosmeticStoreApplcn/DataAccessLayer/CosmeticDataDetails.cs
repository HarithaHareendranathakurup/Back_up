using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticEntities;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class CosmeticDataDetails
    {
        private readonly DbContext.CosmeticDbContext dbContext = new DbContext.CosmeticDbContext();
        public List<CosmeticDetails> GetCosmeticDetails()
        {
            List<CosmeticDetails> details = new List<CosmeticDetails>();
            try
            {
                details = dbContext.cosmeticDetails.ToList<CosmeticDetails>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return details;
        }
        public void SaveCosmeticDetails(CosmeticDetails cosmeticDetails)
        {
            try
            {
                dbContext.cosmeticDetails.Add(cosmeticDetails);

                this.dbContext.SaveChanges();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateCosmetic(CosmeticDetails cosmeticDetails)
        {
            
            dbContext.Entry(cosmeticDetails).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteCosmetic(string id)
        {
           CosmeticDetails cosmeticDetails = dbContext.cosmeticDetails.Find(id);
            dbContext.cosmeticDetails.Remove(cosmeticDetails);
            dbContext.SaveChanges();
        }
    }
}



