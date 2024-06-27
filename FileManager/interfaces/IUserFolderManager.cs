﻿using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.interfaces
{
    public interface IUserFolderManager
    {
        Task<Status> CreateUserFolder();
        Task<Status> UpdateUserFolder();
        Task<Status> DeleteUserFolder();
    }
}
