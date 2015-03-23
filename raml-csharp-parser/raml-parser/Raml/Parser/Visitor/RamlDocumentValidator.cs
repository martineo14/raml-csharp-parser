using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raml.Parser.Raml.Parser.Loader;
using Raml.Parser.Raml.Parser.Rule;

namespace Raml.Parser.Raml.Parser.Visitor
{
    public class RamlDocumentValidator : YamlDocumentValidator
    {

    //    private TemplateResolver templateResolver;
    //private MediaTypeResolver mediaTypeResolver = new MediaTypeResolver();
    //private ResourceLoader resourceLoader;

    //public RamlDocumentValidator()
    //{
    //    //:base(Raml.class)
    //}

    //public RamlDocumentValidator(NodeRuleFactory nodeRuleFactory)
    //{
    //    base(Raml.class, nodeRuleFactory)
    //}

    //public TemplateResolver getTemplateResolver()
    //{
    //    if (templateResolver == null)
    //    {
    //        templateResolver = new TemplateResolver(resourceLoader, this);
    //    }
    //    return templateResolver;
    //}

    //public MediaTypeResolver getMediaTypeResolver()
    //{
    //    return mediaTypeResolver;
    //}

    ////@Override
    //public bool onMappingNodeStart(MappingNode mappingNode, TupleType tupleType)
    //{
    //    super.onMappingNodeStart(mappingNode, tupleType);
    //    if (tupleType == KEY)
    //    {
    //        return true;
    //    }
    //    NodeRule<?> rule = getRuleContext().peek();
    //    if (isResourceRule(rule))
    //    {
    //        List<ValidationResult> templateValidations = getTemplateResolver().resolve(
    //                mappingNode, getResourceUri(rule), getFullUri(rule));
    //        getMessages().addAll(templateValidations);
    //    }
    //    else if (isBodyRule(rule))
    //    {
    //        List<ValidationResult> mediaTypeValidations = getMediaTypeResolver().resolve(mappingNode);
    //        getMessages().addAll(mediaTypeValidations);
    //    }
    //    return true;
    //}

    //private string getResourceUri(NodeRule<?> resourceRule)
    //{
    //    Node keyNode = ((DefaultTupleRule) resourceRule).getKey();
    //    return ((ScalarNode) keyNode).getValue();
    //}

    //private string getFullUri(NodeRule<?> resourceRule)
    //{
    //    String fullUri = "";
    //    while (resourceRule instanceof ImplicitMapEntryRule)
    //    {
    //        Node keyNode = ((DefaultTupleRule) resourceRule).getKey();
    //        fullUri = ((ScalarNode) keyNode).getValue() + fullUri;
    //        resourceRule = ((DefaultTupleRule) resourceRule).getParentTupleRule();
    //    }
    //    return fullUri;
    //}

    //private bool isBodyRule(NodeRule<?> rule)
    //{
    //    return rule instanceof TypedTupleRule &&
    //           ((TypedTupleRule) rule).getValueType().getName().equals("org.raml.model.MimeType");
    //}

    //private bool isResourceRule(NodeRule<?> rule)
    //{
    //    return rule instanceof TypedTupleRule &&
    //           ((TypedTupleRule) rule).getValueType().getName().equals("org.raml.model.Resource");
    //}

    //public void setResourceLoader(ResourceLoader resourceLoader)
    //{
    //    this.resourceLoader = resourceLoader;
    //}

    ////@Override
    //public void onDocumentEnd(MappingNode node)
    //{
    //    validateBaseUriAndVersion();
    //    super.onDocumentEnd(node);
    //}

    //private void validateBaseUriAndVersion()
    //{
    //    BaseUriRule baseUriRule = getRule("baseUri");
    //    SimpleRule versionRule = getRule("version");

    //    if (versionRule.getKeyNode() == null && baseUriRule.getParameters().contains(versionRule.getName()))
    //    {
    //        ScalarNode node = baseUriRule.getValueNode();
    //        getMessages().add(ValidationResult.createErrorResult(BaseUriRule.VERSION_NOT_PRESENT_MESSAGE, node.getStartMark(), node.getEndMark()));
    //    }
    //}

    //private <T extends TupleRule> T getRule(String fieldName)
    //{
    //    //noinspection unchecked
    //    return (T) ((DefaultTupleRule) getRuleContext().peek()).getRuleByFieldName(fieldName);
    //}
    }
}
