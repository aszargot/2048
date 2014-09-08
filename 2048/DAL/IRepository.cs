using _2048.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.DAL
{
    public interface IRepository
    {
        bool Add(Score score);
        bool Update(Score score);
        bool Delete(Score score);
        IList<Score> GetAllScores(); 
    }
}
