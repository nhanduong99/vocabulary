using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VocabulariesOfEconomics.Models;

namespace VocabulariesOfEconomics.Repositories.VocabularyRepository
{
    
    public interface IVocabularyRepository
    {
        IDbConnection CreateConnection();
        Task<IEnumerable<VocabularyModel>> GetListVoca(VocabularyQueryModel model);
        VocabularyModel GetVocaDetails(VocabularyQueryModel model);
        int UpdateVoca(VocabularyModel model);
        int AddVoca(VocabularyModel model);
    }
}
