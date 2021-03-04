﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Microsoft.Diagnostics.Monitoring.OpenApiGen
{
    /// <summary>
    /// Adds an UnauthorizedResponse response component to the document.
    /// </summary>
    internal sealed class UnauthorizedResponseDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            OpenApiHeader authenticateHeader = new OpenApiHeader();
            authenticateHeader.Schema = new OpenApiSchema() { Type = "string" };

            OpenApiResponse unauthorizedResponse = new OpenApiResponse();
            unauthorizedResponse.Description = "Unauthorized";
            unauthorizedResponse.Headers.Add("WWW_Authenticate", authenticateHeader);

            swaggerDoc.Components.Responses.Add(
                ResponseNames.UnauthorizedResponse,
                unauthorizedResponse);
        }
    }
}
