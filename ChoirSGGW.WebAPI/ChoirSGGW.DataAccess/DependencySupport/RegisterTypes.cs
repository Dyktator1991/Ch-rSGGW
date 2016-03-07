using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.DataAccess.Repositories.TypesRepository;
using ChoirSGGW.DataAccess.Repositories.TypesRepository.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.DependencySupport
{
    public class RegisterTypes
    {
        private readonly IUnityContainer unityContainer;

        public RegisterTypes(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public IUnityContainer BuildUnityContainer()
        {
            //Repository
            unityContainer.RegisterType<IAchievementRepository, AchievementRepository>();
            unityContainer.RegisterType<IConcertRepository, ConcertRepository>();
            unityContainer.RegisterType<IPhotoRepository, PhotoRepository>();
            unityContainer.RegisterType<IRepertoireRepository, RepertoireRepository>();
            unityContainer.RegisterType<ISampleRepository, SampleRepository>();
            unityContainer.RegisterType<ISongNoteRepository, SongNoteRepository>();
            unityContainer.RegisterType<ITopicalityRepository, TopicalityRepository>();
            unityContainer.RegisterType<IVideoRepository, VideoRepository>();

            //TypeRepository
            unityContainer.RegisterType<IClotheTypesRepository, ClotheTypesRepository>();
            unityContainer.RegisterType<ISongsTypeRepository, SongsTypeRepository>();
            unityContainer.RegisterType<ITopicalityTypeRepository, TopicalityTypeRepository>();
            unityContainer.RegisterType<IUserTypesRepository, UserTypesRepository>();

            //context
            unityContainer.RegisterType<IChoirContext, ChoirContext>();

            return unityContainer;
        }
    }
}
