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
            // create connectionString
            var conStr = @"Data Source=DESKTOP-QNB473I;Initial Catalog=Vocabulary;Integrated Security=True";
            // khởi tạo connection dùng SqlConnection
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
                string queryString = @"SELECT ID,WORD,ENGLISH,VIETNAMESE,SPELLING 
                                       FROM VOCABULARY 
                                       WHERE 1=1 ";
                if (!string.IsNullOrEmpty(model.FilterText)) {
                    if (!string.IsNullOrEmpty(model.FilterBy))
                    {
                        if (model.FilterBy == "VIETNAMESE")
                        {
                            queryString += $" AND LOWER(VIETNAMESE) like '%{model.FilterText.ToLower()}%'";
                        }
                        if (model.FilterBy == "ENGLISH")
                        {
                            queryString += $" AND LOWER(ENGLISH) like '%{model.FilterText.ToLower()}%'";
                        }
                        if (model.FilterBy == "WORD")
                        {
                            queryString += $" AND LOWER(WORD) like '%{model.FilterText.ToLower()}%'";
                        }
                    }
                    else
                    {
                        queryString += $" AND (LOWER(VIETNAMESE) like '%{model.FilterText.ToLower()}%' ";
                        queryString += $" or LOWER(ENGLISH) like '%{model.FilterText.ToLower()}%' ";
                        queryString += $" or LOWER(WORD) like '%{model.FilterText.ToLower()}%' )";
                    }
                }
                
                var result = await dbConnection.QueryAsync<VocabularyModel>(queryString, parameter);
                return result.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public VocabularyModel GetVocaDetails(VocabularyQueryModel model)
        {
            try
            {
                var parameter = new DynamicParameters();
                using IDbConnection dbConnection = CreateConnection();
                // query select, truyền tham số kiểu $
                string queryString = $@"SELECT ID,WORD,ENGLISH,VIETNAMESE,SPELLING 
                                        FROM VOCABULARY 
                                        WHERE ID={model.ID} ";

                var result = dbConnection.Query<VocabularyModel>(queryString, parameter);
                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int UpdateVoca(VocabularyModel model)
        {
            try
            {
                var DbConnection = CreateConnection();
                var parameter = new DynamicParameters();
                // query cập nhật dữ liệu trong database
                var queryString = @"UPDATE VOCABULARY 
                                    SET WORD=@WORD,ENGLISH=@ENGLISH,VIETNAMESE=@VIETNAMESE,SPELLING=@SPELLING 
                                    WHERE ID=@ID";
                // truyền tham số
                parameter.Add("WORD", model.WORD);
                parameter.Add("ENGLISH",model.ENGLISH);
                parameter.Add("VIETNAMESE",model.VIETNAMESE);
                parameter.Add("SPELLING",model.SPELLING);
                parameter.Add("ID", model.ID);
                // gọi Execute để trả về số dòng ảnh hưởng khi update
                var result = DbConnection.Execute(queryString, parameter);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int AddVoca(VocabularyModel model)
        {
            try
            {
                var DbConnection = CreateConnection();
                var parameter = new DynamicParameters();
                // query thêm dữ liệu vào database
                var queryString = @"INSERT INTO VOCABULARY (WORD,ENGLISH,VIETNAMESE,SPELLING) 
                                                    VALUES (@WORD,@ENGLISH,@VIETNAMESE,@SPELLING)";
                // truyền tham số
                parameter.Add("WORD", model.WORD);
                parameter.Add("ENGLISH", model.ENGLISH);
                parameter.Add("VIETNAMESE", model.VIETNAMESE);
                parameter.Add("SPELLING", model.SPELLING);
                // gọi Execute để trả về số dòng ảnh hưởng khi insert
                var result = DbConnection.Execute(queryString, parameter);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
