﻿namespace SimilarBeads.Web.ViewModels.Song
{
    using Artist;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class SongViewModel : IMapFrom<Song>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ArtistViewModel Artist { get; set; }

        public string ArtistName { get; set; }

        public int NumberOfPlays { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Song, SongViewModel>()
                .ForMember(x => x.ArtistName, opt => opt.MapFrom(a => a.Artist.Name))
                .ForMember(x => x.Artist, opt => opt.MapFrom(x => x.Artist));
        }
    }
}
