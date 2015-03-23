using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raml.Parser.Raml.Parser.Loader;
using Raml.Parser.Raml.Parser.Visitor;
using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace Raml.Parser.Raml.Parser.TagResolver
{
    public class PojoValidatorTagResolver : TagResolver
    {
        public override bool Handles(Tag tag)
        {
            throw new NotImplementedException();
        }

        public override YamlNode Resolve(YamlNode valueNode, ResourceLoader resourceLoader, NodeHandler nodeHandler)
        {
            throw new NotImplementedException();
        }

        public override void BeforeProcessingResolvedNode(Tag tag, YamlNode originalNode, YamlNode resolvedNode)
        {
            throw new NotImplementedException();
        }

        public override void AfterProcessingResolvedNode(Tag tag, YamlNode originalNode, YamlNode resolvedNode)
        {
            throw new NotImplementedException();
        }
    }
}
