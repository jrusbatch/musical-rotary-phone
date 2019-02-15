using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class FooRepository
    {
        private readonly Database _db;

        public FooRepository()
        {
            _db = new Database(@"Data Source=(LocalDB)\MSSqlLocalDb");
        }

        public IEnumerable<object> GetFoos()
        {
            return _db.Query("select * from foo");
        }
    }
}
