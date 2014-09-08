using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.DAL
{
    public class RepoEntity : IRepository
    {
        public bool Add(Model.Score score)
        {
            using (var ctx = new Context())
            {
                ctx.Scores.Add(score);
                ctx.SaveChanges();
                return true;
            }
        }

        public bool Update(Model.Score score)
        {
            using (var ctx = new Context())
            {
                ctx.Entry<_2048.Model.Score>(score).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
        }

        public bool Delete(Model.Score score)
        {
            using (var ctx = new Context())
            {
                ctx.Entry<_2048.Model.Score>(score).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
                return true;
            }
        }

        public IList<Model.Score> GetAllScores()
        {
            using (var ctx = new Context())
            {
                return ctx.Scores.ToList();
            }
        }
    }
}
