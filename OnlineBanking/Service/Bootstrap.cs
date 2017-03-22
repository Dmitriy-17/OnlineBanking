using AutoMapper;
using OnlineBanking.Models.Account;

namespace OnlineBanking.Service
{
    public class Bootstrap
    {
        public static void InitMapper()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserLogin>()
                .ForMember("Login", opt => opt.MapFrom(src => src.Login)));

            Mapper.Initialize(cfg => cfg.CreateMap<User, UserRegister>()
                .ForMember("Login", opt => opt.MapFrom(src => src.Login))
                .ForMember("Name", opt => opt.MapFrom(src => src.Name))
                .ForMember("Email", opt => opt.MapFrom(src => src.Email))
                .ForMember("Password", opt => opt.MapFrom(src => src.Password))
                );

            Mapper.Initialize(cfg => cfg.CreateMap<UserRegister, User>()
                .ForMember("Login", opt => opt.MapFrom(src => src.Login))
                .ForMember("Name", opt => opt.MapFrom(src => src.Name))
                .ForMember("Email", opt => opt.MapFrom(src => src.Email))
                .ForMember("Password", opt => opt.MapFrom(src => src.Password))
                );
        }
    }
}