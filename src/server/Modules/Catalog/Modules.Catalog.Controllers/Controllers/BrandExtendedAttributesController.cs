﻿using System;
using System.Threading.Tasks;
using FluentPOS.Modules.Catalog.Core.Entities;
using FluentPOS.Shared.Core.Constants;
using FluentPOS.Shared.Core.Features.ExtendedAttributes.Commands;
using FluentPOS.Shared.DTOs.ExtendedAttributes;
using FluentPOS.Shared.Infrastructure.Controllers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FluentPOS.Modules.Catalog.Controllers
{
    [Route(BaseController.BasePath + "/" + nameof(Brand) + "/attributes")]
    public class BrandExtendedAttributesController : ExtendedAttributesController<Brand>
    {
        private IMediator _mediatorInstance;
        protected override IMediator Mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        [Authorize(Policy = Permissions.BrandsExtendedAttributes.ViewAll)]
        public override Task<IActionResult> GetAll(PaginatedExtendedAttributeFilter filter)
        {
            return base.GetAll(filter);
        }

        [Authorize(Policy = Permissions.BrandsExtendedAttributes.View)]
        public override Task<IActionResult> GetById(Guid id, bool bypassCache)
        {
            return base.GetById(id, bypassCache);
        }

        [Authorize(Policy = Permissions.BrandsExtendedAttributes.Add)]
        public override Task<IActionResult> Create(AddExtendedAttributeCommand<Brand> command)
        {
            return base.Create(command);
        }

        [Authorize(Policy = Permissions.BrandsExtendedAttributes.Update)]
        public override Task<IActionResult> Update(UpdateExtendedAttributeCommand<Brand> command)
        {
            return base.Update(command);
        }

        [Authorize(Policy = Permissions.BrandsExtendedAttributes.Remove)]
        public override Task<IActionResult> Remove(Guid id)
        {
            return base.Remove(id);
        }
    }
}