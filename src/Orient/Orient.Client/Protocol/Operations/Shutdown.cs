using Orient.Client.Protocol.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orient.Client.Protocol.Operations
{
    internal class Shutdown : IOperation
    {
        internal string UserName { get; set; }
        internal string UserPassword { get; set; }

        public Request Request(int sessionID)
        {
            Request request = new Request();

            // standard request fields
            request.DataItems.Add(new RequestDataItem() { Type = "byte", Data = BinarySerializer.ToArray((byte)OperationType.SHUTDOWN) });
            request.DataItems.Add(new RequestDataItem() { Type = "int", Data = BinarySerializer.ToArray(sessionID) });

            // operation specific fields
            request.DataItems.Add(new RequestDataItem() { Type = "string", Data = BinarySerializer.ToArray(UserName) });
            request.DataItems.Add(new RequestDataItem() { Type = "string", Data = BinarySerializer.ToArray(UserPassword) });

            return request;
        }

        public ODocument Response(Response response)
        {
            // there are no specific response fields processing for this operation

            return null;
        }
    }
}
