using Raml.Parser.Raml.Model.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raml.Parser.Raml.Model
{
    public class Action
    {
        private static readonly long serialVersionUID = 8444315314405971949L;

    //@Key
    private ActionType type;

    //@Scalar
    private String description;

    //@Mapping
    private Dictionary<String, Header> headers = new Dictionary<String, Header>();

    //@Mapping
    private Dictionary<String, QueryParameter> queryParameters = new Dictionary<String, QueryParameter>();

    //@Mapping(innerHandler = MimeTypeHandler.class)
    private Dictionary<String, MimeType> body;

    //@Mapping(innerHandler = ResponseHandler.class)
    private Dictionary<String, Response> responses = new Dictionary<String, Response>();

    //@Parent
    private Resource resource;

    //@Sequence
    private List<String> ais = new List<String>();

    //@Sequence
    private List<Protocol> protocols = new List<Protocol>();

    //@Sequence(rule = SecurityReferenceSequenceRule.class)
    private List<SecurityReference> securedBy = new List<SecurityReference>();

    //@Mapping(rule = org.raml.parser.rule.UriParametersRule.class)
    private Dictionary<String, List<UriParameter>> baseUriParameters = new Dictionary<String, List<UriParameter>>();

    public Action()
    {
    }

    public ActionType getType()
    {
        return type;
    }

    public void setType(ActionType type)
    {
        this.type = type;
    }

    public String getDescription()
    {
        return description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    public Dictionary<String, Header> getHeaders()
    {
        return headers;
    }

    public void setHeaders(Dictionary<String, Header> headers)
    {
        this.headers = headers;
    }

    public Dictionary<String, QueryParameter> getQueryParameters()
    {
        return queryParameters;
    }

    public void setQueryParameters(Dictionary<String, QueryParameter> queryParameters)
    {
        this.queryParameters = queryParameters;
    }

    public Dictionary<String, MimeType> getBody()
    {
        return body;
    }

    public void setBody(Dictionary<String, MimeType> body)
    {
        this.body = body;
    }

    public bool hasBody()
    {
        return body != null && !body.Any();
    }

    public Dictionary<String, Response> getResponses()
    {
        return responses;
    }

    public void setResponses(Dictionary<String, Response> responses)
    {
        this.responses = responses;
    }

    public Resource getResource()
    {
        return resource;
    }

    public void setResource(Resource resource)
    {
        this.resource = resource;
    }

    public List<String> getIs()
    {
        return ais;
    }

    public void setIs(List<String> ais)
    {
        this.ais = ais;
    }

    public List<Protocol> getProtocols()
    {
        return protocols;
    }

    public void setProtocols(List<Protocol> protocols)
    {
        this.protocols = protocols;
    }

    public List<SecurityReference> getSecuredBy()
    {
        return securedBy;
    }

    public void setSecuredBy(List<SecurityReference> securedBy)
    {
        this.securedBy = securedBy;
    }

    public Dictionary<String, List<UriParameter>> getBaseUriParameters()
    {
        return baseUriParameters;
    }

    public void setBaseUriParameters(Dictionary<String, List<UriParameter>> baseUriParameters)
    {
        this.baseUriParameters = baseUriParameters;
    }

    //@Override
    //public override String toString()
    //{
    //    return "Action{" +
    //           "type='" + type + '\'' +
    //           ", resource=" + (resource != null ? resource.getUri() : "-") + '}';
    //}
    }
}
