using FileManager.interfaces;
using FileManager.Models.UserFileDataModels;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Services
{
    public class UserFileDataManagerService : IUserFileDataManager
    {
        public Task<Status> CreateDataFile(CreateDataFileModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Status> CreateUserFolder(CreateUserFolderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Status> DeleteDataFile(DeleteDataFileModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Status> DeleteUserFolder(DeleteUserFolderModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Status> UpdateDataFile(UpdateDataFileModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Status> UpdateUserFolder(UpdateUserFolderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
