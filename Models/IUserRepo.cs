using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    interface IUserRepo
    {
        IEnumerable<Slice> GetAllUsers();

        bool addUser(Slice slice);

        bool deleteUser(int userID);

        bool updateUser(Slice slice);
    }
}
