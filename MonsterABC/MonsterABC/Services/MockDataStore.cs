using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonsterABC.Models;

namespace MonsterABC.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Aa", Description="di baca = a ", Image = "A.png", Audio = "A.mp3", Iklan = "True" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Bb", Description="di baca = be ", Image = "B.png", Audio = "B.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cc", Description="di baca = ce ", Image = "C.png", Audio = "C.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dd", Description="di baca = de ", Image = "D.png", Audio = "D.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ee", Description="di baca = e ", Image = "E.png", Audio = "E.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ff", Description="di baca = ef ", Image = "F.png", Audio = "F.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Gg", Description="di baca = ge ", Image = "G.png", Audio = "G.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Hh", Description="di baca = ha ", Image = "H.png", Audio = "H.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ii", Description="di baca = i ", Image = "I.png", Audio = "I.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Jj", Description="di baca = je ", Image = "J.png", Audio = "J.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Kk", Description="di baca = ka ", Image = "K.png", Audio = "K.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ll", Description="di baca = el ", Image = "L.png", Audio = "L.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Mm", Description="di baca = em ", Image = "M.png", Audio = "M.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Nn", Description="di baca = en ", Image = "N.png", Audio = "N.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Oo", Description="di baca = o ", Image = "O.png", Audio = "O.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Pp", Description="di baca = pe ", Image = "P.png", Audio = "P.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Qq", Description="di baca = ki ", Image = "Q.png", Audio = "Q.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rr", Description="di baca = er ", Image = "R.png", Audio = "R.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ss", Description="di baca = es ", Image = "S.png", Audio = "S.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tt", Description="di baca = te ", Image = "T.png", Audio = "T.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Uu", Description="di baca = u ", Image = "U.png", Audio = "U.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Vv", Description="di baca = ve ", Image = "V.png", Audio = "V.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Ww", Description="di baca = we ", Image = "W.png", Audio = "W.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Xx", Description="di baca = eks ", Image = "X.png", Audio = "X.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Yy", Description="di baca = ye ", Image = "Y.png", Audio = "Y.mp3", Iklan = "False" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Zz", Description="di baca = zet ", Image = "Z.png", Audio = "Z.mp3", Iklan = "True" },



            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}