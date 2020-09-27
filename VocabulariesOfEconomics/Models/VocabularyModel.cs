using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocabulariesOfEconomics.Models
{
    public class VocabularyModel
    {
        public int ID { get; set; }
        public string ENGLISH { get; set; }
        public string VIETNAMESE { get; set; }
        public string SPELLING { get; set; }
    }
    public class VocabularyQueryModel
    {
        public string FilterText { get; set; }
        public string FilterBy { get; set; }
    }
}
