using Memo.DBContext;
using Memo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.MemoRepositories
{
    
    public class MemoRepository
    {
        MemoDbContext memoDbContext = new MemoDbContext();
        public List<Supplier> GetSuppliers()
        {
            return memoDbContext.Suppliers.ToList();
        }
        public List<Buyer> GetBuyers()
        {
            return memoDbContext.Buyers.ToList();
        }
        public List<Item> GetItems()
        {
            return memoDbContext.Items.ToList();
        }

    }
}
