using System;
using System.Collections.Generic;

namespace Polymorphism
{
    // declare type of vars, but do not assign
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new IList<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // do encoding of video
            foreach (INotificationChannel element in _notificationChannels)
            {
                element.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
