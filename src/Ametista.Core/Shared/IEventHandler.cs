﻿using System.Threading.Tasks;

namespace Ametista.Core.Interfaces
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        Task Handle(TEvent e);
    }
}