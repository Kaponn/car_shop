using System;
using System.Collections.Generic;
using System.Text;

namespace Ef.Database
{
    public class SaveRepository
    {
        public SaveRepository() { }

        public void Save<T>(T data) where T : class
        {
            using var carLotContext = new CarLotContext();
            carLotContext.Set<T>().Update(data);
            carLotContext.SaveChanges();
        }
    }
}
