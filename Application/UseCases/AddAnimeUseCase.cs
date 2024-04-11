﻿using AnimesProtech.Domain.Entities;
using AnimesProtech.Domain.Interfaces.Repositorys;
using AnimesProtech.Domain.Interfaces.UseCases;

namespace AnimesProtech.Application.UseCases
{
    public class AddAnimeUseCase : IAddAnimeUseCase
    {
        private readonly IAnimeRepository _animeRepository;

        public AddAnimeUseCase(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public async Task<Anime> Execute(Anime anime)
        {
            if (anime == null)
            {
                throw new ArgumentNullException(nameof(anime));
            }

            return await _animeRepository.Add(anime);
        }
    }
}