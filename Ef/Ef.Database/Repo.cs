using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ef.Database
{
    public class Repo<T> where T : class
    {
        private CarLotContext _context = null;
        private DbSet<T> table = null;

        public Repo()
        {
            this._context = new CarLotContext();
            table = _context.Set<T>();
        }

        public Repo(CarLotContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> Find()
        {
            return table.ToList();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public void Add(T item)
        {
            table.Add(item);
        }

        public void Update(T item)
        {
            table.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
