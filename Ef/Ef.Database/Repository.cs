using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Database
{
    public static class Repository
    {
        public static void Add<T>(T item) where T : class
        {
            using var context = new CarLotContext();
            context.Set<T>().Add(item);
            context.SaveChanges();
        }
        public static void Update<T>(T item) where T : class
        {
            using var context = new CarLotContext();
            context.Set<T>().Update(item);
            context.SaveChanges();
        }
        public static void Remove<T>(T item) where T : class
        {
            using var context = new CarLotContext();
            context.Set<T>().Remove(item);
            context.SaveChanges();
        }
        public static T Get<T>(int id) where T : class
        {
            using var context = new CarLotContext();
            return context.Set<T>().Find(id);
        }
        public static List<T> Find<T>() where T : class
        {
            using var context = new CarLotContext();
            return context.Set<T>().ToList();
        }
    }
}
