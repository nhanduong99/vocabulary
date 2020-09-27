using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VocabulariesOfEconomics.Models;

namespace VocabulariesOfEconomics.Repositories.VocabularyRepository
{
    public class VocabularyRepository : IVocabularyRepository
    {
        public IDbConnection CreateConnection()
        {
            var conStr = @"Data Source=DESKTOP-QNB473I;Initial Catalog=Vocabulary;Integrated Security=True";
            var connection = new SqlConnection(conStr);
            connection.Open();
            return connection;
        }
        public async Task<IEnumerable<VocabularyModel>> GetListVoca(VocabularyQueryModel model)
        {
            try
            {
                var parameter = new DynamicParameters();
                using IDbConnection dbConnection = CreateConnection();
                string queryString = "SELECT ID,ENGLISH,VIETNAMESE,SPELLING FROM VOCABULARY WHERE 1=1 ";
                if (!string.IsNullOrEmpty(model.FilterBy))
                {
                    queryString += " AND (ENGLISH=@FilterText ";
                    queryString += " or VIETNAMESE=@FilterText)";
                    parameter.Add("@FilterText", model.FilterText);
                }
                else if (model.FilterBy == "VIETNAMESE")
                {
                    queryString += " AND VIETNAMESE=@FilterText";
                    parameter.Add("@FilterText", model.FilterText);
                }
                else if (model.FilterBy == "ENGLISH")
                {
                    queryString += " AND ENGLISH=@FilterText";
                    parameter.Add("@FilterText", model.FilterText);
                }
                var result = await dbConnection.QueryAsync<VocabularyModel>(queryString, parameter);
                return result.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
