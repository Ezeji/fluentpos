﻿#nullable enable
using System;

namespace FluentPOS.Shared.DTOs.ExtendedAttributes
{
    public record GetAllPagedExtendedAttributesResponse(Guid Id, Guid EntityId, ExtendedAttributeType Type, string Key, decimal? Decimal, string? Text, DateTime? DateTime, string? Json, string? ExternalId, string? Group, string? Description, bool IsActive);
}