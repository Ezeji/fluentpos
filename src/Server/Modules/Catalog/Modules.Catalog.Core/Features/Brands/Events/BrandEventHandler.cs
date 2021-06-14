﻿using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FluentPOS.Modules.Catalog.Core.Features.Brands.Events
{
    public class BrandEventHandler :
         INotificationHandler<BrandRegisteredEvent>
    {
        private readonly ILogger<BrandEventHandler> logger;

        public BrandEventHandler(ILogger<BrandEventHandler> logger)
        {
            this.logger = logger;
        }

        public Task Handle(BrandRegisteredEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation($"BrandRegisteredEvent Raised.");
            return Task.CompletedTask;
        }
    }
}
