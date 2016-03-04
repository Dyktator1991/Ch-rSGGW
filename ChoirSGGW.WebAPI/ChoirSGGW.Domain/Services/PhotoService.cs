using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class PhotoService : IPhotoService
    {
        readonly IPhotoRepository photoRepository;

        public PhotoService(IPhotoRepository photoRepository)
        {
            this.photoRepository = photoRepository;
        }
    }
}
