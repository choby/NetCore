using System;

namespace Kendo.Mvc.UI
{
    // Summary:
    //     Enumerates the HTTP verbs.
    [Flags]
    public enum HttpVerbs
    {
        // Summary:
        //     Retrieves the information or entity that is identified by the URI of the
        //     request.
        Get = 1,
        //
        // Summary:
        //     Posts a new entity as an addition to a URI.
        Post = 2,
        //
        // Summary:
        //     Replaces an entity that is identified by a URI.
        Put = 4,
        //
        // Summary:
        //     Requests that a specified URI be deleted.
        Delete = 8,
        //
        // Summary:
        //     Retrieves the message headers for the information or entity that is identified
        //     by the URI of the request.
        Head = 16,
        //
        // Summary:
        //     Requests that a set of changes described in the request entity be applied
        //     to the resource identified by the Request- URI.
        Patch = 32,
        //
        // Summary:
        //     Represents a request for information about the communication options available
        //     on the request/response chain identified by the Request-URI.
        Options = 64,
    }
}