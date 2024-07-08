using FileManager.Models.UserFileDataModels;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.interfaces
{
    public interface IUserFileDataManager
    {
        Task<Status> CreateUserFolder(CreateUserFolderModel model);
        Task<Status> UpdateUserFolder(UpdateUserFolderModel model);
        Task<Status> DeleteUserFolder(DeleteUserFolderModel model);

        Task<Status> CreateDataFile(CreateDataFileModel model);
        Task<Status> UpdateDataFile(UpdateDataFileModel model);
        Task<Status> DeleteDataFile(DeleteDataFileModel model);
    }
}
