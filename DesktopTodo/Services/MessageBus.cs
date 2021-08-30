using DesktopTodo.Messages;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo.Services
{
    class MessageBus : ISingleton
    {
        private readonly ConcurrentDictionary<MessageSubscriber, Func<IMessage, Task>> _consumers;
        public MessageBus()
        {
            _consumers = new ConcurrentDictionary<MessageSubscriber, Func<IMessage, Task>>();
        }

        public IDisposable Receive<TMessage>(object receiver, Func<TMessage, Task> action) where TMessage : IMessage
        {
            var message = new MessageSubscriber(typeof(TMessage), receiver.GetType(), e => _consumers.TryRemove(e, out _));
            _consumers.TryAdd(message, a => action((TMessage)a));
            return message;
        }

        public void SendTo<TReceiver>(IMessage message)
        {
            var messages = _consumers
                .Where(c => c.Key.MessageType == message.GetType() && c.Key.ReceiverType == typeof(TReceiver))
                .Select(c => c.Value(message));

            Task.WhenAll(messages);
        }
    }
}
