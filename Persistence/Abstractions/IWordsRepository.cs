using System.Linq;
using NetCore.Persistence.Models;

namespace NetCore.Persistence.Abstractions
{
    public interface IWordsRepository
    {
        IQueryable<Word> All();
        Word Find(int id);
        IQueryable<Word> StartsWith(string filter);
        IQueryable<Word> EndWith(string filter);
    }
}