using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using CosmeticEntities;
namespace BusinessLayer
{
    public class CosmeticManager
    {
        private readonly CosmeticDataDetails cdd = new CosmeticDataDetails();
        public void SaveBookDetail(CosmeticDetails cosmeticDetails)
        {

            cdd.SaveCosmeticDetails(cosmeticDetails);
        }

        public List<CosmeticDetails> GetDetails()
        {
            return cdd.GetCosmeticDetails();
        }
        public void UpdateCosmeticDetail(CosmeticDetails cosmeticDetails)
        {
            cdd.UpdateCosmetic(cosmeticDetails);
        }
        public void DeleteCosmeticDetails(string id)
        {
            cdd.DeleteCosmetic(id);
        }
    }
}
