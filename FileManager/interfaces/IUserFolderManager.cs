using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.interfaces
{
    public interface IUserFolderManager
    {
        Status CreateUserFolder();
        Status UpdateUserFolder();
        Status DeleteUserFolder();
    }
}
