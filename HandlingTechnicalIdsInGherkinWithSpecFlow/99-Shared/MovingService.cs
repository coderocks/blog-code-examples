﻿using System;

namespace HandlingTechnicalIdsInGherkinWithSpecFlow.Shared
{
    public class MovingService
    {
        private readonly IPeopleRepository _peopleRepository;

        public MovingService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository ?? throw new ArgumentNullException(nameof(peopleRepository));
        }

        public void MovePerson(Guid personId, string newAddress)
        {
            var person = _peopleRepository.GetById(personId);
            person.Address = newAddress;
        }
    }
}
