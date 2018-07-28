using System;
using System.Collections.Generic;
using System.Linq;
using NetCore.Persistence.Abstractions;
using NetCore.Persistence.Models;

namespace NetCore.Persistence
{
    public class WordsRepository : IWordsRepository
    {
        private static IList<Word> words;

        public WordsRepository()
        {
            LoadHardcodedWords();
        }

        public IQueryable<Word> All()
        {
            EnsureWordsAreLoaded();
            return words.AsQueryable();
        }

        public IQueryable<Word> EndWith(string filter)
        {
            EnsureWordsAreLoaded();
            return words.Where(x => x.Text.EndsWith(filter)).AsQueryable();
        }

        public Word Find(int id)
        {
            EnsureWordsAreLoaded();
            return words.SingleOrDefault(x => x.Id.Equals(id));
        }

        public IQueryable<Word> StartsWith(string filter)
        {
            EnsureWordsAreLoaded();
            return words.Where(x => x.Text.EndsWith(filter)).AsQueryable();
        }

        private static void EnsureWordsAreLoaded()
        {
            if (words == null)
            {
                words = LoadHardcodedWords();
            }
        }

        private static IList<Word> LoadHardcodedWords()
        {
            return new List<Word>{
                new Word {
                    Id = 0,
                    Text = "astrobleme"
                },
                new Word {
                    Id = 1,
                    Text = "bibliopole"
                },
                new Word {
                    Id = 2,
                    Text = "cerulean"
                }
            };
        }
    }
}