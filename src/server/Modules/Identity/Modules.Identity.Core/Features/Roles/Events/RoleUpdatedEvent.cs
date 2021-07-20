﻿using System;
using FluentPOS.Modules.Identity.Core.Entities;
using FluentPOS.Shared.Core.Domain;

namespace FluentPOS.Modules.Identity.Core.Features.Roles.Events
{
    public class RoleUpdatedEvent : Event
    {
        public RoleUpdatedEvent(FluentRole role)
        {
            Name = role.Name;
            Description = role.Description;
            Id = role.Id;
            if (Guid.TryParse(role.Id, out var aggregateId))
            {
                AggregateId = aggregateId;
            }
        }

        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}