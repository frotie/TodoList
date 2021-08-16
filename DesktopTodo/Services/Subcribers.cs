using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo.Services
{
    class MessageSubscriber : IDisposable
    {
        public Type MessageType { get; private set; }
        public Type ReceiverType { get; private set; }
        private Action<MessageSubscriber> _disponse;
        public MessageSubscriber(Type messageType, Type receiverType, Action<MessageSubscriber> disponse)
        {
            MessageType = messageType;
            ReceiverType = receiverType;
            _disponse = disponse;
        }
        public void Dispose()
        {
            _disponse(this);
        }
    }

    class EventSubscriber : IDisposable
    {
        public Type EventType { get; private set; }
        private Action<EventSubscriber> _disponse;
        public EventSubscriber(Type eventType, Action<EventSubscriber> disponse)
        {
            EventType = eventType;
            _disponse = disponse;
        }

        public void Dispose()
        {
            _disponse(this);
        }
    }
}