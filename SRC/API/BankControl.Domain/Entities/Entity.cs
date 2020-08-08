﻿using BankControl.Domain.Notifications;
using System;

namespace BankControl.Domain.Entities
{
    public abstract class Entity : Notifiable , IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
