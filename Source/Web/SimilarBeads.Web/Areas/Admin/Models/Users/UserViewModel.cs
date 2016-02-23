﻿namespace SimilarBeads.Web.Areas.Admin.Models.Users
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class UserViewModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public int? Subscribers { get; set; }

        public bool IsArtist { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, UserViewModel>()
                .ForMember(x => x.City, opt => opt.MapFrom(u => u.City.Name));
        }
    }
}
