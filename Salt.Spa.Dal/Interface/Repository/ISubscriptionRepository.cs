﻿using Salt.Spa.Dal.Entity;
using System.Collections.Generic;

namespace Salt.Spa.Dal.Interface
{
    public interface ISubscriptionRepository
    {
        Subscription FindBySubscription(string number);
    }
}
