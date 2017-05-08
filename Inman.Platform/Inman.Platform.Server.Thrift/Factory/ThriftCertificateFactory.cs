using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inman.Platform.ThriftServer.Factory
{
    public class ThriftCertificateFactory
    {
        private ThriftServerConfiguration config;
        public ThriftCertificateFactory(ThriftServerConfiguration config)
        {
            this.config = config;
        }
        public X509Certificate2 GetCertificate()
        {
            // due to files location in net core better to take certs from top folder
            var certFile = GetCertPath(Directory.GetParent(Directory.GetCurrentDirectory()));
            return new X509Certificate2(certFile, "ThriftTest");
        }

        private  string GetCertPath(DirectoryInfo di, int maxCount = 6)
        {
            var topDir = di;
            var certFile =
                topDir.EnumerateFiles("ThriftTest.pfx", SearchOption.AllDirectories)
                    .FirstOrDefault();
            if (certFile == null)
            {
                if (maxCount == 0)
                    throw new FileNotFoundException("Cannot find file in directories");
                return GetCertPath(di.Parent, maxCount - 1);
            }

            return certFile.FullName;
        }

        public X509Certificate LocalCertificateSelectionCallback(object sender,
        string targetHost, X509CertificateCollection localCertificates,
        X509Certificate remoteCertificate, string[] acceptableIssuers)
        {
            return GetCertificate();
        }
    }
}
