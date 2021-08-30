using DesktopTodo.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo.Services
{
    class EventBus : ISingleton
    {
        private readonly ConcurrentDictionary<EventSubscriber, Func<IEvent, Task>> _subscribers;
        public EventBus()
        {
            _subscribers = new ConcurrentDictionary<EventSubscriber, Func<IEvent, Task>>();
        }

        public IDisposable Subscribe<TEvent>(Func<TEvent, Task> action) where TEvent : IEvent
        {
            var sub = new EventSubscriber(typeof(TEvent), e => _subscribers.TryRemove(e, out _));
            _subscribers.TryAdd(sub, a => action((TEvent)a));
            return sub;
        }

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var tasks = _subscribers
                .Where(c => c.Key.EventType == @event.GetType())
                .Select(c => c.Value(@event));

            Task.WhenAll(tasks);
        }
    }
}
