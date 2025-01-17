﻿using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace ai.adoptionpack.speechkit.hybrid.client
{
    abstract class SpeechKitAbstractClient
    {

        protected Serilog.ILogger log;

        protected Uri endpointAddress;


        protected SpeechKitAbstractClient(Uri address)
        {
            this.log = Log.Logger;
            this.endpointAddress = address;
        }


        protected GrpcChannel MakeChannel(ILoggerFactory loggerFactory)
        {

           // ILoggerFactory loggerFactory = Program.serviceProvider.GetService<ILoggerFactory>();

            return GrpcChannel.ForAddress(this.endpointAddress,  new GrpcChannelOptions { LoggerFactory = loggerFactory });
        }

        protected Metadata MakeMetadata()
        {
            Metadata serviceMetadata = new Metadata();
           // serviceMetadata.Add("authorization", $"Bearer {IamToken}");
            serviceMetadata.Add("x-data-logging-enabled", "true"); // 

            String requestId = Guid.NewGuid().ToString();

            serviceMetadata.Add("x-client-request-id", requestId); /* уникальный идентификатор запроса. Рекомендуем использовать UUID. 
            Сообщите этот идентификатор технической поддержке, чтобы мы смогли найти конкретрный запрос в системе и помочь вам.*/
            log.Information($"Metadata configured for request: {requestId}");
            return serviceMetadata;
        }
    }
}
