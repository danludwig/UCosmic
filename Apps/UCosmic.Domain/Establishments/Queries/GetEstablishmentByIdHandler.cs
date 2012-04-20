﻿using System;

namespace UCosmic.Domain.Establishments
{
    public class GetEstablishmentByIdHandler : IHandleQueries<GetEstablishmentByIdQuery, Establishment>
    {
        private readonly IQueryEntities _entities;

        public GetEstablishmentByIdHandler(IQueryEntities entities)
        {
            _entities = entities;
        }

        public Establishment Handle(GetEstablishmentByIdQuery query)
        {
            if (query == null) throw new ArgumentNullException("query");

            return _entities.Establishments
                .ByRevisionId(query.Id)
            ;
        }
    }
}
