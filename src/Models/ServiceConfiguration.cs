﻿using NSwag.Commands;
using NSwag.Commands.CodeGeneration;

namespace Unchase.OpenAPI.ConnectedService.Models
{
    internal class ServiceConfiguration
    {
        public string ServiceName { get; set; }

        public string Endpoint { get; set; }

        public string GeneratedFileNamePrefix { get; set; }

        public bool GenerateCSharpClient { get; set; } = false;

        public bool GenerateTypeScriptClient { get; set; } = false;

        public bool GenerateCSharpController { get; set; } = false;

        public SwaggerToCSharpClientCommand SwaggerToCSharpClientCommand { get; set; }

        public SwaggerToTypeScriptClientCommand SwaggerToTypeScriptClientCommand { get; set; }

        public SwaggerToCSharpControllerCommand SwaggerToCSharpControllerCommand { get; set; }

        public string Variables { get; set; }

        public Runtime Runtime { get; set; }

        public bool CopySpecification { get; set; }

        public bool OpenGeneratedFilesOnComplete { get; set; }

        #region Network Credentials
        public bool UseNetworkCredentials { get; set; }
        public string NetworkCredentialsUserName { get; set; }
        public string NetworkCredentialsPassword { get; set; }
        public string NetworkCredentialsDomain { get; set; }
        #endregion

        #region WebProxy
        public string WebProxyUri { get; set; }
        public bool UseWebProxy { get; set; }
        public bool UseWebProxyCredentials { get; set; }
        public string WebProxyNetworkCredentialsUserName { get; set; }
        public string WebProxyNetworkCredentialsPassword { get; set; }
        public string WebProxyNetworkCredentialsDomain { get; set; }
        #endregion
    }
}
