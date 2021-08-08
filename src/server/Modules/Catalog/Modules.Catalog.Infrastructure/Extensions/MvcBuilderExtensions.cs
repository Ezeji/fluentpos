﻿// <copyright file="MvcBuilderExtensions.cs" company="Fluentpos">
// --------------------------------------------------------------------------------------------------
// Copyright (c) Fluentpos. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------
// </copyright>

using System.Reflection;
using FluentPOS.Modules.Catalog.Core.Abstractions;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace FluentPOS.Modules.Catalog.Infrastructure.Extensions
{
    internal static class MvcBuilderExtensions
    {
        internal static IMvcBuilder AddCatalogValidation(this IMvcBuilder builder)
        {
            return builder.AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(ICatalogDbContext))));
        }
    }
}